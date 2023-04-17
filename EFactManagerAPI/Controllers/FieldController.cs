using AutoMapper;
using EFactManagerAPI.Models.Dto.MessagesDTO;
using EFactManagerAPI.Models;
using EFactManagerAPI.Repository.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using EFactManagerAPI.Models.Dto.FieldsDTO;
using Microsoft.VisualBasic;

namespace EFactManagerAPI.Controllers
{
    [Route("api/FieldAPI")]
    [ApiController]
    public class FieldController : ControllerBase
    {
        private readonly IFieldRepository _dbfield;
        private readonly IMessageRepository _dbmessage;
        private readonly IRecordRepository _dbrecord;
        private readonly IZoneRepository _dbzone;
        private readonly IEfactFileContentRepository _dbzoneContent;
        private readonly IMapper _mapper;

        public FieldController(IFieldRepository dbfield,IMessageRepository dbmessage, IRecordRepository dbrecord, IZoneRepository dbzone, IEfactFileContentRepository dbzoneContent, IMapper mapper)
        {
            _dbfield = dbfield;
            _dbmessage = dbmessage;
            _dbrecord = dbrecord;
            _dbzone = dbzone;
            _dbzoneContent = dbzoneContent;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<FieldDTO>>> GetAllFields()
        {
            IEnumerable<Field> fieldList = await _dbfield.GetAllAsync();
            return Ok(_mapper.Map<List<FieldDTO>>(fieldList));
        }

        [HttpGet("{id:int}", Name = "GetFieldById")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<FieldDTO>> GetFieldById(int id)
        {
            var field = await _dbfield.GetAsync(x => x.id == id);

            if (field == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<FieldDTO>(field));
        }

        [HttpGet("GetAllFieldsByFileId")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<FieldDTO>>> GetAllFieldsByFileId(int fileId)
        {
            IEnumerable<Field> fieldList = await _dbfield.GetFieldsByFileId(fileId);
            return Ok(_mapper.Map<List<FieldDTO>>(fieldList));
        }

        //[HttpGet("GetFieldsByMessageID")]
        //[ProducesResponseType(StatusCodes.Status200OK)]
        //public async Task<ActionResult<IEnumerable<FieldDTO>>> GetFieldsByMessageID(int messageID)
        //{
        //    IEnumerable<Field> fieldList = await _dbfield.GetAllFieldsWithMessageID(messageID);
        //    return Ok(_mapper.Map<List<FieldDTO>>(fieldList));
        //}

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> CreateField([FromBody] FieldCreateDTO fieldCreateDTO)
        {
            if (fieldCreateDTO == null)
            {
                return BadRequest();
            }
            Field field = _mapper.Map<Field>(fieldCreateDTO);
            await _dbfield.CreateAsync(field);
            return CreatedAtRoute("GetMessageById", new { id = field.id }, field);
        }
    }
}
