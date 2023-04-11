using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EFactManagerAPI.Models
{
    public class ZoneContentEntity
    {
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string content { get; set; }
        public DateTime dateCreation { get; set; }
        public ICollection<FieldEntity> Fields { get; set; }
    }
}
