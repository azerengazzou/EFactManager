using EFactManagerAPI.Models.Dto.ZonesDTO;
using System.ComponentModel.DataAnnotations;

namespace EFactManagerAPI.Models.Dto.FieldsDTO
{
    public class FieldDTO
    {
        [Required]
        public int id { get; set; }
        public int FileId { get; set; }
        public EfactFile File { get; set; }
        public int ZoneConfigId { get; set; }
        public ZoneDTO ZoneConfig { get; set; }
    }
}
