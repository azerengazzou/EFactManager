using System.ComponentModel.DataAnnotations;

namespace EFactManagerAPI.Models.Dto.ZonesDTO
{
    public class ZoneDTO
    {
        [Required]
        public int id { get; set; }
        [Required]
        public string zoneNumber { get; set; }

        [Required]
        public int zonelength { get; set; }
        [Required]
        public int startPosition { get; set; }
        public bool isError { get; set; }
        public string zoneType { get; set; }
        public string description { get; set; }
        public DateTime dateCreation { get; set; }
        public DateTime dateUpdate { get; set; }
        public ICollection<FieldEntity> Fields { get; set; }
    }
}
