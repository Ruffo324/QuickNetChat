using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace QuickNetChat.DataRepository.Entitys
{
    /// <summary>
    ///     Contains all known channel for the client
    /// </summary>
    public class Channel : EntityBase
    {
        /// <summary>
        ///     Name of the Channel
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        ///     Is this a public room?
        ///     Means visible for all users
        /// </summary>
        [Required]
        public bool PublicRoom { get; set; }

        /// <summary>
        ///     Member of the room
        /// </summary>
        public ICollection<User> Member { get; set; }

        public ICollection<Message> Messages { get; set; }
    }
}