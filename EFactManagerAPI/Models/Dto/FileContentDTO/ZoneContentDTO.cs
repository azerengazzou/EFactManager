using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EFactManagerAPI.Models.Dto.ZonesContentDTO
{
    public class ZoneContentDTO
    {
        [Required]
        public int id { get; set; }
        public string content { get; set; }
        public string description { get; set; }
    }
}
