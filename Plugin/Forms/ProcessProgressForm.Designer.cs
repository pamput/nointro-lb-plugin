using System.ComponentModel;

namespace Pamput.NoIntroLBPlugin
{
    partial class ProcessProgressForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.partProgress = new System.Windows.Forms.ProgressBar();
            this.gamesProgress = new System.Windows.Forms.ProgressBar();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.currentGameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // partProgress
            // 
            this.partProgress.Location = new System.Drawing.Point(12, 33);
            this.partProgress.Maximum = 2;
            this.partProgress.Name = "partProgress";
            this.partProgress.Size = new System.Drawing.Size(472, 23);
            this.partProgress.TabIndex = 0;
            // 
            // gamesProgress
            // 
            this.gamesProgress.Location = new System.Drawing.Point(12, 76);
            this.gamesProgress.Name = "gamesProgress";
            this.gamesProgress.Size = new System.Drawing.Size(472, 23);
            this.gamesProgress.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(81, 117);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(403, 13);
            this.textBox1.TabIndex = 2;
            // 
            // currentGameLabel
            // 
            this.currentGameLabel.Location = new System.Drawing.Point(12, 117);
            this.currentGameLabel.Name = "currentGameLabel";
            this.currentGameLabel.Size = new System.Drawing.Size(81, 23);
            this.currentGameLabel.TabIndex = 3;
            this.currentGameLabel.Text = "Processing: ";
            // 
            // ProcessProgressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 215);
            this.ControlBox = false;
            this.Controls.Add(this.currentGameLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.gamesProgress);
            this.Controls.Add(this.partProgress);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProcessProgressForm";
            this.Text = "ProcessProgressForm";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label currentGameLabel;

        private System.Windows.Forms.TextBox textBox1;

        private System.Windows.Forms.ProgressBar gamesProgress;
        private System.Windows.Forms.ProgressBar partProgress;

        #endregion
    }
}