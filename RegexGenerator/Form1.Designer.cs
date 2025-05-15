namespace RegexGenerator
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStripMain = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            copyToolStripMenuItem = new ToolStripMenuItem();
            pasteToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            tcMain = new TabControl();
            tpGenerator = new TabPage();
            gbOptions = new GroupBox();
            cmbRegexFlavor = new ComboBox();
            chkExplicitCapture = new CheckBox();
            chkSingleline = new CheckBox();
            chkMultiline = new CheckBox();
            chkIgnoreCase = new CheckBox();
            gbGeneratedRegex = new GroupBox();
            flpRegexButtons = new FlowLayoutPanel();
            btnCopyRegex = new Button();
            btnSaveRegex = new Button();
            btnTestRegex = new Button();
            txtGeneratedRegex = new TextBox();
            gbSampleText = new GroupBox();
            btnAnalyze = new Button();
            txtSampleText = new TextBox();
            tpTester = new TabPage();
            scTester = new SplitContainer();
            txtTestText = new TextBox();
            txtTestResults = new TextBox();
            dgvMatches = new DataGridView();
            tpReference = new TabPage();
            wbReference = new RichTextBox();
            statusStripMain = new StatusStrip();
            lblStatus = new ToolStripStatusLabel();
            menuStripMain.SuspendLayout();
            tcMain.SuspendLayout();
            tpGenerator.SuspendLayout();
            gbOptions.SuspendLayout();
            gbGeneratedRegex.SuspendLayout();
            flpRegexButtons.SuspendLayout();
            gbSampleText.SuspendLayout();
            tpTester.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)scTester).BeginInit();
            scTester.Panel1.SuspendLayout();
            scTester.Panel2.SuspendLayout();
            scTester.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMatches).BeginInit();
            tpReference.SuspendLayout();
            statusStripMain.SuspendLayout();
            SuspendLayout();
            // 
            // menuStripMain
            // 
            menuStripMain.ImageScalingSize = new Size(20, 20);
            menuStripMain.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, helpToolStripMenuItem });
            menuStripMain.Location = new Point(0, 0);
            menuStripMain.Name = "menuStripMain";
            menuStripMain.Size = new Size(882, 28);
            menuStripMain.TabIndex = 0;
            menuStripMain.Text = "menuStrip1";
            menuStripMain.ItemClicked += menuStripMain_ItemClicked;
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, openToolStripMenuItem, saveToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(44, 24);
            fileToolStripMenuItem.Text = "file";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(132, 26);
            newToolStripMenuItem.Text = "new";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(132, 26);
            openToolStripMenuItem.Text = "Open ";
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(132, 26);
            saveToolStripMenuItem.Text = "Save";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(132, 26);
            exitToolStripMenuItem.Text = "Exit ";
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { copyToolStripMenuItem, pasteToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(49, 24);
            editToolStripMenuItem.Text = "Edit";
            // 
            // copyToolStripMenuItem
            // 
            copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            copyToolStripMenuItem.Size = new Size(130, 26);
            copyToolStripMenuItem.Text = "Copy ";
            // 
            // pasteToolStripMenuItem
            // 
            pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            pasteToolStripMenuItem.Size = new Size(130, 26);
            pasteToolStripMenuItem.Text = "Paste ";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(59, 24);
            helpToolStripMenuItem.Text = "Help ";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(137, 26);
            aboutToolStripMenuItem.Text = "About ";
            // 
            // tcMain
            // 
            tcMain.Controls.Add(tpGenerator);
            tcMain.Controls.Add(tpTester);
            tcMain.Controls.Add(tpReference);
            tcMain.Location = new Point(0, 31);
            tcMain.Name = "tcMain";
            tcMain.SelectedIndex = 0;
            tcMain.Size = new Size(779, 393);
            tcMain.TabIndex = 1;
            // 
            // tpGenerator
            // 
            tpGenerator.Controls.Add(gbOptions);
            tpGenerator.Controls.Add(gbGeneratedRegex);
            tpGenerator.Controls.Add(gbSampleText);
            tpGenerator.Location = new Point(4, 29);
            tpGenerator.Name = "tpGenerator";
            tpGenerator.Size = new Size(771, 360);
            tpGenerator.TabIndex = 0;
            tpGenerator.Text = "Generator ";
            tpGenerator.UseVisualStyleBackColor = true;
            // 
            // gbOptions
            // 
            gbOptions.Controls.Add(cmbRegexFlavor);
            gbOptions.Controls.Add(chkExplicitCapture);
            gbOptions.Controls.Add(chkSingleline);
            gbOptions.Controls.Add(chkMultiline);
            gbOptions.Controls.Add(chkIgnoreCase);
            gbOptions.Location = new Point(577, 181);
            gbOptions.Name = "gbOptions";
            gbOptions.Size = new Size(191, 176);
            gbOptions.TabIndex = 2;
            gbOptions.TabStop = false;
            gbOptions.Text = "Options";
            // 
            // cmbRegexFlavor
            // 
            cmbRegexFlavor.FormattingEnabled = true;
            cmbRegexFlavor.Location = new Point(17, 151);
            cmbRegexFlavor.Name = "cmbRegexFlavor";
            cmbRegexFlavor.Size = new Size(151, 28);
            cmbRegexFlavor.TabIndex = 4;
            cmbRegexFlavor.SelectedIndexChanged += cmbRegexFlavor_SelectedIndexChanged;
            // 
            // chkExplicitCapture
            // 
            chkExplicitCapture.AutoSize = true;
            chkExplicitCapture.Location = new Point(17, 121);
            chkExplicitCapture.Name = "chkExplicitCapture";
            chkExplicitCapture.Size = new Size(135, 24);
            chkExplicitCapture.TabIndex = 3;
            chkExplicitCapture.Text = "Explicit Capture";
            chkExplicitCapture.UseVisualStyleBackColor = true;
            // 
            // chkSingleline
            // 
            chkSingleline.AutoSize = true;
            chkSingleline.Location = new Point(17, 91);
            chkSingleline.Name = "chkSingleline";
            chkSingleline.Size = new Size(96, 24);
            chkSingleline.TabIndex = 2;
            chkSingleline.Text = "Singleline";
            chkSingleline.UseVisualStyleBackColor = true;
            chkSingleline.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // chkMultiline
            // 
            chkMultiline.AutoSize = true;
            chkMultiline.Location = new Point(17, 61);
            chkMultiline.Name = "chkMultiline";
            chkMultiline.Size = new Size(89, 24);
            chkMultiline.TabIndex = 1;
            chkMultiline.Text = "Multiline";
            chkMultiline.UseVisualStyleBackColor = true;
            // 
            // chkIgnoreCase
            // 
            chkIgnoreCase.AutoSize = true;
            chkIgnoreCase.Location = new Point(17, 31);
            chkIgnoreCase.Name = "chkIgnoreCase";
            chkIgnoreCase.Size = new Size(109, 24);
            chkIgnoreCase.TabIndex = 0;
            chkIgnoreCase.Text = "Ignore Case";
            chkIgnoreCase.UseVisualStyleBackColor = true;
            // 
            // gbGeneratedRegex
            // 
            gbGeneratedRegex.Controls.Add(flpRegexButtons);
            gbGeneratedRegex.Controls.Add(txtGeneratedRegex);
            gbGeneratedRegex.Location = new Point(318, 20);
            gbGeneratedRegex.Name = "gbGeneratedRegex";
            gbGeneratedRegex.Size = new Size(253, 249);
            gbGeneratedRegex.TabIndex = 1;
            gbGeneratedRegex.TabStop = false;
            gbGeneratedRegex.Text = "Generated Regex";
            // 
            // flpRegexButtons
            // 
            flpRegexButtons.Controls.Add(btnCopyRegex);
            flpRegexButtons.Controls.Add(btnSaveRegex);
            flpRegexButtons.Controls.Add(btnTestRegex);
            flpRegexButtons.Dock = DockStyle.Bottom;
            flpRegexButtons.Location = new Point(3, 166);
            flpRegexButtons.Name = "flpRegexButtons";
            flpRegexButtons.Size = new Size(247, 80);
            flpRegexButtons.TabIndex = 1;
            // 
            // btnCopyRegex
            // 
            btnCopyRegex.Location = new Point(3, 3);
            btnCopyRegex.Name = "btnCopyRegex";
            btnCopyRegex.Size = new Size(75, 29);
            btnCopyRegex.TabIndex = 2;
            btnCopyRegex.Text = "Copy";
            btnCopyRegex.UseVisualStyleBackColor = true;
            btnCopyRegex.Click += button1_Click;
            // 
            // btnSaveRegex
            // 
            btnSaveRegex.Location = new Point(84, 3);
            btnSaveRegex.Name = "btnSaveRegex";
            btnSaveRegex.Size = new Size(64, 29);
            btnSaveRegex.TabIndex = 3;
            btnSaveRegex.Text = "Save";
            btnSaveRegex.UseVisualStyleBackColor = true;
            // 
            // btnTestRegex
            // 
            btnTestRegex.Location = new Point(154, 3);
            btnTestRegex.Name = "btnTestRegex";
            btnTestRegex.Size = new Size(75, 27);
            btnTestRegex.TabIndex = 4;
            btnTestRegex.Text = "Test";
            btnTestRegex.UseVisualStyleBackColor = true;
            // 
            // txtGeneratedRegex
            // 
            txtGeneratedRegex.Location = new Point(6, 40);
            txtGeneratedRegex.Name = "txtGeneratedRegex";
            txtGeneratedRegex.Size = new Size(215, 27);
            txtGeneratedRegex.TabIndex = 0;
            // 
            // gbSampleText
            // 
            gbSampleText.Controls.Add(btnAnalyze);
            gbSampleText.Controls.Add(txtSampleText);
            gbSampleText.Location = new Point(21, 20);
            gbSampleText.Name = "gbSampleText";
            gbSampleText.Size = new Size(275, 246);
            gbSampleText.TabIndex = 0;
            gbSampleText.TabStop = false;
            gbSampleText.Text = "Sample Text";
            // 
            // btnAnalyze
            // 
            btnAnalyze.Location = new Point(78, 147);
            btnAnalyze.Name = "btnAnalyze";
            btnAnalyze.Size = new Size(94, 29);
            btnAnalyze.TabIndex = 1;
            btnAnalyze.Text = "Analyze";
            btnAnalyze.UseVisualStyleBackColor = true;
            // 
            // txtSampleText
            // 
            txtSampleText.Location = new Point(19, 40);
            txtSampleText.Name = "txtSampleText";
            txtSampleText.Size = new Size(250, 27);
            txtSampleText.TabIndex = 0;
            // 
            // tpTester
            // 
            tpTester.Controls.Add(scTester);
            tpTester.Location = new Point(4, 29);
            tpTester.Name = "tpTester";
            tpTester.Size = new Size(771, 360);
            tpTester.TabIndex = 1;
            tpTester.Text = "Tester ";
            tpTester.UseVisualStyleBackColor = true;
            // 
            // scTester
            // 
            scTester.Dock = DockStyle.Fill;
            scTester.Location = new Point(0, 0);
            scTester.Name = "scTester";
            // 
            // scTester.Panel1
            // 
            scTester.Panel1.Controls.Add(txtTestText);
            // 
            // scTester.Panel2
            // 
            scTester.Panel2.Controls.Add(txtTestResults);
            scTester.Panel2.Controls.Add(dgvMatches);
            scTester.Size = new Size(771, 360);
            scTester.SplitterDistance = 257;
            scTester.TabIndex = 0;
            // 
            // txtTestText
            // 
            txtTestText.Dock = DockStyle.Fill;
            txtTestText.Location = new Point(0, 0);
            txtTestText.Multiline = true;
            txtTestText.Name = "txtTestText";
            txtTestText.Size = new Size(257, 360);
            txtTestText.TabIndex = 0;
            // 
            // txtTestResults
            // 
            txtTestResults.Dock = DockStyle.Bottom;
            txtTestResults.Location = new Point(0, 326);
            txtTestResults.Multiline = true;
            txtTestResults.Name = "txtTestResults";
            txtTestResults.ReadOnly = true;
            txtTestResults.Size = new Size(510, 34);
            txtTestResults.TabIndex = 1;
            // 
            // dgvMatches
            // 
            dgvMatches.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMatches.Dock = DockStyle.Fill;
            dgvMatches.Location = new Point(0, 0);
            dgvMatches.Name = "dgvMatches";
            dgvMatches.RowHeadersWidth = 51;
            dgvMatches.Size = new Size(510, 360);
            dgvMatches.TabIndex = 0;
            // 
            // tpReference
            // 
            tpReference.Controls.Add(wbReference);
            tpReference.Location = new Point(4, 29);
            tpReference.Name = "tpReference";
            tpReference.Size = new Size(771, 360);
            tpReference.TabIndex = 2;
            tpReference.Text = "Reference ";
            tpReference.UseVisualStyleBackColor = true;
            // 
            // wbReference
            // 
            wbReference.Dock = DockStyle.Fill;
            wbReference.Location = new Point(0, 0);
            wbReference.Name = "wbReference";
            wbReference.Size = new Size(771, 360);
            wbReference.TabIndex = 0;
            wbReference.Text = "";
            // 
            // statusStripMain
            // 
            statusStripMain.BackColor = SystemColors.HighlightText;
            statusStripMain.ImageScalingSize = new Size(20, 20);
            statusStripMain.Items.AddRange(new ToolStripItem[] { lblStatus });
            statusStripMain.Location = new Point(0, 527);
            statusStripMain.Name = "statusStripMain";
            statusStripMain.Size = new Size(882, 26);
            statusStripMain.TabIndex = 2;
            statusStripMain.Text = "StatusStrip ";
            // 
            // lblStatus
            // 
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(82, 20);
            lblStatus.Text = "Status labe";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(882, 553);
            Controls.Add(statusStripMain);
            Controls.Add(tcMain);
            Controls.Add(menuStripMain);
            MainMenuStrip = menuStripMain;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Advanced Regex Generator";
            menuStripMain.ResumeLayout(false);
            menuStripMain.PerformLayout();
            tcMain.ResumeLayout(false);
            tpGenerator.ResumeLayout(false);
            gbOptions.ResumeLayout(false);
            gbOptions.PerformLayout();
            gbGeneratedRegex.ResumeLayout(false);
            gbGeneratedRegex.PerformLayout();
            flpRegexButtons.ResumeLayout(false);
            gbSampleText.ResumeLayout(false);
            gbSampleText.PerformLayout();
            tpTester.ResumeLayout(false);
            scTester.Panel1.ResumeLayout(false);
            scTester.Panel1.PerformLayout();
            scTester.Panel2.ResumeLayout(false);
            scTester.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)scTester).EndInit();
            scTester.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMatches).EndInit();
            tpReference.ResumeLayout(false);
            statusStripMain.ResumeLayout(false);
            statusStripMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStripMain;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem pasteToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private TabControl tcMain;
        private TabPage tpGenerator;
        private TabPage tpTester;
        private TabPage tpReference;
        private StatusStrip statusStripMain;
        private ToolStripStatusLabel lblStatus;
        private GroupBox gbSampleText;
        private Button btnAnalyze;
        private TextBox txtSampleText;
        private GroupBox gbGeneratedRegex;
        private FlowLayoutPanel flpRegexButtons;
        private Button btnCopyRegex;
        private Button btnSaveRegex;
        private Button btnTestRegex;
        private TextBox txtGeneratedRegex;
        private GroupBox gbOptions;
        private CheckBox chkExplicitCapture;
        private CheckBox chkSingleline;
        private CheckBox chkMultiline;
        private CheckBox chkIgnoreCase;
        private ComboBox cmbRegexFlavor;
        private SplitContainer scTester;
        private TextBox txtTestText;
        private TextBox txtTestResults;
        private DataGridView dgvMatches;
        private RichTextBox wbReference;
    }
}
