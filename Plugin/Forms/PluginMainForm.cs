using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;

namespace Pamput.NoIntroLBPlugin
{
    public partial class PluginUI : Form
    {
        private NoIntroLBProcessor Processor;

        public PluginUI()
        {
            InitializeComponent();
        }

        private void loadDATs_Click(object sender, EventArgs e)
        {
            openDATFileDialog.ShowDialog();

            Processor = new NoIntroLBProcessor("Super Nintendo Entertainment System", openDATFileDialog.FileName);
            checkedListBox1.Items.Add(openDATFileDialog.FileName);

            List<string> rows = new List<string>();

            foreach (KeyValuePair<string, XmlNode> game in Processor.NameToNoIntroMap)
            {
                rows.Add(game.Key);
            }

            this.noIntroMapListBox.Items.AddRange(rows.ToArray());
        }

        private void noIntroMapList_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void md5CheckButton_Click(object sender, EventArgs e)
        {
            if (Processor == null)
            {
                MessageBox.Show("No dat file loaded", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            openRomForMD5Dialog.ShowDialog();

            string md5 = RomIOHelper.GetMD5(openRomForMD5Dialog.FileName);

            if (Processor.Md5ToNoIntroMap.ContainsKey(md5))
            {
                string game = Processor.Md5ToNoIntroMap[md5].Attributes["name"].Value;
                MessageBox.Show(md5, game, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(md5);
            }


            Clipboard.SetText(md5);
        }

        private void NoIntroLBUI_Load(object sender, EventArgs e)
        {
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void processSnes_Click(object sender, EventArgs e)
        {
            if (Processor == null)
            {
                MessageBox.Show("No dat file loaded", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Processor.Process();
        }

        private void progressTest_Click(object sender, EventArgs e)
        {
            Progress<ProcessProgress> progress = new Progress<ProcessProgress>();
            ProcessProgressForm form = new ProcessProgressForm(progress);
            ProcessProgress state = new ProcessProgress();
            

            Task.Run(() =>
            {
                IProgress<ProcessProgress> pr = progress;

                state.TotalGames = 10;
                pr.Report(state);

                for (int i = 1; i <= 10; i++)
                {
                    state.CurrentGame = $"Game {i}";
                    pr.Report(state);
                    System.Threading.Thread.Sleep(1000);
                    
                    state.ProcessedGames = i;
                    pr.Report(state);
                }

                state.GamesScanFinished = true;
                pr.Report(state);

                state.TotalClones = 10;
                pr.Report(state);

                for (int i = 1; i <= 10; i++)
                {
                    state.ProcessedClones = i;
                    pr.Report(state);
                    System.Threading.Thread.Sleep(1000);
                    
                    state.CurrentGame = $"Game {i}";
                    pr.Report(state);
                }

                state.CloneProcessFinished = true;
                pr.Report(state);
            });
            
            form.Show(this);
        }
    }
}