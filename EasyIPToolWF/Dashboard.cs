using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.Net;
using System.IO;

namespace EasyIPToolWF
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            Classes.Settings.GetSettings();
            // Set Location
            try
            {
                this.TopMost = Classes.Settings.AlwaysOnTop;
                this.ShowInTaskbar = Classes.Settings.ShowInTaskbar;
                if (Classes.Settings.LastPOSX != 0 && Classes.Settings.LastPOSY != 0)
                {
                    this.StartPosition = FormStartPosition.Manual;
                    this.Left = Classes.Settings.LastPOSX;
                    this.Top = Classes.Settings.LastPOSY;
                }
            }
            catch
            {

            }
        }

        private void ARadioBtnDHCP_CheckedChanged(object sender, EventArgs e)
        {
            if (aRadioBtnDHCP.Checked)
            {
                EnableStaticControls(false);
            }
        }

        private void ARadioBtnStatic_CheckedChanged(object sender, EventArgs e)
        {
            if (aRadioBtnStatic.Checked)
            {
                EnableStaticControls(true);
            }
        }

        public void EnableStaticControls(bool Enabled)
        {
            aTBIP1.Enabled = Enabled;
            aTBIP2.Enabled = Enabled;
            aTBIP3.Enabled = Enabled;
            aTBIP4.Enabled = Enabled;

            aTBSubnet1.Enabled = Enabled;
            aTBSubnet2.Enabled = Enabled;
            aTBSubnet3.Enabled = Enabled;
            aTBSubnet4.Enabled = Enabled;

            aTBGateway1.Enabled = Enabled;
            aTBGateway2.Enabled = Enabled;
            aTBGateway3.Enabled = Enabled;
            aTBGateway4.Enabled = Enabled;

            aTBDNS1.Enabled = Enabled;
            aTBDNS2.Enabled = Enabled;
            aTBDNS3.Enabled = Enabled;
            aTBDNS4.Enabled = Enabled;

        }

        #region 3 Characters typed
        private void ATBOct1_TextChanged(object sender, EventArgs e)
        {
            if (aTBIP1.Text.Length == 3)
            {
                aTBIP2.Focus();
            }
        }
        private void ATBOct2_TextChanged(object sender, EventArgs e)
        {
            if (aTBIP2.Text.Length == 3)
            {
                aTBIP3.Focus();
            }
        }
        private void ATBOct3_TextChanged(object sender, EventArgs e)
        {
            if (aTBIP3.Text.Length == 3)
            {
                aTBIP4.Focus();
            }
        }
        private void ATBSubnet1_TextChanged(object sender, EventArgs e)
        {
            if (aTBSubnet1.Text.Length == 3)
            {
                aTBSubnet2.Focus();
            }
        }
        private void ATBSubnet2_TextChanged(object sender, EventArgs e)
        {
            if (aTBSubnet2.Text.Length == 3)
            {
                aTBSubnet3.Focus();
            }
        }
        private void ATBSubnet3_TextChanged(object sender, EventArgs e)
        {
            if (aTBSubnet3.Text.Length == 3)
            {
                aTBSubnet4.Focus();
            }
        }
        private void ATBGateway1_TextChanged(object sender, EventArgs e)
        {
            if (aTBGateway1.Text.Length == 3)
            {
                aTBGateway2.Focus();
            }
        }
        private void ATBGateway2_TextChanged(object sender, EventArgs e)
        {
            if (aTBGateway2.Text.Length == 3)
            {
                aTBGateway3.Focus();
            }
        }
        private void ATBGateway3_TextChanged(object sender, EventArgs e)
        {
            if (aTBGateway3.Text.Length == 3)
            {
                aTBGateway4.Focus();
            }
        }
        private void ATBDNS1_TextChanged(object sender, EventArgs e)
        {
            if (aTBDNS1.Text.Length == 3)
            {
                aTBDNS2.Focus();
            }
        }
        private void ATBDNS2_TextChanged(object sender, EventArgs e)
        {
            if (aTBDNS2.Text.Length == 3)
            {
                aTBDNS3.Focus();
            }
        }
        private void ATBDNS3_TextChanged(object sender, EventArgs e)
        {
            if (aTBDNS3.Text.Length == 3)
            {
                aTBDNS4.Focus();
            }
        }
        #endregion


        #region Decimal or Backspace Key Pressed
        private void ATBIP1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Classes.Utilities.PeriodPressed(e, aTBIP2);
        }

        private void ATBIP2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Classes.Utilities.PeriodPressed(e, aTBIP3);
            Classes.Utilities.BackSpace_PreviousBox(e, aTBIP2, aTBIP1);
        }

        private void ATBIP3_KeyPress(object sender, KeyPressEventArgs e)
        {
            Classes.Utilities.PeriodPressed(e, aTBIP4);
            Classes.Utilities.BackSpace_PreviousBox(e, aTBIP3, aTBIP2);
        }

        private void ATBIP4_KeyPress(object sender, KeyPressEventArgs e)
        {
            Classes.Utilities.PeriodPressed(e);
            Classes.Utilities.BackSpace_PreviousBox(e, aTBIP4, aTBIP3);
        }

        private void ATBSubnet1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Classes.Utilities.PeriodPressed(e, aTBSubnet2);
        }

        private void ATBSubnet2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Classes.Utilities.PeriodPressed(e, aTBSubnet3);
            Classes.Utilities.BackSpace_PreviousBox(e, aTBSubnet2, aTBSubnet1);
        }

        private void ATBSubnet3_KeyPress(object sender, KeyPressEventArgs e)
        {
            Classes.Utilities.PeriodPressed(e, aTBSubnet4);
            Classes.Utilities.BackSpace_PreviousBox(e, aTBSubnet3, aTBSubnet2);
        }

        private void ATBSubnet4_KeyPress(object sender, KeyPressEventArgs e)
        {
            Classes.Utilities.PeriodPressed(e);
            Classes.Utilities.BackSpace_PreviousBox(e, aTBSubnet4, aTBSubnet3);
        }

        private void ATBGateway1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Classes.Utilities.PeriodPressed(e, aTBGateway2);
        }

        private void ATBGateway2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Classes.Utilities.PeriodPressed(e, aTBGateway3);
            Classes.Utilities.BackSpace_PreviousBox(e, aTBGateway2, aTBGateway1);
        }

        private void ATBGateway3_KeyPress(object sender, KeyPressEventArgs e)
        {
            Classes.Utilities.PeriodPressed(e, aTBGateway4);
            Classes.Utilities.BackSpace_PreviousBox(e, aTBGateway3, aTBGateway2);
        }

        private void ATBGateway4_KeyPress(object sender, KeyPressEventArgs e)
        {
            Classes.Utilities.PeriodPressed(e);
            Classes.Utilities.BackSpace_PreviousBox(e, aTBGateway4, aTBGateway3);
        }
        private void ATBDNS1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Classes.Utilities.PeriodPressed(e, aTBDNS2);
        }

        private void ATBDNS2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Classes.Utilities.PeriodPressed(e, aTBDNS3);
            Classes.Utilities.BackSpace_PreviousBox(e, aTBDNS2, aTBDNS1);
        }

        private void ATBDNS3_KeyPress(object sender, KeyPressEventArgs e)
        {
            Classes.Utilities.PeriodPressed(e, aTBDNS4);
            Classes.Utilities.BackSpace_PreviousBox(e, aTBDNS3, aTBDNS2);
        }

        private void ATBDNS4_KeyPress(object sender, KeyPressEventArgs e)
        {
            Classes.Utilities.PeriodPressed(e);
            Classes.Utilities.BackSpace_PreviousBox(e, aTBDNS4, aTBDNS3);
        }
        #endregion

        private void ATBSubnet1_Enter(object sender, EventArgs e)
        {
            // Default Subnet
            if (aTBIP1.Text != "" && aTBIP2.Text != "" && aTBIP3.Text != "" && aTBIP4.Text != "" &&
            aTBSubnet1.Text == "" && aTBSubnet2.Text == "" && aTBSubnet3.Text == "" && aTBSubnet4.Text == "")
            {
                aTBSubnet1.Text = "255";
                aTBSubnet2.Text = "255";
                aTBSubnet3.Text = "255";
                aTBSubnet4.Text = "0";
            }
        }

        private void AComboboxAdapter_DropDown(object sender, EventArgs e)
        {
            aComboboxAdapter.Items.Clear();
            // Get Adapter data
            Classes.NetworkInfo.NetworkAdapters = NetworkInterface.GetAllNetworkInterfaces();

            // Get each adapter's names for Combobox
            foreach (NetworkInterface adapter in Classes.NetworkInfo.NetworkAdapters)
            {
                if (!adapter.Name.Contains("Loopback") && !adapter.Description.Contains("Virtual") && !adapter.Description.Contains("Bluethooth"))// some sort of Pseudo-Interface
                {
                    aComboboxAdapter.Items.Add(adapter.Name);
                }
            }
        }

        private void AComboboxAdapter_SelectedIndexChanged(object sender, EventArgs e)
        {
            #region Get Current Internet Protocl
            var adapterConfig = new ManagementClass("Win32_NetworkAdapterConfiguration");
            var networkCollection = adapterConfig.GetInstances();
            NetworkInterface SelectedAdapter = Classes.NetworkInfo.GetAdapterByName(aComboboxAdapter.SelectedItem.ToString());
            foreach (ManagementObject adapter in networkCollection)
            {
                string description = adapter["Description"] as string;
                try
                {
                    if (description == SelectedAdapter.Description)
                    {
                        bool InternetProtocol = bool.Parse(adapter["DHCPEnabled"].ToString());
                        if (InternetProtocol == true)
                        {
                            aRadioBtnDHCP.Checked = true;
                        }
                        else
                        {
                            aRadioBtnStatic.Checked = true;
                        }
                    }
                }
                catch
                {

                }
            }
            #endregion

            // Get IP Addressing Information
            Classes.AddressInformation AdapterInformation = new Classes.AddressInformation();

            AdapterInformation = Classes.NetworkInfo.GetAdapterInfo(aComboboxAdapter.SelectedItem.ToString());

            try
            {
                // Display Current IPv4 Address
                //string[] IPv4AddrArr = IPv4Addr.Split('.');
                aTBIP1.Text = AdapterInformation.IPv4AddrArr[0];
                aTBIP2.Text = AdapterInformation.IPv4AddrArr[1];
                aTBIP3.Text = AdapterInformation.IPv4AddrArr[2];
                aTBIP4.Text = AdapterInformation.IPv4AddrArr[3];

                // Display Current Subnet Address
                //string[] SubnetAddrArr = SubnetAddr.Split('.');
                aTBSubnet1.Text = AdapterInformation.SubnetAddrArr[0];
                aTBSubnet2.Text = AdapterInformation.SubnetAddrArr[1];
                aTBSubnet3.Text = AdapterInformation.SubnetAddrArr[2];
                aTBSubnet4.Text = AdapterInformation.SubnetAddrArr[3];

                // Display Current Gateway Address
                //string[] GatewayAddrArr = GatewayAddr.Split('.');
                aTBGateway1.Text = AdapterInformation.GatewayAddrArr[0];
                aTBGateway2.Text = AdapterInformation.GatewayAddrArr[1];
                aTBGateway3.Text = AdapterInformation.GatewayAddrArr[2];
                aTBGateway4.Text = AdapterInformation.GatewayAddrArr[3];

                // Display Current DNS Address
                //string[] DNSAddrArr = DNSAddr.Split('.');
                aTBDNS1.Text = AdapterInformation.DNSAddrArr[0];
                aTBDNS2.Text = AdapterInformation.DNSAddrArr[1];
                aTBDNS3.Text = AdapterInformation.DNSAddrArr[2];
                aTBDNS4.Text = AdapterInformation.DNSAddrArr[3];
            }
            catch
            {

            }
        }

        private void AButtonSet_Click(object sender, EventArgs e)
        {
            // Get info about selected adapter by its Name
            NetworkInterface selectedAdapter = Classes.NetworkInfo.GetAdapterByName(aComboboxAdapter.SelectedItem.ToString());
            // Get selected Adapter's Description
            string adapterDescription = $"{selectedAdapter.Description}";

            if (aRadioBtnStatic.Checked)
            {
                // New Address information
                string ipaddress = $"{aTBIP1.Text}.{aTBIP2.Text}.{aTBIP3.Text}.{aTBIP4.Text}";
                string subnetMask = $"{aTBSubnet1.Text}.{aTBSubnet2.Text}.{aTBSubnet3.Text}.{aTBSubnet4.Text}";
                string gateway = $"{aTBGateway1.Text}.{aTBGateway2.Text}.{aTBGateway3.Text}.{aTBGateway4.Text}";
                string DNSDomain = $"{aTBDNS1.Text}.{aTBDNS2.Text}.{aTBDNS3.Text}.{aTBDNS4.Text}";

                Classes.NetworkInfo.SetStaticIP(ipaddress, subnetMask, gateway, DNSDomain, adapterDescription);
            }
            else if (aRadioBtnDHCP.Checked)
            {
                Classes.NetworkInfo.SetDHCPIP(adapterDescription);
            }
        }

        private void AButtonClear_Click(object sender, EventArgs e)
        {
            aTBIP1.Text = "";
            aTBIP2.Text = "";
            aTBIP3.Text = "";
            aTBIP4.Text = "";

            aTBSubnet1.Text = "";
            aTBSubnet2.Text = "";
            aTBSubnet3.Text = "";
            aTBSubnet4.Text = "";

            aTBGateway1.Text = "";
            aTBGateway2.Text = "";
            aTBGateway3.Text = "";
            aTBGateway4.Text = "";

            aTBDNS1.Text = "";
            aTBDNS2.Text = "";
            aTBDNS3.Text = "";
            aTBDNS4.Text = "";

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            Classes.Settings.GetSettings();
            SettingsForm ConfigureSettings = new SettingsForm();
            DialogResult dResult = ConfigureSettings.ShowDialog();
            if (dResult == DialogResult.OK)
            {
                this.TopMost = Classes.Settings.AlwaysOnTop;
                this.ShowInTaskbar = Classes.Settings.ShowInTaskbar;
            }
        }

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Classes.Settings.LastPOSX = this.Location.X;
            Classes.Settings.LastPOSY = this.Location.Y;
            Classes.Settings.SaveSettings();
        }
    }
}
