using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EFactManagerAPI.Models.Dto.RecordsDTO
{
    public class RecordDTO
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int id { get; set; }
        public string recordType { get; set; }
        public string? description { get; set; }
        public int recordLength { get; set; }
        public string recordPlacement { get; set; } //header-body-footer

        public ICollection<FieldEntity> Fields { get; set; }
    }
}
