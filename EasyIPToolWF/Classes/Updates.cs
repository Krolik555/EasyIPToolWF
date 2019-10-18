using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyIPToolWF.Classes
{
    class Updates
    {
        private static Version currentVersion
        {
            get;
            set;
        }

        public static void CheckForUpdates()
        {
            Updates.GetCurrentVersion();
            Updates.GetLatestVersion();
            Updates.Cleanup();
        }

        private static void GetCurrentVersion()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            FileVersionInfo _versionInfo = FileVersionInfo.GetVersionInfo(assembly.Location);
            Version tempVer = new Version(_versionInfo.ProductVersion);
            Updates.currentVersion = tempVer;
        }

        private static void GetLatestVersion()
        {
            try
            {
                using (WebClient client = new WebClient())
                {
                    client.DownloadFile("https://github.com/Krolik555/ProgramUpdates/raw/master/EasyIPToolWF.exe", "EasyIPToolWF_Update.exe");
                }
            }
            catch (Exception err)
            {
                ErrorForm ErrFrm = new ErrorForm("Update Failed: There was an error while downloading the update. Please notify the developer.", err.ToString() + err.ToString() + err.ToString() + err.ToString(), "Error!");
                DialogResult dResult = ErrFrm.ShowDialog();
                return;
            }
            FileVersionInfo fileVersioninfo = FileVersionInfo.GetVersionInfo(Directory.GetCurrentDirectory() + @"\EasyIPToolWF_Update.exe");
            Version newVersion = new Version(fileVersioninfo.ProductVersion);
            bool flag = newVersion > Updates.currentVersion;
            if (flag)
            {
                DialogResult Result = MessageBox.Show(string.Format("An Update is available, Update now?\nCurrent Version: {0}\nLatest Version: {1}", Updates.currentVersion, newVersion), "Update Available!", MessageBoxButtons.YesNo);
                bool flag2 = Result == DialogResult.Yes;
                if (flag2)
                {
                    Updates.Update();
                }
                else
                {
                    File.Delete(Directory.GetCurrentDirectory() + @"\EasyIPToolWF_Update.exe");
                }
            }
            else
            {
                MessageBox.Show("You already have the latest version!");
                File.Delete(Directory.GetCurrentDirectory() + @"\EasyIPToolWF_Update.exe");
            }
        }

        private static void Update()
        {
            string CurrentDir = Directory.GetCurrentDirectory();
            string Currentdir_FileName = Process.GetCurrentProcess().MainModule.FileName;
            File.Move(Currentdir_FileName, Currentdir_FileName + ".old");
            File.Move(CurrentDir + @"\EasyIPToolWF_Update.exe", CurrentDir + @"\EasyIPToolWF.exe");
            Thread.Sleep(1000);
            Application.Restart();
        }

        private static void Cleanup()
        {
            try
            {
                if (File.Exists(Process.GetCurrentProcess().MainModule.FileName + ".old"))
                {
                    File.Delete(Process.GetCurrentProcess().MainModule.FileName + ".old");
                }
            }
            catch
            {

            }
        }

    }
}
