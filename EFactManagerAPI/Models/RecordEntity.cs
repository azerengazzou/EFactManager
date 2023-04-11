using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace EFactManagerAPI.Models
{
    public class RecordEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int id { get; set; }
        [Required]
        public string recordType { get; set; }
        public string? description { get; set; }
        public int recordLength { get; set; }
        public string recordPlacement { get;set; } //header-body-footer
        public DateTime dateCreation { get; set; }
        public DateTime dateUpdate { get; set; }

        public ICollection<FieldEntity> Fields { get; set; }

    }
}
