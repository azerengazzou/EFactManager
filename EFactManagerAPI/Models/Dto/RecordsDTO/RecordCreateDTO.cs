using System.ComponentModel.DataAnnotations;

namespace EFactManagerAPI.Models.Dto.RecordsDTO
{
    public class RecordCreateDTO
    {
        [Required]
        public string recordType { get; set; }
        public string? description { get; set; }
        public int recordLength { get; set; }
        public string recordPlacement { get; set; } //header-body-footer
        public DateTime dateCreation { get; set; }
        public DateTime dateUpdate { get; set; }

        public ICollection<FieldEntity> Fields { get; set; }
    }
}
