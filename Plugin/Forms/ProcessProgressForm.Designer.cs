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
            this.gamesProgress = new System.Windows.Forms.ProgressBar();
            this.currentGameLabel = new System.Windows.Forms.Label();
            this.stepText = new System.Windows.Forms.Label();
            this.totalProcessed = new System.Windows.Forms.Label();
            this.currentGame = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gamesProgress
            // 
            this.gamesProgress.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.gamesProgress.Location = new System.Drawing.Point(12, 34);
            this.gamesProgress.Maximum = 10;
            this.gamesProgress.Name = "gamesProgress";
            this.gamesProgress.Size = new System.Drawing.Size(592, 23);
            this.gamesProgress.Step = 1;
            this.gamesProgress.TabIndex = 10;
            // 
            // currentGameLabel
            // 
            this.currentGameLabel.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.currentGameLabel.Location = new System.Drawing.Point(12, 90);
            this.currentGameLabel.Name = "currentGameLabel";
            this.currentGameLabel.Size = new System.Drawing.Size(81, 23);
            this.currentGameLabel.TabIndex = 3;
            this.currentGameLabel.Text = "Processing: ";
            // 
            // stepText
            // 
            this.stepText.Location = new System.Drawing.Point(12, 8);
            this.stepText.Name = "stepText";
            this.stepText.Size = new System.Drawing.Size(413, 23);
            this.stepText.TabIndex = 13;
            this.stepText.Text = "(1/2) Scanning";
            this.stepText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // totalProcessed
            // 
            this.totalProcessed.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.totalProcessed.Location = new System.Drawing.Point(430, 8);
            this.totalProcessed.Name = "totalProcessed";
            this.totalProcessed.Size = new System.Drawing.Size(169, 23);
            this.totalProcessed.TabIndex = 14;
            this.totalProcessed.Text = "(100/5489)";
            this.totalProcessed.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // currentGame
            // 
            this.currentGame.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.currentGame.Location = new System.Drawing.Point(78, 90);
            this.currentGame.Name = "currentGame";
            this.currentGame.Size = new System.Drawing.Size(523, 23);
            this.currentGame.TabIndex = 15;
            this.currentGame.Text = "current game";
            // 
            // ProcessProgressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 136);
            this.ControlBox = false;
            this.Controls.Add(this.currentGame);
            this.Controls.Add(this.totalProcessed);
            this.Controls.Add(this.stepText);
            this.Controls.Add(this.currentGameLabel);
            this.Controls.Add(this.gamesProgress);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProcessProgressForm";
            this.Text = "ProcessProgressForm";
            this.TopMost = true;
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label stepText;

        private System.Windows.Forms.Label totalProcessed;

        private System.Windows.Forms.Label currentGame;

        private System.Windows.Forms.Label currentGameLabel;

        private System.Windows.Forms.ProgressBar gamesProgress;

        #endregion
    }
}