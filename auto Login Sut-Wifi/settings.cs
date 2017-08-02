using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace auto_Login_Sut_Wifi
{
    public partial class settings : Form
    {
        public settings()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            RegistryKey rkApp = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            if (startup.Checked)
            {
                if (!IsStartupItem())
                    rkApp.SetValue("AutoLoginSutWifi", Application.ExecutablePath.ToString());
                Properties.Settings.Default.autoStart = "true";
            }
            else
            {
                if (IsStartupItem())
                    rkApp.DeleteValue("AutoLoginSutWifi", false);
                Properties.Settings.Default.autoStart = "false";
            }
            if (loginwhenStart.Checked)
            {
                Properties.Settings.Default.LoginWhenStartThis = "true";
            }
            else
            {
                Properties.Settings.Default.LoginWhenStartThis = "false";
            }
            if (AutoClose.Checked)
            {
                Properties.Settings.Default.AutoClose = "true";
            }
            else
            {
                Properties.Settings.Default.AutoClose = "false";
            }

            Properties.Settings.Default.Save();
            this.Close();
        }
        private bool IsStartupItem()
        {
            // The path to the key where Windows looks for startup applications
            RegistryKey rkApp = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

            if (rkApp.GetValue("AutoLoginSutWifi") == null)
                // The value doesn't exist, the application is not set to run at startup
                return false;
            else
                // The value exists, the application is set to run at startup
                return true;
        }

        private void settings_Load(object sender, EventArgs e)
        {
            startup.Checked = Convert.ToBoolean(Properties.Settings.Default.autoStart);
            loginwhenStart.Checked = Convert.ToBoolean(Properties.Settings.Default.LoginWhenStartThis);
            AutoClose.Checked = Convert.ToBoolean(Properties.Settings.Default.AutoClose);
        }

        private void loginwhenStart_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void startup_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
