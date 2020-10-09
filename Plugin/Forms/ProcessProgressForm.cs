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

            partProgress.Value = !e.GamesScanFinished ? 1 : 2;
            currentGameLabel.Text = e.CurrentGame;

            if (!e.GamesScanFinished)
            {
                gamesProgress.Maximum = e.TotalGames;
                gamesProgress.Value = e.ProcessedGames;
            }
            else
            {
                gamesProgress.Maximum = e.TotalClones;
                gamesProgress.Value = e.ProcessedClones;
            }
        }
    }
}