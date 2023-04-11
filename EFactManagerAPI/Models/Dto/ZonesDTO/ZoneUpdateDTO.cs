using System.ComponentModel.DataAnnotations;

namespace EFactManagerAPI.Models.Dto.ZonesDTO
{
    public class ZoneUpdateDTO
    {
        [Required]
        public int id { get; set; }
        public string zoneNumber { get; set; }
        public int zonelength { get; set; }
        public int startPosition { get; set; }
        public bool isError { get; set; }
        public string zoneType { get; set; }
        public string description { get; set; }
    }
}
