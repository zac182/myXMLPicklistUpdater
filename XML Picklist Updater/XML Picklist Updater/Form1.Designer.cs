namespace XML_Picklist_Updater
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.loadGitXMLButton = new System.Windows.Forms.Button();
            this.createNewXMLButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gitXMLPathTextBox = new System.Windows.Forms.TextBox();
            this.orgXMLPathTextBox = new System.Windows.Forms.TextBox();
            this.loadOrgXMLButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.analyzeFilesButton = new System.Windows.Forms.Button();
            this.srcAsDestCheckBox = new System.Windows.Forms.CheckBox();
            this.selectLabel = new System.Windows.Forms.Label();
            this.selectAllButton = new System.Windows.Forms.Button();
            this.unselectAllButton = new System.Windows.Forms.Button();
            this.CBLCoverImg = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CBLCoverImg)).BeginInit();
            this.SuspendLayout();
            // 
            // loadGitXMLButton
            // 
            this.loadGitXMLButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.loadGitXMLButton.Image = ((System.Drawing.Image)(resources.GetObject("loadGitXMLButton.Image")));
            this.loadGitXMLButton.Location = new System.Drawing.Point(472, 15);
            this.loadGitXMLButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.loadGitXMLButton.Name = "loadGitXMLButton";
            this.loadGitXMLButton.Size = new System.Drawing.Size(134, 42);
            this.loadGitXMLButton.TabIndex = 2;
            this.loadGitXMLButton.Text = "Load Git XML";
            this.loadGitXMLButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.loadGitXMLButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.loadGitXMLButton.UseVisualStyleBackColor = true;
            this.loadGitXMLButton.Click += new System.EventHandler(this.loadGitXMLButton_Click);
            // 
            // createNewXMLButton
            // 
            this.createNewXMLButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.createNewXMLButton.Enabled = false;
            this.createNewXMLButton.Image = ((System.Drawing.Image)(resources.GetObject("createNewXMLButton.Image")));
            this.createNewXMLButton.Location = new System.Drawing.Point(486, 551);
            this.createNewXMLButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.createNewXMLButton.Name = "createNewXMLButton";
            this.createNewXMLButton.Size = new System.Drawing.Size(134, 42);
            this.createNewXMLButton.TabIndex = 3;
            this.createNewXMLButton.Text = "Create New XML";
            this.createNewXMLButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.createNewXMLButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.createNewXMLButton.UseVisualStyleBackColor = true;
            this.createNewXMLButton.Click += new System.EventHandler(this.createNewXMLButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Objects (*.object)|*.object";
            this.openFileDialog1.Title = "Select Git file";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkedListBox1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(14, 37);
            this.checkedListBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(612, 310);
            this.checkedListBox1.TabIndex = 5;
            this.checkedListBox1.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox1_ItemCheck);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.Filter = "Objects (*.object)|*.object";
            this.openFileDialog2.Title = "Select environment file";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(640, 25);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 19);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.gitXMLPathTextBox);
            this.groupBox1.Controls.Add(this.loadGitXMLButton);
            this.groupBox1.Location = new System.Drawing.Point(14, 404);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(612, 65);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Git Path";
            // 
            // gitXMLPathTextBox
            // 
            this.gitXMLPathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gitXMLPathTextBox.Location = new System.Drawing.Point(7, 26);
            this.gitXMLPathTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gitXMLPathTextBox.Name = "gitXMLPathTextBox";
            this.gitXMLPathTextBox.ReadOnly = true;
            this.gitXMLPathTextBox.Size = new System.Drawing.Size(459, 21);
            this.gitXMLPathTextBox.TabIndex = 3;
            this.gitXMLPathTextBox.TextChanged += new System.EventHandler(this.enableSeachButton);
            // 
            // orgXMLPathTextBox
            // 
            this.orgXMLPathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.orgXMLPathTextBox.Location = new System.Drawing.Point(7, 26);
            this.orgXMLPathTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.orgXMLPathTextBox.Name = "orgXMLPathTextBox";
            this.orgXMLPathTextBox.ReadOnly = true;
            this.orgXMLPathTextBox.Size = new System.Drawing.Size(459, 21);
            this.orgXMLPathTextBox.TabIndex = 3;
            this.orgXMLPathTextBox.TextChanged += new System.EventHandler(this.enableSeachButton);
            // 
            // loadOrgXMLButton
            // 
            this.loadOrgXMLButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.loadOrgXMLButton.Image = ((System.Drawing.Image)(resources.GetObject("loadOrgXMLButton.Image")));
            this.loadOrgXMLButton.Location = new System.Drawing.Point(472, 15);
            this.loadOrgXMLButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.loadOrgXMLButton.Name = "loadOrgXMLButton";
            this.loadOrgXMLButton.Size = new System.Drawing.Size(134, 42);
            this.loadOrgXMLButton.TabIndex = 2;
            this.loadOrgXMLButton.Text = "Load Org XML";
            this.loadOrgXMLButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.loadOrgXMLButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.loadOrgXMLButton.UseVisualStyleBackColor = true;
            this.loadOrgXMLButton.Click += new System.EventHandler(this.loadOrgXMLButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.orgXMLPathTextBox);
            this.groupBox2.Controls.Add(this.loadOrgXMLButton);
            this.groupBox2.Location = new System.Drawing.Point(14, 478);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(612, 65);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Org Path";
            // 
            // analyzeFilesButton
            // 
            this.analyzeFilesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.analyzeFilesButton.Enabled = false;
            this.analyzeFilesButton.Image = ((System.Drawing.Image)(resources.GetObject("analyzeFilesButton.Image")));
            this.analyzeFilesButton.Location = new System.Drawing.Point(21, 551);
            this.analyzeFilesButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.analyzeFilesButton.Name = "analyzeFilesButton";
            this.analyzeFilesButton.Size = new System.Drawing.Size(134, 42);
            this.analyzeFilesButton.TabIndex = 9;
            this.analyzeFilesButton.Text = "Analyze Files";
            this.analyzeFilesButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.analyzeFilesButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.analyzeFilesButton.UseVisualStyleBackColor = true;
            this.analyzeFilesButton.Click += new System.EventHandler(this.analyzeFilesButton_Click);
            // 
            // srcAsDestCheckBox
            // 
            this.srcAsDestCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.srcAsDestCheckBox.AutoSize = true;
            this.srcAsDestCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.srcAsDestCheckBox.Location = new System.Drawing.Point(300, 562);
            this.srcAsDestCheckBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.srcAsDestCheckBox.Name = "srcAsDestCheckBox";
            this.srcAsDestCheckBox.Size = new System.Drawing.Size(180, 22);
            this.srcAsDestCheckBox.TabIndex = 10;
            this.srcAsDestCheckBox.Text = "Use Git Path as Destination?";
            this.srcAsDestCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.srcAsDestCheckBox.UseVisualStyleBackColor = true;
            // 
            // selectLabel
            // 
            this.selectLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.selectLabel.AutoSize = true;
            this.selectLabel.Location = new System.Drawing.Point(261, 367);
            this.selectLabel.Name = "selectLabel";
            this.selectLabel.Size = new System.Drawing.Size(0, 18);
            this.selectLabel.TabIndex = 11;
            // 
            // selectAllButton
            // 
            this.selectAllButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.selectAllButton.Enabled = false;
            this.selectAllButton.Image = ((System.Drawing.Image)(resources.GetObject("selectAllButton.Image")));
            this.selectAllButton.Location = new System.Drawing.Point(21, 355);
            this.selectAllButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.selectAllButton.Name = "selectAllButton";
            this.selectAllButton.Size = new System.Drawing.Size(134, 42);
            this.selectAllButton.TabIndex = 12;
            this.selectAllButton.Text = "Select All";
            this.selectAllButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.selectAllButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.selectAllButton.UseVisualStyleBackColor = true;
            this.selectAllButton.Click += new System.EventHandler(this.selectAllButton_Click);
            // 
            // unselectAllButton
            // 
            this.unselectAllButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.unselectAllButton.Enabled = false;
            this.unselectAllButton.Image = ((System.Drawing.Image)(resources.GetObject("unselectAllButton.Image")));
            this.unselectAllButton.Location = new System.Drawing.Point(486, 355);
            this.unselectAllButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.unselectAllButton.Name = "unselectAllButton";
            this.unselectAllButton.Size = new System.Drawing.Size(134, 42);
            this.unselectAllButton.TabIndex = 13;
            this.unselectAllButton.Text = "Unselect All";
            this.unselectAllButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.unselectAllButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.unselectAllButton.UseVisualStyleBackColor = true;
            this.unselectAllButton.Click += new System.EventHandler(this.unselectAllButton_Click);
            // 
            // CBLCoverImg
            // 
            this.CBLCoverImg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CBLCoverImg.Image = ((System.Drawing.Image)(resources.GetObject("CBLCoverImg.Image")));
            this.CBLCoverImg.InitialImage = ((System.Drawing.Image)(resources.GetObject("CBLCoverImg.InitialImage")));
            this.CBLCoverImg.Location = new System.Drawing.Point(14, 37);
            this.CBLCoverImg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CBLCoverImg.Name = "CBLCoverImg";
            this.CBLCoverImg.Size = new System.Drawing.Size(612, 310);
            this.CBLCoverImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.CBLCoverImg.TabIndex = 14;
            this.CBLCoverImg.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 600);
            this.Controls.Add(this.CBLCoverImg);
            this.Controls.Add(this.unselectAllButton);
            this.Controls.Add(this.selectAllButton);
            this.Controls.Add(this.selectLabel);
            this.Controls.Add(this.srcAsDestCheckBox);
            this.Controls.Add(this.analyzeFilesButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.createNewXMLButton);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(656, 639);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XML Picklist Updater";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CBLCoverImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button loadGitXMLButton;
        private System.Windows.Forms.Button createNewXMLButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox gitXMLPathTextBox;
        private System.Windows.Forms.TextBox orgXMLPathTextBox;
        private System.Windows.Forms.Button loadOrgXMLButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button analyzeFilesButton;
        private System.Windows.Forms.CheckBox srcAsDestCheckBox;
        private System.Windows.Forms.Label selectLabel;
        private System.Windows.Forms.Button selectAllButton;
        private System.Windows.Forms.Button unselectAllButton;
        private System.Windows.Forms.PictureBox CBLCoverImg;
    }
}

