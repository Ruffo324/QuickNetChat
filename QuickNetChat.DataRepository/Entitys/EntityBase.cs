using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        [Column("Id", Order = 0)]
        public int Id { get; set; }
    }
}
