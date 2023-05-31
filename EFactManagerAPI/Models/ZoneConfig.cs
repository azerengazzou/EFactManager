using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EFactManagerAPI.Models
{
    public class ZoneConfig
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int id { get; set; }
        [Required]
        public string zoneNumber { get; set; }

        [Required]
        public int zonelength { get; set; }
        [Required]
        public int startPosition { get; set; }
        public string zoneType { get; set; }
        public string description { get; set; }
        public DateTime dateCreation { get; set; }
        public DateTime dateUpdate { get; set; }

        public int RecordConfigId { get; set; }
        public RecordConfig RecordConfig { get; set; }
        public List<Field> Fields { get; set; }

    }
}
