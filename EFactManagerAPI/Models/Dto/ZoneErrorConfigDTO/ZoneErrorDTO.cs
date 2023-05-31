using System.ComponentModel.DataAnnotations;

namespace EFactManagerAPI.Models.Dto.ZoneErrorDTO
{
    public class ZoneErrorDTO
    {
        public int id { get; set; }
        public string codeError { get; set; }
        public string descriptionError { get; set; }
        public string MAJ { get; set; }
        public string typeModification { get; set; }
        public string natureErreur { get; set; }
    }
}
