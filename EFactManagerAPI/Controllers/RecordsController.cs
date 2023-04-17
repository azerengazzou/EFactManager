using AutoMapper;
using EFactManagerAPI.Models.Dto.MessagesDTO;
using EFactManagerAPI.Models;
using EFactManagerAPI.Repository.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using EFactManagerAPI.Models.Dto.RecordsDTO;
using EFactManagerAPI.Repository;

namespace EFactManagerAPI.Controllers
{
    [Route("api/RecordsAPI")]
    [ApiController]
    public class RecordsController : ControllerBase
    {
        private readonly IRecordRepository _dbrecord;
        private readonly IMapper _mapper;

        public RecordsController(IRecordRepository dbrecord, IMapper mapper)
        {
            _dbrecord = dbrecord;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<RecordDTO>>> GetRecords()
        {
            IEnumerable<RecordConfig> recordsList = await _dbrecord.GetAllAsync();
            return Ok(_mapper.Map<List<RecordDTO>>(recordsList));
        }

        //[HttpGet("GetAllRecordsByFieldId")]
        //[ProducesResponseType(StatusCodes.Status200OK)]
        //public async Task<IActionResult> GetAllRecordsByFieldId()
        //{
        //    // Get all records with related zones from the repository
        //    var recordsWithZones = await _dbrecord.GetAllRecordsWithZonesAsync();

        //    // Return the records with related zones in the response
        //    return Ok(recordsWithZones);
        //}

        //[HttpGet("GetRecordsbyMsgId")]
        //[ProducesResponseType(StatusCodes.Status200OK)]
        //public async Task<IActionResult> GetRecordsbyMsgId(int msgID)
        //{
        //    // Get all records with related zones from the repository
        //    var recordsBymsg = await _dbrecord.GetRecordsByMessageIdAsync(msgID);

        //    // Return the records with related zones in the response
        //    return Ok(recordsBymsg);
        //}

        [HttpGet("{id:int}", Name = "GetRecord")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<RecordDTO>> GetRecord(int id)
        {
            var record = await _dbrecord.GetAsync(x => x.id == id);

            if (record == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<RecordDTO>(record));
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> CreateMessage(RecordCreateDTO recordCreateDTO)
        {
            if (await _dbrecord.GetAsync(u => u.recordNumber.ToLower() == recordCreateDTO.recordNumber.ToLower()) != null)
            {
                ModelState.AddModelError("CustomError", "Record already exist!");
                return BadRequest(ModelState);
            }
            if (recordCreateDTO == null)
            {
                return BadRequest();
            }
            RecordConfig record = _mapper.Map<RecordConfig>(recordCreateDTO);
            await _dbrecord.CreateAsync(record);
            return CreatedAtRoute("GetRecord", new { id = record.id }, record);
        }


        [HttpDelete("{id:int}", Name = "DeleteRecord")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> DeleteRecord(int id)
        {
            var record = await _dbrecord.GetAsync(x => x.id == id);

            if (record == null)
            {
                return NotFound(record);
            }
            await _dbrecord.RemoveAsync(record);
            await _dbrecord.Save();
            return Ok();
        }

    }
}
