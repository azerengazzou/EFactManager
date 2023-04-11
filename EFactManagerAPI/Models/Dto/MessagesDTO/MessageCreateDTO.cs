using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EFactManagerAPI.Models.Dto.MessagesDTO
{
    public class MessageCreateDTO
    {
        [Required]
        public string messageCode { get; set; }
        [Required]
        public string description { get; set; }
    }
}
