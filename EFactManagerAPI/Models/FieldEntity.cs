using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFactManagerAPI.Models
{
    public class FieldEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int id { get; set; }

        public int messageId { get; set; }
        public int recordId { get; set; }
        public int zoneContentId { get; set; }
        public int zoneId { get; set; }
        public MessageEntity Message { get; set; }
        public RecordEntity Record { get; set; }
        public ZoneEntity Zone { get; set; }
        public ZoneContentEntity ZoneContent { get; set; }
    }
}
