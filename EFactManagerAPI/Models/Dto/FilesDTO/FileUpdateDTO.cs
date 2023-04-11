using System.ComponentModel.DataAnnotations;

namespace EFactManagerAPI.Models.Dto.FilesDTO
{
    public class FileUpdateDTO
    {
        [Required]
        public int id { get; set; }

        [Required]
        public string fileName { get; set; }
        public float size { get; set; }
        public string Description { get; set; }

    }
}
