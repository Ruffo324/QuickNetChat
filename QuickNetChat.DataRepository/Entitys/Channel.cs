using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuickNetChat.DataRepository.Entitys
{
    /// <summary>
    /// Contains all known channel for the client
    /// </summary>
    public class Channel : EntityBase
    {
        /// <summary>
        /// Name of the Channel
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// Is this a public room?
        /// Means visible for all users
        /// </summary>
        [Required]
        public bool PublicRoom { get; set; }

        /// <summary>
        /// Owner of the Room
        /// </summary>
        [Required]
        public User Owner { get; set; }

        /// <summary>
        /// Member of the room
        /// </summary>
        public ICollection<User> Member { get; set; }
    }
}