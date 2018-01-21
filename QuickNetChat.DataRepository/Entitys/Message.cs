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

        /// <summary>
        /// The Autho of the message
        /// </summary>
        [Required]
        public User Author { get; set; }

        // The Autho of the message
        public int ChannelID { get; set; }
        [ForeignKey("ChannelID")]// Message.Channel = Channel.ID
        public Channel Channel { get; set; }


        //   public ICollection<Media> Media { get; set; }
    }
}
