using System.ComponentModel.DataAnnotations;
using QuickNetChat.Data.DataRepository.Enums;

namespace QuickNetChat.Data.DataRepository.Entitys
{
    /// <summary>
    ///     Contains the transfered media.
    /// </summary>
    public class Media : EntityBase
    {
        /// <summary>
        ///     The message to this media
        /// </summary>
        [Required]
        public Message Message { get; set; }

        /// <summary>
        ///     The Media saved as Byte array
        /// </summary>
        [Required]
        public byte[] Value { get; set; }

        /// <summary>
        ///     Type of the media.
        /// </summary>
        [Required]
        public MediaType Type { get; set; }
    }
}