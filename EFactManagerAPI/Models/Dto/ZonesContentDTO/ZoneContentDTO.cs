using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EFactManagerAPI.Models.Dto.ZonesContentDTO
{
    public class ZoneContentDTO
    {
        [Required]
        public int id { get; set; }
        public string content { get; set; }
        public DateTime dateCreation { get; set; }
        public ICollection<FieldEntity> Fields { get; set; }
    }
}
