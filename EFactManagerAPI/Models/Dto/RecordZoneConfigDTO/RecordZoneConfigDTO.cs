namespace EFactManagerAPI.Models.Dto.RecordZoneConfigDTO
{
    public class RecordZoneConfigDTO
    {
        public int RecordConfigId { get; set; }
        public RecordConfig RecordConfig { get; set; }

        public int ZoneConfigId { get; set; }
        public ZoneConfig ZoneConfig { get; set; }
    }
}
