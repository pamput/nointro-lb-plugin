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
using Unbroken.LaunchBox.Plugins;

namespace Pamput.NoIntroLBPlugin
{
    public partial class PluginForm : Form
    {
        public PluginForm()
        {
            InitializeComponent();

            LoadPlatforms();
            LoadImportedPlatforms();
        }

        

        private void processButton_Click(object sender, EventArgs e)
        {
            var selectedPlatform = platformToProcessSelectBox.SelectedItem;

            if (selectedPlatform == null)
            {
                MessageBox.Show("Please select a platform to process", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var platform = selectedPlatform.ToString();
            
            Progress<ProcessProgress> progress = new Progress<ProcessProgress>();
            ProcessProgressForm form = new ProcessProgressForm(progress);
            NoIntroLBProcessor processor = new NoIntroLBProcessor(platform, DatHelper.GetPlatformDatFile(platform));

            Task.Run(() => { processor.Process(progress); });

            form.Show(this);
        }

        private void importDatButton_Click(object sender, EventArgs e)
        {
            var selectedPlatform = importPlatformComboBox.SelectedItem;

            if (selectedPlatform == null)
            {
                MessageBox.Show("Select a platform first from the combo box", "Warning", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            openDATFileDialog.ShowDialog();
            DatHelper.ImportDat(openDATFileDialog.FileName, selectedPlatform.ToString());
            LoadImportedPlatforms();
        }
    }
}