using System.ComponentModel.DataAnnotations;

namespace EFactManagerAPI.Models.Dto.FieldsDTO
{
    public class FieldDTO
    {
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
