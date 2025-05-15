using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace RegexGenerator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            InitializeCustomComponents();
            SetupEventHandlers();
        }

        private void InitializeCustomComponents()
        {
            // Initialize combo box items
            cmbRegexFlavor.Items.AddRange(new object[] { ".NET", "JavaScript", "Python", "POSIX" });
            cmbRegexFlavor.SelectedIndex = 0;

            // Set default status text
            UpdateStatus("Ready");
        }

        private void SetupEventHandlers()
        {
            // Menu items
            newToolStripMenuItem.Click += (s, e) => ClearAll();
            openToolStripMenuItem.Click += OpenToolStripMenuItem_Click;
            saveToolStripMenuItem.Click += SaveToolStripMenuItem_Click;
            exitToolStripMenuItem.Click += (s, e) => Close();
            copyToolStripMenuItem.Click += (s, e) => CopyToClipboard();
            aboutToolStripMenuItem.Click += ShowAboutDialog;

            // Buttons
            btnAnalyze.Click += BtnAnalyze_Click;
            btnCopyRegex.Click += (s, e) => CopyToClipboard();
            btnSaveRegex.Click += SaveToolStripMenuItem_Click;
            btnTestRegex.Click += BtnTestRegex_Click;

            // Other events
            txtSampleText.TextChanged += (s, e) => UpdateStatus("Editing sample text...");
        }

        private void BtnAnalyze_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSampleText.Text))
            {
                MessageBox.Show("Please enter some sample text first.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Cursor = Cursors.WaitCursor;
                string sampleText = txtSampleText.Text;

                // Generate initial regex
                string generatedRegex = GenerateRegexFromSample(sampleText);

                // Apply additional processing
                generatedRegex = DetectAndReplaceCustomPatterns(generatedRegex);
                generatedRegex = SimplifyGeneratedRegex(generatedRegex);

                txtGeneratedRegex.Text = generatedRegex;
                UpdateStatus("Regex generated successfully");

                // Auto-switch to tester tab if there's test text
                if (!string.IsNullOrWhiteSpace(txtTestText.Text))
                {
                    tcMain.SelectedTab = tpTester;
                    txtTestText.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating regex: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                UpdateStatus("Error generating regex");
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }
        private string DetectAndReplaceCustomPatterns(string pattern)
        {
            // Phone numbers (US format)
            pattern = Regex.Replace(pattern,
                @"\\(\\d{3}\\)\\s?\\d{3}\\-\\d{4}",
                @"\(\d{3}\)\s?\d{3}\-\d{4}");

            // IP addresses
            pattern = Regex.Replace(pattern,
                @"\\d{1,3}\\.\\d{1,3}\\.\\d{1,3}\\.\\d{1,3}",
                @"\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}");

            // HTML tags (simple detection)
            pattern = Regex.Replace(pattern,
                @"\\<[^\\>]+\\>",
                @"\<[^\>]+\>");

            return pattern;
        }

        private string SimplifyGeneratedRegex(string pattern)
        {
            // Remove unnecessary escapes for spaces
            pattern = pattern.Replace(@"\ ", " ");

            // Simplify quantifiers
            pattern = Regex.Replace(pattern, @"(\\[dwDsS])\+\\s(\\[dwDsS])\+", "$1+$2+");

            return pattern;
        }

        private void BtnTestRegex_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtGeneratedRegex.Text))
            {
                MessageBox.Show("Please generate a regex first.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                TestRegex();
                UpdateStatus("Regex tested successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error testing regex: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                UpdateStatus("Error testing regex");
            }
        }

        private string GenerateRegexFromSample(string sampleText)
        {
            if (string.IsNullOrWhiteSpace(sampleText))
                return string.Empty;

            // Tokenize sample by whitespace
            var tokens = sampleText.Split(new[] { ' ', '\t', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            var patternParts = new List<string>();

            foreach (var token in tokens)
            {
                string tokenPattern = DetectTokenPattern(token);
                patternParts.Add(tokenPattern);
            }

            return string.Join(@"\s+", patternParts);
        }
        private string DetectTokenPattern(string token)
        {
            if (Regex.IsMatch(token, @"^\d{4}[-\/\.]\d{2}[-\/\.]\d{2}$"))
                return @"\d{4}[-\/\.]\d{2}[-\/\.]\d{2}";
            if (Regex.IsMatch(token, @"^\d{2}:\d{2}(:\d{2})?(\.\d+)?$"))
                return @"\d{2}:\d{2}(:\d{2})?(\.\d+)?";
            if (Regex.IsMatch(token, @"^\d+$"))
                return @"\d+";
            if (Regex.IsMatch(token, @"^\d+\.\d+$"))
                return @"\d+\.\d+";
            if (Regex.IsMatch(token, @"^\w+$"))
                return @"\w+";
            if (Regex.IsMatch(token, @"^#[\w\d]+$"))
                return @"#\w+";
            if (Regex.IsMatch(token, @"^'.*'$"))
                return @"'.*?'";

            // Default: escape the token
            return Regex.Escape(token);
        }



        private string DetectAndReplaceCommonPatterns(string pattern)
        {
            // Dates (YYYY-MM-DD or YYYY/MM/DD or YYYY.MM.DD)
            pattern = Regex.Replace(pattern,
                @"\\d{4}[\\-\\/\\.]\\d{2}[\\-\\/\\.]\\d{2}",
                @"\d{4}[-\/\.]\d{2}[-\/\.]\d{2}");

            // Times (HH:MM:SS or HH:MM)
            pattern = Regex.Replace(pattern,
                @"\\d{2}\\:\\d{2}(\\:\\d{2})?",
                @"\d{2}:\d{2}(:\d{2})?");

            // Email addresses
            pattern = Regex.Replace(pattern,
                @"\\w+([\\-\\.\\+]\\w+)*\\@\\w+([\\-\\.]\\w+)*\\.\\w+([\\-\\.]\\w+)*",
                @"\w+([-\.\+]\w+)*@\w+([-\.]\w+)*\.\w+([-\.]\w+)*");

            // URLs
            pattern = Regex.Replace(pattern,
                @"(http|https)\\:\\/\\/[\\w\\-\\.]+(\\/[\\w\\-\\.\\?\\=\\&\\%]*)*",
                @"(http|https):\/\/[\w\-\.]+(\/[\w\-\.\?\=\&\%]*)*");

            // Numbers (integers and decimals)
            pattern = Regex.Replace(pattern,
                @"\\d+\\.?\\d*",
                @"\d+\.?\d*");

            // Words (sequences of letters)
            pattern = Regex.Replace(pattern,
                @"\\p{L}+",
                @"\p{L}+");

            // Whitespace (normalize all whitespace)
            pattern = Regex.Replace(pattern,
                @"\\s+",
                @"\s+");

            // GUIDs/UUIDs
            pattern = Regex.Replace(pattern,
                @"\\{[0-9a-fA-F]{8}\\-[0-9a-fA-F]{4}\\-[0-9a-fA-F]{4}\\-[0-9a-fA-F]{4}\\-[0-9a-fA-F]{12}\\}",
                @"\{[0-9a-fA-F]{8}\-[0-9a-fA-F]{4}\-[0-9a-fA-F]{4}\-[0-9a-fA-F]{4}\-[0-9a-fA-F]{12}\}");

            // Credit card numbers (simplified)
            pattern = Regex.Replace(pattern,
                @"\\d{4}[\\-\\s]?\\d{4}[\\-\\s]?\\d{4}[\\-\\s]?\\d{4}",
                @"\d{4}[-\s]?\d{4}[-\s]?\d{4}[-\s]?\d{4}");

            return pattern;
        }

        private void TestRegex()
        {
            dgvMatches.Rows.Clear();

            RegexOptions options = GetSelectedOptions();
            Regex regex = new Regex(txtGeneratedRegex.Text, options);

            MatchCollection matches = regex.Matches(txtTestText.Text);

            if (matches.Count == 0)
            {
                txtTestResults.Text = "No matches found.";
                txtTestResults.BackColor = Color.LightPink;
                return;
            }

            // Configure DataGridView
            dgvMatches.Columns.Clear();
            dgvMatches.Columns.Add("Index", "Index");
            dgvMatches.Columns.Add("Value", "Value");
            dgvMatches.Columns.Add("Length", "Length");

            foreach (Match match in matches)
            {
                dgvMatches.Rows.Add(match.Index, match.Value, match.Length);
            }

            txtTestResults.Text = $"Found {matches.Count} matches.";
            txtTestResults.BackColor = Color.LightGreen;
        }

        private RegexOptions GetSelectedOptions()
        {
            RegexOptions options = RegexOptions.None;
            if (chkIgnoreCase.Checked) options |= RegexOptions.IgnoreCase;
            if (chkMultiline.Checked) options |= RegexOptions.Multiline;
            if (chkSingleline.Checked) options |= RegexOptions.Singleline;
            if (chkExplicitCapture.Checked) options |= RegexOptions.ExplicitCapture;
            return options;
        }

        private void CopyToClipboard()
        {
            if (!string.IsNullOrEmpty(txtGeneratedRegex.Text))
            {
                Clipboard.SetText(txtGeneratedRegex.Text);
                UpdateStatus("Regex copied to clipboard");
            }
        }

        private void ClearAll()
        {
            txtSampleText.Clear();
            txtGeneratedRegex.Clear();
            txtTestText.Clear();
            txtTestResults.Clear();
            dgvMatches.Rows.Clear();
            UpdateStatus("Cleared all fields");
        }

        private void UpdateStatus(string message)
        {
            lblStatus.Text = message;
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Text Files|*.txt|All Files|*.*";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    txtSampleText.Text = System.IO.File.ReadAllText(ofd.FileName);
                    UpdateStatus($"Loaded: {ofd.FileName}");
                }
            }
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Regex Files|*.regex|Text Files|*.txt|All Files|*.*";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    System.IO.File.WriteAllText(sfd.FileName, txtGeneratedRegex.Text);
                    UpdateStatus($"Saved: {sfd.FileName}");
                }
            }
        }

        private void ShowAboutDialog(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Advanced Regex Generator\nVersion 1.0\n\nA tool for generating and testing regular expressions.",
                "About",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
        private void menuStripMain_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cmbRegexFlavor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}