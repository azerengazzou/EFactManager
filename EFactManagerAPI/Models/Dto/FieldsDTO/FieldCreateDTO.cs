﻿using EFactManagerAPI.Models.Dto.ZonesContentDTO;
using System.ComponentModel.DataAnnotations;

namespace EFactManagerAPI.Models.Dto.FieldsDTO
{
    public class FieldCreateDTO
    {
        [Required]
        public int id { get; set; }
        public int FileId { get; set; }
        public EfactFile File { get; set; }

        public int ZoneConfigId { get; set; }
        public ZoneConfig ZoneConfig { get; set; }
        public ZoneContentCreateDTO ZoneContent { get; set; }
    }
}
