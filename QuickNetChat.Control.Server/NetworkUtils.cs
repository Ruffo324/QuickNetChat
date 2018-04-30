using System;
using System.Collections.Generic;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;

namespace QuickNetChat.Control.Server
{
    internal static class NetworkUtils
    {
        /// <summary>
        ///     Returns the Broadcast address for the given address and subnet subnetmask.
        /// </summary>
        /// <param name="address">An adress of the network.</param>
        /// <param name="subnetmask">The subnetmask of the network.</param>
        /// <returns>Broadcast adress of the network.</returns>
        public static IPAddress GetBroadcastAddress(IPAddress address, IPAddress subnetmask)
        {

            uint ipAddress = BitConverter.ToUInt32(address.GetAddressBytes(), 0);
            uint ipMaskV4 = BitConverter.ToUInt32(subnetmask.GetAddressBytes(), 0);
            uint broadCastIpAddress = ipAddress | ~ipMaskV4;

            return new IPAddress(BitConverter.GetBytes(broadCastIpAddress));
        }

        /// <summary>
        /// This function returning the subnet masks for all given network adapters.
        /// </summary>
        /// <returns>Dictionary with subnet mask for all given network adapters.</returns>
        public static Dictionary<NetworkInterface, IPAddress> GetOwnSubnetMasks()
        {
            Dictionary<NetworkInterface, IPAddress> subnetAddresses = new Dictionary<NetworkInterface, IPAddress>();
            foreach (NetworkInterface adapter in NetworkInterface.GetAllNetworkInterfaces())
            foreach (UnicastIPAddressInformation unicastIPAddressInformation in adapter.GetIPProperties()
                .UnicastAddresses)
                if (unicastIPAddressInformation.Address.AddressFamily == AddressFamily.InterNetwork)
                    subnetAddresses.Add(adapter, unicastIPAddressInformation.IPv4Mask);

            return subnetAddresses;
        }
    }
}