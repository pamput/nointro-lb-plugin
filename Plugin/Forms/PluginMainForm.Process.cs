using System;
using System.Linq;
using Unbroken.LaunchBox.Plugins;

namespace Pamput.NoIntroLBPlugin
{
    partial class PluginForm
    {
        private void LoadPlatforms()
        {
            var platforms = PluginHelper
                .DataManager
                .GetAllPlatforms()
                .Select(p => p.Name)
                .ToArray();
            
            Array.Sort(platforms);
            
            importPlatformComboBox.Items.Clear();
            importPlatformComboBox.Items.AddRange(platforms);
        }

        private void LoadImportedPlatforms()
        {
            var platforms = DatHelper.GetImportedPlatforms();
            Array.Sort(platforms);
            
            platformToProcessSelectBox.Items.Clear();
            platformToProcessSelectBox.Items.AddRange(platforms);
        }
        
    }
}