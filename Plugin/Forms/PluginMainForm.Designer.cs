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
            this.openDATFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.openRomForMD5Dialog = new System.Windows.Forms.OpenFileDialog();
            this.processSelectedPlatformsButton = new System.Windows.Forms.Button();
            this.importPlatformComboBox = new System.Windows.Forms.ComboBox();
            this.importDatGroupBox = new System.Windows.Forms.GroupBox();
            this.importDatButton = new System.Windows.Forms.Button();
            this.processGamesGroupBox = new System.Windows.Forms.GroupBox();
            this.platformToProcessSelectBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.importDatGroupBox.SuspendLayout();
            this.processGamesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // openRomForMD5Dialog
            // 
            this.openRomForMD5Dialog.FileName = "openFileDialog1";
            // 
            // processSelectedPlatformsButton
            // 
            this.processSelectedPlatformsButton.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.processSelectedPlatformsButton.Location = new System.Drawing.Point(6, 75);
            this.processSelectedPlatformsButton.Name = "processSelectedPlatformsButton";
            this.processSelectedPlatformsButton.Size = new System.Drawing.Size(478, 23);
            this.processSelectedPlatformsButton.TabIndex = 7;
            this.processSelectedPlatformsButton.Text = "Process selected platform";
            this.processSelectedPlatformsButton.UseVisualStyleBackColor = true;
            this.processSelectedPlatformsButton.Click += new System.EventHandler(this.processSelectedPlatformsButton_Click);
            // 
            // importPlatformComboBox
            // 
            this.importPlatformComboBox.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.importPlatformComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.importPlatformComboBox.FormattingEnabled = true;
            this.importPlatformComboBox.Location = new System.Drawing.Point(6, 19);
            this.importPlatformComboBox.Name = "importPlatformComboBox";
            this.importPlatformComboBox.Size = new System.Drawing.Size(478, 21);
            this.importPlatformComboBox.TabIndex = 10;
            // 
            // importDatGroupBox
            // 
            this.importDatGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.importDatGroupBox.Controls.Add(this.importDatButton);
            this.importDatGroupBox.Controls.Add(this.importPlatformComboBox);
            this.importDatGroupBox.Location = new System.Drawing.Point(12, 12);
            this.importDatGroupBox.Name = "importDatGroupBox";
            this.importDatGroupBox.Size = new System.Drawing.Size(490, 81);
            this.importDatGroupBox.TabIndex = 11;
            this.importDatGroupBox.TabStop = false;
            this.importDatGroupBox.Text = "Import DAT file";
            // 
            // importDatButton
            // 
            this.importDatButton.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.importDatButton.Location = new System.Drawing.Point(6, 46);
            this.importDatButton.Name = "importDatButton";
            this.importDatButton.Size = new System.Drawing.Size(478, 23);
            this.importDatButton.TabIndex = 11;
            this.importDatButton.Text = "Import DAT for selected platform";
            this.importDatButton.UseVisualStyleBackColor = true;
            this.importDatButton.Click += new System.EventHandler(this.importDatButton_Click);
            // 
            // processGamesGroupBox
            // 
            this.processGamesGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.processGamesGroupBox.Controls.Add(this.platformToProcessSelectBox);
            this.processGamesGroupBox.Controls.Add(this.label1);
            this.processGamesGroupBox.Controls.Add(this.processSelectedPlatformsButton);
            this.processGamesGroupBox.Location = new System.Drawing.Point(12, 99);
            this.processGamesGroupBox.Name = "processGamesGroupBox";
            this.processGamesGroupBox.Size = new System.Drawing.Size(490, 109);
            this.processGamesGroupBox.TabIndex = 12;
            this.processGamesGroupBox.TabStop = false;
            this.processGamesGroupBox.Text = "Process P/C";
            // 
            // platformToProcessSelectBox
            // 
            this.platformToProcessSelectBox.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.platformToProcessSelectBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.platformToProcessSelectBox.FormattingEnabled = true;
            this.platformToProcessSelectBox.Location = new System.Drawing.Point(6, 48);
            this.platformToProcessSelectBox.Name = "platformToProcessSelectBox";
            this.platformToProcessSelectBox.Size = new System.Drawing.Size(478, 21);
            this.platformToProcessSelectBox.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(478, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Select the platforms to process:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // PluginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 410);
            this.Controls.Add(this.processGamesGroupBox);
            this.Controls.Add(this.importDatGroupBox);
            this.Name = "PluginForm";
            this.Text = "No-Intro P/C";
            this.importDatGroupBox.ResumeLayout(false);
            this.processGamesGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.ComboBox platformToProcessSelectBox;

        private System.Windows.Forms.ComboBox importPlatformComboBox;

        private System.Windows.Forms.Button importDatButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox processGamesGroupBox;
        private System.Windows.Forms.Button processSelectedPlatformsButton;

        private System.Windows.Forms.GroupBox importDatGroupBox;

        #endregion

        private System.Windows.Forms.OpenFileDialog openDATFileDialog;
        private System.Windows.Forms.OpenFileDialog openRomForMD5Dialog;
    }
}