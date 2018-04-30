using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace QuickNetChat.Control.Connection
{
    /// <summary>
    /// This is a network. 
    /// If the computer on where the chat programm is running, 
    /// have multiple network interfaces, the chat programm can communicate over all given networks
    /// </summary>
    public class Network
    {
        public IPAddress OwnIpAddress;
        public IPAddress SubnetMaskAddress;
        public NetworkInterface NetworkInterface;

    }
}
