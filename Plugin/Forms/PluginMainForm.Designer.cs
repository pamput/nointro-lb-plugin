namespace Pamput.NoIntroLBPlugin
{
    partial class PluginForm
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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.loadDATs = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.noIntroMapListBox = new System.Windows.Forms.ListBox();
            this.openDATFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.md5CheckButton = new System.Windows.Forms.Button();
            this.openRomForMD5Dialog = new System.Windows.Forms.OpenFileDialog();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.processSnes = new System.Windows.Forms.Button();
            this.ProgressTest = new System.Windows.Forms.Button();
            this.datsFolderButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize) (this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(12, 606);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(863, 23);
            this.progressBar1.TabIndex = 0;
            // 
            // loadDATs
            // 
            this.loadDATs.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.loadDATs.Location = new System.Drawing.Point(800, 12);
            this.loadDATs.Name = "loadDATs";
            this.loadDATs.Size = new System.Drawing.Size(75, 23);
            this.loadDATs.TabIndex = 1;
            this.loadDATs.Text = "Load DATs";
            this.loadDATs.UseVisualStyleBackColor = true;
            this.loadDATs.Click += new System.EventHandler(this.loadDATs_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(3, 3);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(259, 574);
            this.checkedListBox1.TabIndex = 3;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // noIntroMapListBox
            // 
            this.noIntroMapListBox.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.noIntroMapListBox.FormattingEnabled = true;
            this.noIntroMapListBox.Location = new System.Drawing.Point(3, 0);
            this.noIntroMapListBox.Name = "noIntroMapListBox";
            this.noIntroMapListBox.Size = new System.Drawing.Size(507, 576);
            this.noIntroMapListBox.TabIndex = 4;
            // 
            // openDATFileDialog
            // 
            this.openDATFileDialog.FileName = "games.dat";
            // 
            // md5CheckButton
            // 
            this.md5CheckButton.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.md5CheckButton.Location = new System.Drawing.Point(800, 41);
            this.md5CheckButton.Name = "md5CheckButton";
            this.md5CheckButton.Size = new System.Drawing.Size(75, 23);
            this.md5CheckButton.TabIndex = 5;
            this.md5CheckButton.Text = "Check MD5";
            this.md5CheckButton.UseVisualStyleBackColor = true;
            this.md5CheckButton.Click += new System.EventHandler(this.md5CheckButton_Click);
            // 
            // openRomForMD5Dialog
            // 
            this.openRomForMD5Dialog.FileName = "openFileDialog1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(12, 12);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.checkedListBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.noIntroMapListBox);
            this.splitContainer1.Size = new System.Drawing.Size(782, 588);
            this.splitContainer1.SplitterDistance = 265;
            this.splitContainer1.TabIndex = 6;
            // 
            // processSnes
            // 
            this.processSnes.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.processSnes.Location = new System.Drawing.Point(800, 70);
            this.processSnes.Name = "processSnes";
            this.processSnes.Size = new System.Drawing.Size(75, 23);
            this.processSnes.TabIndex = 7;
            this.processSnes.Text = "Process";
            this.processSnes.UseVisualStyleBackColor = true;
            this.processSnes.Click += new System.EventHandler(this.processSnes_Click);
            // 
            // ProgressTest
            // 
            this.ProgressTest.Location = new System.Drawing.Point(800, 99);
            this.ProgressTest.Name = "ProgressTest";
            this.ProgressTest.Size = new System.Drawing.Size(75, 23);
            this.ProgressTest.TabIndex = 8;
            this.ProgressTest.Text = "Progress";
            this.ProgressTest.UseVisualStyleBackColor = true;
            this.ProgressTest.Click += new System.EventHandler(this.ProgressTest_Click);
            // 
            // datsFolderButton
            // 
            this.datsFolderButton.Location = new System.Drawing.Point(800, 128);
            this.datsFolderButton.Name = "datsFolderButton";
            this.datsFolderButton.Size = new System.Drawing.Size(75, 23);
            this.datsFolderButton.TabIndex = 9;
            this.datsFolderButton.Text = "DATs Folder";
            this.datsFolderButton.UseVisualStyleBackColor = true;
            this.datsFolderButton.Click += new System.EventHandler(this.datsFolderButton_Click);
            // 
            // PluginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 641);
            this.Controls.Add(this.datsFolderButton);
            this.Controls.Add(this.ProgressTest);
            this.Controls.Add(this.processSnes);
            this.Controls.Add(this.md5CheckButton);
            this.Controls.Add(this.loadDATs);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.splitContainer1);
            this.Name = "PluginForm";
            this.Text = "No-Intro P/C";
            this.Load += new System.EventHandler(this.NoIntroLBUI_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button datsFolderButton;

        private System.Windows.Forms.Button ProgressTest;

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button loadDATs;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.ListBox noIntroMapListBox;
        private System.Windows.Forms.OpenFileDialog openDATFileDialog;
        private System.Windows.Forms.Button md5CheckButton;
        private System.Windows.Forms.OpenFileDialog openRomForMD5Dialog;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button processSnes;
    }
}