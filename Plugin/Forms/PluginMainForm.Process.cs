using System.Linq;
using Unbroken.LaunchBox.Plugins;

namespace Pamput.NoIntroLBPlugin
{
    partial class PluginForm
    {
        private void LoadPlatforms()
        {
            importPlatformComboBox.Items
                .AddRange(PluginHelper.DataManager.GetAllPlatforms().Select(p => p.Name)
                    .ToArray());
        }

        private void LoadImportedPlatforms()
        {
            platformToProcessSelectBox.Items.AddRange(DatHelper.GetImportedPlatforms());
        }
        
    }
}