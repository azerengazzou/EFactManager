using AutoMapper;
using EFactManagerAPI.Models.Dto.MessagesDTO;
using EFactManagerAPI.Models;
using EFactManagerAPI.Repository.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using EFactManagerAPI.Models.Dto.FieldsDTO;
using Microsoft.VisualBasic;
using Microsoft.Extensions.Caching.Memory;

namespace EFactManagerAPI.Controllers
{
    [Route("api/FieldAPI")]
    [ApiController]
    public class FieldController : ControllerBase
    {

        private readonly IFieldRepository _dbfield;
        private readonly IMapper _mapper;

        public FieldController(IFieldRepository dbfield,IMapper mapper)
        {
            _dbfield = dbfield;
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
        [ResponseCache(Duration = 500)]
        public async Task<ActionResult<IEnumerable<FieldDTO>>> GetAllFieldsByFileId(int fileId, int pageNumber, int pageSize)
        {

            var fields = await _dbfield.GetFieldsByFileId(fileId);
            var fieldsPage = fields.Skip((pageNumber - 1) * pageSize).Take(pageSize);
            var fieldsDTO = _mapper.Map<List<FieldDTO>>(fieldsPage);
            return Ok(fieldsDTO);
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
