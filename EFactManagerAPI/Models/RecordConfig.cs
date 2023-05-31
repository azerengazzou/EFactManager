using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace EFactManagerAPI.Models
{
    public class RecordConfig
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int id { get; set; }
        [Required]
        public string recordNumber { get; set; }
        public string? description { get; set; }
        public int recordLength { get; set; }
        public string recordPlacement { get; set; } //header-body-footer
        public DateTime dateCreation { get; set; }
        public DateTime dateUpdate { get; set; }
        public int MessageTypeId { get; set; }
        public MessageType MessageType { get; set; }
        public List<ZoneConfig> ZoneConfigs { get; set; }
    }
}
