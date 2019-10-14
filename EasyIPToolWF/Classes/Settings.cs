using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyIPToolWF.Classes
{
    static class Settings
    {
        /// <summary>
        /// Line 1
        /// </summary>
        public static bool AlwaysOnTop { get; set; }
        /// <summary>
        /// Line 2
        /// </summary>
        public static bool ShowInTaskbar { get; set; }

        /// <summary>
        /// Line 3
        /// </summary>
        public static int LastPOSX { get; set; }
        /// <summary>
        /// Line 4
        /// </summary>
        public static int LastPOSY { get; set; }

        public static void GetSettings()
        {
            // Settings File Doesn't exist
            if (!File.Exists(@"C:\ProgramData\EasyIPTool\settings.txt"))
            {
                if (!Directory.Exists(@"C:\ProgramData\EasyIPTool"))
                {
                    Directory.CreateDirectory(@"C:\ProgramData\EasyIPTool");
                }
                
                StreamWriter sw = new StreamWriter(@"C:\ProgramData\EasyIPTool\settings.txt");
                sw.WriteLine("AlwaysOnTop:false");
                sw.WriteLine("ShowInTaskbar:false");
                sw.Close();
            }
            else 
            // Settings file does exist
            {
                try
                {
                    // Read Settings file
                    string[] retrievedSettings = File.ReadAllLines(@"C:\ProgramData\EasyIPTool\settings.txt");
                    // Get Bool settings
                    Classes.Settings.AlwaysOnTop = bool.Parse(retrievedSettings[0].Substring(12));
                    Classes.Settings.ShowInTaskbar = bool.Parse(retrievedSettings[1].Substring(14));

                    if (retrievedSettings[2] != null && retrievedSettings[3] != null)
                    {
                        // Get Last Position settings
                        Classes.Settings.LastPOSX = Convert.ToInt32(retrievedSettings[2].Substring(9));
                        Classes.Settings.LastPOSY = Convert.ToInt32(retrievedSettings[3].Substring(9));
                    }
                }
                catch (IndexOutOfRangeException)
                {

                }
                catch(Exception err)
                {
                    MessageBox.Show(err.ToString());
                }
                
            }
            
        }
        public static void SaveSettings()
        {
            using (StreamWriter sw = new StreamWriter(@"C:\ProgramData\EasyIPTool\settings.txt"))
            {
                sw.WriteLine($"AlwaysOnTop:{AlwaysOnTop}");
                sw.WriteLine($"ShowInTaskbar:{ShowInTaskbar}");
                sw.WriteLine($"LastPOSX:{LastPOSX}");
                sw.WriteLine($"LastPOSY:{LastPOSY}");
            }
        }
    }
}
