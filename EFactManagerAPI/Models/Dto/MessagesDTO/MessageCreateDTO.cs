﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EFactManagerAPI.Models.Dto.MessagesDTO
{
    public class MessageCreateDTO
    {
        [Required]
        public string messageCode { get; set; } //exp: 920000
        [Required]
        public string description { get; set; } //exp: Fiche de facturation réception
        public DateTime dateCreation { get; set; }
        public DateTime dateUpdate { get; set; }

        public MessageCreateDTO()
        {
            dateCreation = DateTime.UtcNow;
            dateUpdate = DateTime.UtcNow;
        }
    }
}
