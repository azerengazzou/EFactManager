using System.ComponentModel.DataAnnotations;

namespace EFactManagerAPI.Models.Dto.FieldsDTO
{
    public class FieldCreateDTO
    {
        [Required]
        public int messageId { get; set; }
        [Required]
        public int recordId { get; set; }
        [Required]
        public int zoneContentId { get; set; }
        [Required]
        public int zoneId { get; set; }
    }
}
