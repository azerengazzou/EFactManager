using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using EFactManagerAPI.Models.Dto.FieldsDTO;

namespace EFactManagerAPI.Models.Dto.ZonesContentDTO
{
    public class ZoneContentCreateDTO
    {
        public string content { get; set; }
        public string description { get; set; }
        public int FieldId { get; set; }
        public FieldCreateDTO Field { get; set; }
    }
}
