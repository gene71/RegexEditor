namespace RegexEditor
{
    partial class RegexEditorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scannerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.scannerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nameAndDescriptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileAssociationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPatternToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addPatternsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removePatternToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scannerDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lineNumbersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearTextFeildToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quickScanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cSProjectReferenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infotextBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.saveTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.scanToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(501, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.saveTextToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scannerToolStripMenuItem1});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // scannerToolStripMenuItem1
            // 
            this.scannerToolStripMenuItem1.Name = "scannerToolStripMenuItem1";
            this.scannerToolStripMenuItem1.Size = new System.Drawing.Size(116, 22);
            this.scannerToolStripMenuItem1.Text = "Scanner";
            this.scannerToolStripMenuItem1.Click += new System.EventHandler(this.scannerToolStripMenuItem1_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1,
            this.scannerToolStripMenuItem});
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(116, 22);
            this.fileToolStripMenuItem1.Text = "File";
            this.fileToolStripMenuItem1.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // scannerToolStripMenuItem
            // 
            this.scannerToolStripMenuItem.Name = "scannerToolStripMenuItem";
            this.scannerToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.scannerToolStripMenuItem.Text = "Scanner";
            this.scannerToolStripMenuItem.Click += new System.EventHandler(this.scannerToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nameAndDescriptionToolStripMenuItem,
            this.fileAssociationToolStripMenuItem,
            this.addPatternToolStripMenuItem1,
            this.addPatternsToolStripMenuItem,
            this.removePatternToolStripMenuItem1});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // nameAndDescriptionToolStripMenuItem
            // 
            this.nameAndDescriptionToolStripMenuItem.Name = "nameAndDescriptionToolStripMenuItem";
            this.nameAndDescriptionToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.nameAndDescriptionToolStripMenuItem.Text = "Name and Description";
            this.nameAndDescriptionToolStripMenuItem.Click += new System.EventHandler(this.nameAndDescriptionToolStripMenuItem_Click);
            // 
            // fileAssociationToolStripMenuItem
            // 
            this.fileAssociationToolStripMenuItem.Name = "fileAssociationToolStripMenuItem";
            this.fileAssociationToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.fileAssociationToolStripMenuItem.Text = "File Association";
            this.fileAssociationToolStripMenuItem.Click += new System.EventHandler(this.addFileExtensionToolStripMenuItem_Click);
            // 
            // addPatternToolStripMenuItem1
            // 
            this.addPatternToolStripMenuItem1.Name = "addPatternToolStripMenuItem1";
            this.addPatternToolStripMenuItem1.Size = new System.Drawing.Size(192, 22);
            this.addPatternToolStripMenuItem1.Text = "Add Pattern";
            this.addPatternToolStripMenuItem1.Click += new System.EventHandler(this.addPatternToolStripMenuItem_Click);
            // 
            // addPatternsToolStripMenuItem
            // 
            this.addPatternsToolStripMenuItem.Name = "addPatternsToolStripMenuItem";
            this.addPatternsToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.addPatternsToolStripMenuItem.Text = "Add Pattern(s)";
            this.addPatternsToolStripMenuItem.Click += new System.EventHandler(this.addPatternsToolStripMenuItem_Click);
            // 
            // removePatternToolStripMenuItem1
            // 
            this.removePatternToolStripMenuItem1.Name = "removePatternToolStripMenuItem1";
            this.removePatternToolStripMenuItem1.Size = new System.Drawing.Size(192, 22);
            this.removePatternToolStripMenuItem1.Text = "Remove Pattern";
            this.removePatternToolStripMenuItem1.Click += new System.EventHandler(this.removePatternToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scannerDetailsToolStripMenuItem,
            this.lineNumbersToolStripMenuItem,
            this.clearTextFeildToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // scannerDetailsToolStripMenuItem
            // 
            this.scannerDetailsToolStripMenuItem.Name = "scannerDetailsToolStripMenuItem";
            this.scannerDetailsToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.scannerDetailsToolStripMenuItem.Text = "Scanner Details";
            this.scannerDetailsToolStripMenuItem.Click += new System.EventHandler(this.scannerDetailsToolStripMenuItem_Click);
            // 
            // lineNumbersToolStripMenuItem
            // 
            this.lineNumbersToolStripMenuItem.Name = "lineNumbersToolStripMenuItem";
            this.lineNumbersToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.lineNumbersToolStripMenuItem.Text = "Line Numbers";
            this.lineNumbersToolStripMenuItem.Click += new System.EventHandler(this.lineNumbersToolStripMenuItem_Click);
            // 
            // clearTextFeildToolStripMenuItem
            // 
            this.clearTextFeildToolStripMenuItem.Name = "clearTextFeildToolStripMenuItem";
            this.clearTextFeildToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.clearTextFeildToolStripMenuItem.Text = "Clear Text Feild";
            this.clearTextFeildToolStripMenuItem.Click += new System.EventHandler(this.clearTextFeildToolStripMenuItem_Click);
            // 
            // scanToolStripMenuItem
            // 
            this.scanToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quickScanToolStripMenuItem,
            this.cSProjectReferenceToolStripMenuItem});
            this.scanToolStripMenuItem.Name = "scanToolStripMenuItem";
            this.scanToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.scanToolStripMenuItem.Text = "Scanner";
            // 
            // quickScanToolStripMenuItem
            // 
            this.quickScanToolStripMenuItem.Name = "quickScanToolStripMenuItem";
            this.quickScanToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.quickScanToolStripMenuItem.Text = "Quick Scan";
            this.quickScanToolStripMenuItem.Click += new System.EventHandler(this.quickScanToolStripMenuItem_Click);
            // 
            // cSProjectReferenceToolStripMenuItem
            // 
            this.cSProjectReferenceToolStripMenuItem.Name = "cSProjectReferenceToolStripMenuItem";
            this.cSProjectReferenceToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.cSProjectReferenceToolStripMenuItem.Text = "CS Project Reference";
            this.cSProjectReferenceToolStripMenuItem.Click += new System.EventHandler(this.cSProjectRefScanToolStripMenuItem_Click);
            // 
            // infotextBox
            // 
            this.infotextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.infotextBox.Enabled = false;
            this.infotextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infotextBox.Location = new System.Drawing.Point(0, 425);
            this.infotextBox.Name = "infotextBox";
            this.infotextBox.Size = new System.Drawing.Size(501, 29);
            this.infotextBox.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(0, 24);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(501, 32);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.TextChanged += new System.EventHandler(this.comboBox1_TextChanged);
            this.comboBox1.Click += new System.EventHandler(this.comboBox1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 56);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(501, 369);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "";
            this.richTextBox1.WordWrap = false;
            this.richTextBox1.Click += new System.EventHandler(this.richTextBox1_Click);
            this.richTextBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.richTextBox1_KeyUp);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "xml";
            this.saveFileDialog1.Filter = "files|*.xml";
            // 
            // saveTextToolStripMenuItem
            // 
            this.saveTextToolStripMenuItem.Name = "saveTextToolStripMenuItem";
            this.saveTextToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveTextToolStripMenuItem.Text = "Save Text";
            this.saveTextToolStripMenuItem.Click += new System.EventHandler(this.saveTextToolStripMenuItem_Click);
            // 
            // RegexEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 454);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.infotextBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "RegexEditorForm";
            this.Text = "Regex Scanner";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lineNumbersToolStripMenuItem;
        private System.Windows.Forms.TextBox infotextBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStripMenuItem scanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quickScanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileAssociationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPatternToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem removePatternToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cSProjectReferenceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scannerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scannerToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem nameAndDescriptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scannerDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearTextFeildToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPatternsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveTextToolStripMenuItem;
    }
}

