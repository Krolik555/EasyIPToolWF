using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyIPToolWF.Classes
{
    class NetworkInfo
    {
        public static NetworkInterface[] NetworkAdapters;

        public static NetworkInterface GetAdapterByName(string adapterName)
        {
            foreach (NetworkInterface adapter in NetworkAdapters)
            {
                if (adapter.Name == adapterName)
                {
                    return adapter;
                }
            }
            return null;
        }

        /// <summary>
        /// Get IP, Subnet, Gateway, DNS addresses
        /// Variables available:
        ///  IPv4Addr,
        ///  SubnetAddr,
        ///  GatewayAddr,
        ///  DNSAddr
        /// </summary>
        public static AddressInformation GetAdapterInfo(string adapterName)
        {
            try
            {
                AddressInformation CollectedInformation = new AddressInformation();

                #region Get All Network Info
                // Get all Network Adapter Information
                NetworkInterface selectedadapter = Classes.NetworkInfo.GetAdapterByName(adapterName);
                // Get IP Properties (Includes all IP Info)
                IPInterfaceProperties ipp = selectedadapter.GetIPProperties();
                #endregion

                #region Get IP/Subnet Info
                // Step 1 - Get Unicast IP Collection
                UnicastIPAddressInformationCollection ipv4Collection = ipp.UnicastAddresses;
                // Step 2 - Get IEnumerator for Unicast IP Collection
                IEnumerator<UnicastIPAddressInformation> IEnumIPv4Subnet = ipv4Collection.GetEnumerator();
                // Step 3 - Move to the first item in the IEnumerator
                IEnumIPv4Subnet.MoveNext();
                // Verify ipv4 and not ipv6
                while (IEnumIPv4Subnet.Current.Address.ToString().Contains(":"))
                {
                    IEnumIPv4Subnet.MoveNext();
                }
                CollectedInformation.IPv4Addr = IEnumIPv4Subnet.Current.Address.ToString();
                // Get Subnet
                CollectedInformation.SubnetAddr = IEnumIPv4Subnet.Current.IPv4Mask.ToString();
                #endregion

                #region Get Gateway Info
                // Step 1 - Get Gateway Address Collection
                GatewayIPAddressInformationCollection gatewayCollection = ipp.GatewayAddresses;
                // Step 2 - Get IEnumerator for Gateway Collection
                IEnumerator<GatewayIPAddressInformation> IEnumGateway = gatewayCollection.GetEnumerator();
                // Step 3 - Move to the first item in the IEnumerator
                IEnumGateway.MoveNext();
                // Get Gateway Address
                CollectedInformation.GatewayAddr = IEnumGateway.Current.Address.ToString();
                #endregion

                #region Get DNS Info
                // Step 1 - Get DNS Address Collection
                IPAddressCollection dnsCollection = ipp.DnsAddresses;
                // Step 2 - Get IEnumerator for DNS Collection
                IEnumerator<IPAddress> IEnumDNS = dnsCollection.GetEnumerator();
                // Step 3 - Move to the first item in the IEnumerator
                IEnumDNS.MoveNext();
                // Get DNS Address
                CollectedInformation.DNSAddr = IEnumDNS.Current.ToString();
                #endregion

                return CollectedInformation;
            }
            catch(NullReferenceException)
            {
                MessageBox.Show("No Address information found");
                return null;
            }
            catch(Exception err)
            {
                MessageBox.Show(err.ToString());
                return null;
            }
        }

        public static void SetStaticIP(string IPAddress, string SubnetMask, string Gateway, string DNS, string adapterDescription)
        {
            var adapterConfig = new ManagementClass("Win32_NetworkAdapterConfiguration");
            var networkCollection = adapterConfig.GetInstances();

            foreach (ManagementObject adapter in networkCollection)
            {
                string description = adapter["Description"] as string;
                if (string.Compare(description,
                    adapterDescription, StringComparison.InvariantCultureIgnoreCase) == 0)
                {
                    try
                    {
                        // Set DefaultGateway
                        var newGateway = adapter.GetMethodParameters("SetGateways");
                        newGateway["DefaultIPGateway"] = new string[] { Gateway };
                        newGateway["GatewayCostMetric"] = new int[] { 1 };

                        // Set IPAddress and Subnet Mask
                        var newAddress = adapter.GetMethodParameters("EnableStatic");
                        newAddress["IPAddress"] = new string[] { IPAddress };
                        newAddress["SubnetMask"] = new string[] { SubnetMask };

                        // Set DNS Address
                        var newDNS = adapter.GetMethodParameters("SetDNSServerSearchOrder");
                        newDNS["DNSServerSearchOrder"] = new string[] { DNS };

                        adapter.InvokeMethod("EnableStatic", newAddress, null);
                        adapter.InvokeMethod("SetGateways", newGateway, null);
                        adapter.InvokeMethod("SetDNSServerSearchOrder", newDNS, null);

                        MessageBox.Show("Updated to static IP address!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Unable to Set IP : " + ex.Message);
                    }
                }
            }
        }

        public static void SetDHCPIP(string adapterDescription)
        {
            var adapterConfig = new ManagementClass("Win32_NetworkAdapterConfiguration");
            var networkCollection = adapterConfig.GetInstances();

            foreach(ManagementObject adapter in networkCollection)
            {
                string description = adapter["Description"] as string;
                if (string.Compare(description,
                    adapterDescription, StringComparison.InvariantCultureIgnoreCase) == 0)
                {
                    try
                    {
                        adapter.InvokeMethod("EnableDHCP", null);
                        adapter.InvokeMethod("SetDNSServerSearchOrder", null);

                        MessageBox.Show("Updated to Dynamic IP address!");
                    }
                    catch(Exception err)
                    {
                        MessageBox.Show(err.Message);
                    }
                }
            }
        }
    }
}
