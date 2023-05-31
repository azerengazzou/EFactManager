using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace EFactManagerAPI.Models
{
    public class ZoneError
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int id { get; set; }

        [Required]
        public string codeError { get; set; }
        public string descriptionError { get; set; }
        public string MAJ { get; set; }
        public string typeModification {get;set;}
        public string natureErreur { get; set; }
        public DateTime dateCreation { get; set; }
        public DateTime dateUpdate { get; set; }

        [JsonIgnore]
        public List<Field>? Fields { get; set; }
    }
}
