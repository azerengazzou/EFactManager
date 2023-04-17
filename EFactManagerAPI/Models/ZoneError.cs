using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EFactManagerAPI.Models
{
    public class ZoneError
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int id { get; set; }
        [Required]
        public string codeError { get; set; }
        public string descriptionError { get; set; }
        public DateTime dateCreation { get; set; }
        public DateTime dateUpdate { get; set; }
        public int ZoneConfigId { get; set; }
        public ZoneConfig ZoneConfig { get; set; }
    }
}
