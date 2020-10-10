using System;
using System.Windows.Forms;

namespace Pamput.NoIntroLBPlugin
{
    public partial class ProcessProgressForm : Form
    {
        private Progress<ProcessProgress> _progress;

        public ProcessProgressForm(Progress<ProcessProgress> progress)
        {
            _progress = progress;
            _progress.ProgressChanged += (s, e) => { UpdateProgress(e); };

            InitializeComponent();
        }

        private void UpdateProgress(ProcessProgress e)
        {
            if (e.CloneProcessFinished)
            {
                Dispose();
                return;
            }

            if (!e.GamesScanFinished)
            {
                stepText.Text = "Looking for clones...";
                totalProcessed.Text = $@"({e.ProcessedGames}/{e.TotalGames})";
                gamesProgress.Maximum = e.TotalGames;
                gamesProgress.Value = e.ProcessedGames;
            }
            else
            {
                stepText.Text = "Processing clones...";
                totalProcessed.Text = $@"({e.ProcessedClones}/{e.TotalClones})";
                gamesProgress.Maximum = e.TotalClones;
                gamesProgress.Value = e.ProcessedClones;
            }

            currentGame.Text = e.CurrentGame;
        }
    }
}