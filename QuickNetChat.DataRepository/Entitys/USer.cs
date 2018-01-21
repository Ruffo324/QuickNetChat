using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net;

namespace QuickNetChat.DataRepository.Entitys
{
    /// <summary>
    /// Contains all users that are visible or have already been contacted.
    /// </summary>
    public class User : EntityBase
    {
        /// <summary>
        /// E-Mail adress of the User.
        /// </summary>
        public string Mail { get; set; }

        /// <summary>
        /// Name of the user. 
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// Contains the Ip-Adress of the user as byte array.
        /// Can be Ipv4 and Ipv8
        /// </summary>
        [MinLength(4), MaxLength(16)]
        public byte[] IpAddressBytes { get; set; }


        /// <summary>
        /// Returns only the IpAdress of the User
        /// </summary>
        [NotMapped]
        public IPAddress IpAddress
        {
            get { return new IPAddress(IpAddressBytes); }
            set { IpAddressBytes = value.GetAddressBytes(); }
        }
    }
}