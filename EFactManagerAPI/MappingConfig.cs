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
            CreateMap<FileEntity, FileDTO>().ReverseMap();
            CreateMap<FileEntity, FileUpdateDTO>().ReverseMap();
            CreateMap<FileEntity, FileCreateDTO>().ReverseMap();

            CreateMap<MessageEntity, MessageDTO>().ReverseMap();
            CreateMap<MessageEntity, MessageCreateDTO>().ReverseMap();

            CreateMap<RecordEntity, RecordDTO>().ReverseMap();
            CreateMap<RecordEntity, RecordCreateDTO>().ReverseMap();

            CreateMap<ZoneEntity, ZoneDTO>().ReverseMap();
            CreateMap<ZoneEntity, ZoneCreateDTO>().ReverseMap();
            CreateMap<ZoneEntity, ZoneUpdateDTO>().ReverseMap();

            CreateMap<ZoneContentEntity, ZoneContentDTO>().ReverseMap();
            CreateMap<ZoneContentEntity, ZoneContentCreateDTO>().ReverseMap();

            CreateMap<FieldEntity, FieldDTO>().ReverseMap();
            CreateMap<FieldEntity, FieldCreateDTO>().ReverseMap();
        }
    }
}
