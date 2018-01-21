using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuickNetChat.DataRepository.Entitys
{
    public class Message : EntityBase
    {
        /// <summary>
        /// The Message Text
        /// </summary>
        [Required]
        public string Text { get; set; }

        // The Autho of the message
        [Required]
        public User Author { get; set; }

        public ICollection<Media> Media { get; set; }
    }
}
