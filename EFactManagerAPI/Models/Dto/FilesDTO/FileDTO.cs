using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFactManagerAPI.Models.Dto.FilesDTO
{
    public class FileDTO
    {
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string fileName { get; set; }
        public float size { get; set; }
        public string Description { get; set; }
        public string fileUploadedContent { get; set; }
        public DateTime upload_date { get; set; }
        public DateTime update_date { get; set; }
    }
}
