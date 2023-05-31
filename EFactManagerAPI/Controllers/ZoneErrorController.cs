using AutoMapper;
using EFactManagerAPI.Models.Dto.FilesDTO;
using EFactManagerAPI.Models;
using EFactManagerAPI.Repository.IRepository;
using EFactManagerAPI.Services.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using EFactManagerAPI.Models.Dto.ZoneErrorDTO;
using NPOI.XSSF.UserModel;
using EFactManagerAPI.Models.Dto.MessagesDTO;

namespace EFactManagerAPI.Controllers
{
    [Route("api/ZoneErrorAPI")]
    [ApiController]
    public class ZoneErrorController : ControllerBase
    {
        private readonly IZoneErrorRepository _dbError;
        private readonly IMapper _mapper;

        public ZoneErrorController(IZoneErrorRepository dbError, IMapper mapper)
        {
            _dbError = dbError;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<ZoneErrorDTO>>> GetZonesError()
        {
            IEnumerable<ZoneError> errorsList = await _dbError.GetAllAsync();
            return Ok(_mapper.Map<List<ZoneErrorDTO>>(errorsList));
        }

        [HttpGet("{id:int}", Name = "GetZoneErrorById")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<ZoneErrorDTO>> GetZoneErrorById(int id)
        {

            if (id == 0)
            {
                return BadRequest();
            }
            var error = await _dbError.GetAsync(zr=>zr.id==id);

            if (error == null)
            {
                return NotFound();
            }
            var errorToDisplay = _mapper.Map<ZoneErrorDTO>(error);
            return Ok(errorToDisplay);
        }

        [HttpGet("GetErrorWithCode")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<ZoneErrorDTO>> GetErrorWithCode(string errorCode)
        {

            var error = await _dbError.GetErrorWithCode(errorCode);
            if (errorCode == null)
            {
                return BadRequest();
            }
            var errorToDisplay = _mapper.Map<ZoneErrorDTO>(error);
            return Ok(errorToDisplay);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> ErrorTranspose(IFormFile fileOfErrors)
        {
            try
            {
                if (fileOfErrors == null || fileOfErrors.Length == 0)
                    return BadRequest("Aucun fichier sélectionné.");

                var errors = new List<ZoneError>();

                using (var stream = fileOfErrors.OpenReadStream())
                {
                    var workbook = new XSSFWorkbook(stream);
                    var sheet = workbook.GetSheetAt(0);

                    for (int row = 1; row <= sheet.LastRowNum; row++)
                    {
                        var excelRow = sheet.GetRow(row);
                        if (excelRow == null)
                            continue;

                        var error = new ZoneErrorCreateDTO
                        {
                            codeError = excelRow.GetCell(3)?.ToString(),
                            descriptionError = excelRow.GetCell(5)?.ToString(),
                            MAJ = excelRow.GetCell(0)?.ToString(),
                            typeModification = excelRow.GetCell(1)?.ToString(),
                            natureErreur = excelRow.GetCell(2)?.ToString(),
                        };

                        ZoneError errorMapped = _mapper.Map<ZoneError>(error);
                        errors.Add(errorMapped);
                    }
                }
               
                await _dbError.AddErrorsFromFileAsync(errors);
                return Ok("Données transposées avec succès à partir du fichier Excel.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Erreur lors de la transposition des données à partir du fichier Excel : {ex.Message}");
            }
        }
    }
}
