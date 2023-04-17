using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFactManagerAPI.Models
{
    public class ZoneContent
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int id { get; set; }
        public string content { get; set; }
        public string description { get; set; }
        public int FieldId { get; set; }
        public Field Field { get; set; }

    }
}
