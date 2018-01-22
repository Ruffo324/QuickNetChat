using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuickNetChat.DataRepository.Entitys
{
    /// <summary>
    /// Base class als parent for other entitys
    /// </summary>
    public class EntityBase
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [Required]
        [Column("ID", Order = 0)]
        public int ID { get; set; }
    }
}
