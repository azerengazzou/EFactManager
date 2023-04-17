using AutoMapper;
using EFactManagerAPI.Models;
using EFactManagerAPI.Models.Dto.FieldsDTO;
using EFactManagerAPI.Models.Dto.FilesDTO;
using EFactManagerAPI.Models.Dto.MessagesDTO;
using EFactManagerAPI.Models.Dto.RecordsDTO;
using EFactManagerAPI.Models.Dto.ZonesContentDTO;
using EFactManagerAPI.Models.Dto.ZonesDTO;

namespace EFactManagerAPI
{
    public class MappingConfig : Profile
    {
        public MappingConfig() {
            CreateMap<EfactFile, FileDTO>().ReverseMap();
            CreateMap<EfactFile, FileUpdateDTO>().ReverseMap();
            CreateMap<EfactFile, FileCreateDTO>().ReverseMap();

            CreateMap<MessageType, MessageDTO>().ReverseMap();
            CreateMap<MessageType, MessageCreateDTO>().ReverseMap();

            CreateMap<RecordConfig, RecordDTO>().ReverseMap();
            CreateMap<RecordConfig, RecordCreateDTO>().ReverseMap();

            CreateMap<ZoneConfig, ZoneDTO>().ReverseMap();
            CreateMap<ZoneConfig, ZoneCreateDTO>().ReverseMap();
            CreateMap<ZoneConfig, ZoneUpdateDTO>().ReverseMap();

            CreateMap<ZoneContent, ZoneContentDTO>().ReverseMap();
            CreateMap<ZoneContent, ZoneContentCreateDTO>().ReverseMap();

            CreateMap<Field, FieldDTO>().ReverseMap();
            CreateMap<Field, FieldCreateDTO>().ReverseMap();

        }
    }
}
