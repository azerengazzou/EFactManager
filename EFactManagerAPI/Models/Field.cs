using EFactManagerAPI.Models.Dto.ZonesContentDTO;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFactManagerAPI.Models
{
    public class Field
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int id { get; set; }

        public int? numAttestation { get; set; }
        public int? numPrestation { get; set; }
        public int FileId { get; set; }
        public EfactFile File { get; set; }

        public int ZoneConfigId { get; set; }
        public ZoneConfig ZoneConfig { get; set; }

        public ZoneContent ZoneContent { get; set; }
    }
}
