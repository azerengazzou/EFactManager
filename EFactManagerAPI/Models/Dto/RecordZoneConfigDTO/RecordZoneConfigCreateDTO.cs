using System.ComponentModel.DataAnnotations;

namespace EFactManagerAPI.Models.Dto.RecordZoneConfigDTO
{
    public class RecordZoneConfigCreateDTO
    {
        [Required]
        public int RecordConfigId { get; set; }

        [Required]
        public int ZoneConfigId { get; set; }
    }
}
