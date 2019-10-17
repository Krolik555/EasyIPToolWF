using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyIPToolWF.Classes
{
    static class Updates
    {
        private static Version currentVersion { get; set; }

        public static void CheckForUpdates()
        {
            GetCurrentVersion();
            GetLatestVersion();
            Cleanup();
        }


        private static void GetCurrentVersion()
        {
            // Get Version Info
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            FileVersionInfo _versionInfo = FileVersionInfo.GetVersionInfo(assembly.Location);
            Version tempVer = new Version(_versionInfo.ProductVersion);
            currentVersion = tempVer;
        }
        private static void GetLatestVersion()
        {
            // Download Latest Version from GitHub
            using (var client = new WebClient())
            {
                client.DownloadFile(@"https://github.com/Krolik555/EasyIPToolWF/raw/master/EasyIPToolWF.exe", "EasyIPToolWF_Update.exe");
                
            }
            // Collect File Version Information
            FileVersionInfo fileVersioninfo = FileVersionInfo.GetVersionInfo($@"{Directory.GetCurrentDirectory()}\EasyIPToolWF_Update.exe");
            Version newVersion = new Version(fileVersioninfo.ProductVersion);
            // Check if Download is newer
            if (newVersion > currentVersion)
            {
                DialogResult Result = MessageBox.Show($"An Update is available, Update now?\nCurrent Version: {currentVersion}\nLatest Version: {newVersion}", "Update Available!", MessageBoxButtons.YesNo);
                if (Result == DialogResult.Yes)
                {
                    Update();
                }
                else
                {
                    File.Delete($@"{Directory.GetCurrentDirectory()}\EasyIPToolWF_Update.exe");
                }
            }
            else
            {
                MessageBox.Show("You already have the latest version!");
                File.Delete($@"{Directory.GetCurrentDirectory()}\EasyIPToolWF_Update.exe");
            }
        }
        private static void Update()
        {
            string CurrentDir = Directory.GetCurrentDirectory();
            string Currentdir_FileName = System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName;
            File.Move(Currentdir_FileName, $"{Currentdir_FileName}.old");
            File.Move($@"{CurrentDir}\EasyIPToolWF_Update.exe", $@"{CurrentDir}\EasyIPToolWF.exe");
            Thread.Sleep(1000);
            Application.Restart();
        }
        private static void Cleanup()
        {
            if (File.Exists($"{System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName}.old"))
            {
                File.Delete($"{System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName}.old");
            }
        }
    }
}
