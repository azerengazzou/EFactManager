using AutoMapper;
using EFactManagerAPI.Models.Dto.RecordsDTO;
using EFactManagerAPI.Models;
using EFactManagerAPI.Repository.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using EFactManagerAPI.Models.Dto.ZonesDTO;

namespace EFactManagerAPI.Controllers
{
    [Route("api/ZoneAPI")]
    [ApiController]
    public class ZoneController : ControllerBase
    {
        private readonly IZoneRepository _dbzones;
        private readonly IMapper _mapper;

        public ZoneController(IZoneRepository dbzone, IMapper mapper)
        {
            _dbzones = dbzone;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<ZoneDTO>>> GetZones()
        {
            IEnumerable<ZoneConfig> zonesList = await _dbzones.GetAllAsync();
            return Ok(_mapper.Map<List<ZoneDTO>>(zonesList));
        }

        [HttpGet("{id:int}", Name = "GetZone")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<ZoneDTO>> GetZone(int id)
        {
            var record = await _dbzones.GetAsync(x => x.id == id);

            if (record == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<ZoneDTO>(record));
        }

        [HttpGet("GetAllZonesByRecordId")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAllZonesByRecordId(int recId)
        {
            // Get all records with related zones from the repository
            var zonesByrecordId = await _dbzones.GetZonesByRecordIdAsync(recId);

            // Return the records with related zones in the response
            return Ok(zonesByrecordId);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> CreateZone(ZoneCreateDTO zoneCreateDTO)
        {
            //if ((await _dbzones.GetAsync(u => u.zoneNumber == zoneCreateDTO.zoneNumber) != null) && (await _dbzones.GetAsync(u => u.RecordId == zoneCreateDTO.RecordId)!=null))
            //{
            //    ModelState.AddModelError("CustomError", "Zone already exist!");
            //    return BadRequest(ModelState);
            //}

            if (zoneCreateDTO == null)
            {
                return BadRequest();
            }
            ZoneConfig zone = _mapper.Map<ZoneConfig>(zoneCreateDTO);
            await _dbzones.CreateAsync(zone);
            return CreatedAtRoute("GetRecord", new { id = zone.id }, zone);
        }


        [HttpDelete("{id:int}", Name = "DeleteZone")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> DeleteZone(int id)
        {
            var zone = await _dbzones.GetAsync(x => x.id == id);

            if (zone == null)
            {
                return NotFound(zone);
            }
            await _dbzones.RemoveAsync(zone);
            await _dbzones.Save();
            return Ok();
        }
    }
}
