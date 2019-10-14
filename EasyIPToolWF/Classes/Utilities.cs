using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyIPToolWF.Classes
{
    class Utilities
    {
        public static List<String> net_adapters()
        {
            List<String> values = new List<String>();
            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                values.Add(nic.Name);
            }
            return values;
        }


        public static string GetIPVersion(RadioButton IPv4, RadioButton IPv6)
        {
            if (IPv4.Checked)
            {
                return "ipv4";
            }
            else if (IPv6.Checked)
            {
                return "ipv6";
            }
            else
            {
                return "";
            }
        }

        public static void PeriodPressed(KeyPressEventArgs e)
        {
            if (e.KeyChar == '.')
            {
                e.Handled = true;
            }
        }
        public static void PeriodPressed(KeyPressEventArgs e, TextBox newFocus)
        {
            if (e.KeyChar == '.')
            {
                e.Handled = true;
                newFocus.Focus();
            }
        }
        public static void BackSpace_PreviousBox(KeyPressEventArgs e, TextBox currentTextBox, TextBox newFocus)
        {
            if (e.KeyChar == (char)8 && currentTextBox.Text.Length == 0)
            {
                e.Handled = true;
                newFocus.Focus();
            }
        }
        public static void BackSpace_PreviousBox(KeyEventArgs e, TextBox currentTextBox, TextBox newFocus)
        {
            if (e.KeyCode == Keys.Back && currentTextBox.Text.Length == 0)
            {
                e.Handled = true;
                newFocus.Focus();
            }
        }

    }
}
