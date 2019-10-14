using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyIPToolWF.Classes
{
    class AddressInformation
    {
        // # Address Strings #
        /// <summary>
        /// Address in string form (xxx.xxx.xxx.xxx)
        /// </summary>
        private string ipv4Addr;
        public string IPv4Addr
        {
            get
            {
                return this.ipv4Addr;
            }
            set
            {
                this.ipv4Addr = value;
                // Split IPv4 Address
                if (ipv4Addr != "")
                    IPv4AddrArr = IPv4Addr.Split('.');
            }
        }

        /// <summary>
        /// Address in string form (xxx.xxx.xxx.xxx)
        /// </summary>
        private string subnetAddr;
        public string SubnetAddr
        {
            get
            {
                return this.subnetAddr;
            }
            set
            {
                this.subnetAddr = value;
                // Split Subnet Address
                if (subnetAddr != "")
                    SubnetAddrArr = SubnetAddr.Split('.');
            }
        }
        /// <summary>
        /// Address in string form (xxx.xxx.xxx.xxx)
        /// </summary>
        private string gatewayAddr;
        public string GatewayAddr
        {
            get
            {
                return this.gatewayAddr;
            }
            set
            {
                this.gatewayAddr = value;
                // Split Gateway Address
                if (gatewayAddr != "")
                    GatewayAddrArr = GatewayAddr.Split('.');
            }
        }
        /// <summary>
        /// Address in string form (xxx.xxx.xxx.xxx)
        /// </summary>
        private string dnsAddr;
        public string DNSAddr
        {
            get
            {
                return this.dnsAddr;
            }
            set
            {
                this.dnsAddr = value;
                // Split DNS Address
                if (dnsAddr != "")
                    DNSAddrArr = DNSAddr.Split('.');
            }
        }

        
        // # Address String Arrays by Octet #
        /// <summary>
        /// Automatically Broken into octets - [0]: xxx [1]: xxx [2]: xxx [3]: xxx
        /// </summary>
        public string[] IPv4AddrArr { get; private set; }
        /// <summary>
        /// Broken into octets - [0]: xxx [1]: xxx [2]: xxx [3]: xxx
        /// </summary>
        public string[] SubnetAddrArr { get; private set; }
        /// <summary>
        /// Broken into octets - [0]: xxx [1]: xxx [2]: xxx [3]: xxx
        /// </summary>
        public string[] GatewayAddrArr { get; private set; }
        /// <summary>
        /// Broken into octets - [0]: xxx [1]: xxx [2]: xxx [3]: xxx
        /// </summary>
        public string[] DNSAddrArr { get; private set; }

    }
}
