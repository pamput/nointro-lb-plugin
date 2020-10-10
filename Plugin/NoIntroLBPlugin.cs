using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using Unbroken.LaunchBox.Plugins;

namespace Pamput.NoIntroLBPlugin
{
    public class NoIntroLBPlugin : ISystemMenuItemPlugin
    {
        public string Caption { get; } = "Test";

        public System.Drawing.Image IconImage { get; } = null;

        public bool ShowInLaunchBox { get; } = true;

        public bool ShowInBigBox { get; } = false;

        public bool AllowInBigBoxWhenLocked { get; } = false;

        public void OnSelected()
        {
            PluginForm pluginForm = new PluginForm();
            pluginForm.Show();
        }
    }
}