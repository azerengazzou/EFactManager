using System.ComponentModel.DataAnnotations;

namespace EFactManagerAPI.Models.Dto.RecordsDTO
{
    public class RecordCreateDTO
    {
        [Required]
        public string recordNumber { get; set; }
        public string? description { get; set; }
        public int recordLength { get; set; }
        public string recordPlacement { get; set; } //header-body-footer
        public int MessageTypeId { get; set; }

    }
}
