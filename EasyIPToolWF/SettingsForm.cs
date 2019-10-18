using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyIPToolWF
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
            aCheckBoxAlwaysOnTop.Checked = Classes.Settings.AlwaysOnTop;
            aCheckBoxShowInTaskbar.Checked = Classes.Settings.ShowInTaskbar;
        }

        private void AButtonSave_Click(object sender, EventArgs e)
        {
            Classes.Settings.AlwaysOnTop = aCheckBoxAlwaysOnTop.Checked;
            Classes.Settings.ShowInTaskbar = aCheckBoxShowInTaskbar.Checked;
            Classes.Settings.SaveSettings();
            DialogResult = DialogResult.OK;
            //this.Close();
        }

        private void AButtonCheckForUpdates_Click(object sender, EventArgs e)
        {
            bool HasInternet;
            try
            {
                using (WebClient client = new WebClient())
                {
                    using (client.OpenRead("http://google.com/generate_204"))
                    {
                        HasInternet = true;
                    }
                }
            }
            catch
            {
                HasInternet = false;
            }
            bool flag = HasInternet;
            if (flag)
            {
                Classes.Settings.AlwaysOnTop = this.aCheckBoxAlwaysOnTop.Checked;
                Classes.Settings.ShowInTaskbar = this.aCheckBoxShowInTaskbar.Checked;
                Classes.Settings.SaveSettings();
                base.DialogResult = DialogResult.Yes;
            }
            else
            {
                MessageBox.Show("No Internet Connection!", "Error!");
            }
        }
    }
}
