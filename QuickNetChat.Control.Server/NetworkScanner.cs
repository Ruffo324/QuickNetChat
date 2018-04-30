using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace QuickNetChat.Control.Server
{
    /// <summary>
    ///     This scanner takes care about scanning the network for other chat clients.
    ///     The scanner will use the subnetmask to calculate possible hosts in the network.
    ///     Works currently only with ipv4 networks.
    /// </summary>
    public class NetworkScanner
    {
        /// <summary>
        /// Contains the own ipv4 adress.
        /// </summary>
        private IPAddress _ownIpAddress;


    }
}
