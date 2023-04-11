using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EFactManagerAPI.Models
{
    public class MessageEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int id { get; set; }

        [Required]
        public string messageCode { get; set; } //exp: 920000
        [Required]
        public string description { get; set; } //exp: Fiche de facturation réception
        public DateTime dateCreation { get; set; }
        public DateTime dateUpdate { get; set; }

        public ICollection<FieldEntity> Fields { get; set; }

    }
}
