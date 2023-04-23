using AutoMapper;
using EFactManagerAPI.Models;
using EFactManagerAPI.Models.Dto.FilesDTO;
using EFactManagerAPI.Repository;
using EFactManagerAPI.Repository.IRepository;
using EFactManagerAPI.Services.IServices;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;
using System.IO;

namespace EFactManagerAPI.Controllers
{
    [Route("api/FileAPI")]
    [ApiController]
    public class FileController : ControllerBase
    {
        private readonly IFileRepository _dbFile;
        private readonly IMapper _mapper;
        private readonly IFileService _fileService;

        public FileController(IFileRepository dbFile,IMapper mapper, IFileService fileService)
        {
            _dbFile = dbFile;
            _mapper = mapper;
            _fileService = fileService;

        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<FileDTO>>> GetFiles()
        {
            IEnumerable<EfactFile> fileList = await _dbFile.GetAllAsync();
            return Ok(_mapper.Map<List<FileDTO>>(fileList));
        }

        [HttpGet("{id:int}", Name ="GetFile")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<FileDTO>> GetFile(int id)
        {

            if (id == 0)
            {
                return BadRequest();
            }
            var file = await _dbFile.GetFileById(id);

            if (file == null)
            {
                return NotFound();
            }
            var fileEntityToDisplay=_mapper.Map<FileDTO>(file);
            return Ok(fileEntityToDisplay);
        }


        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> CreateFile(IFormFile fileuploaded)
        {
            //// Vérifiez si le fichier est vide ou non
            if (fileuploaded == null || fileuploaded.Length == 0)
                return BadRequest("Le fichier est vide");

            // Vérifiez si le fichier est au format texte
            if (fileuploaded.ContentType != "text/plain") 
                return BadRequest("Le fichier doit être au format texte");
            try
            {
                // Traitez le fichier ici
                var model = await _fileService.CreateFileService(fileuploaded);
                var fileEntityToDisplay = _mapper.Map<FileDTO>(model);
                return CreatedAtRoute("GetFile", new { id = model.id }, fileEntityToDisplay);
            }
            catch (Exception ex)
            {
                // Gérez les erreurs ici
                return StatusCode(500, $"Une erreur s'est produite :\n {ex.Message}");
            }
        }

        [HttpDelete("{id:int}", Name = "DeleteFile")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> DeleteFile(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            var file = await _dbFile.GetAsync(x => x.id == id);

            if (file == null)
            {
                return NotFound();
            }
            await _dbFile.RemoveAsync(file);
            await _dbFile.Save();
            return NoContent();

        }

        [HttpPut("{id:int}", Name = "UpdateFile")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> UpdateFile([FromBody] FileUpdateDTO fileUpdateDTO, int id)
        {
            if (fileUpdateDTO == null || id != fileUpdateDTO.id)
            {
                return BadRequest();
            }

            EfactFile model = _mapper.Map<EfactFile>(fileUpdateDTO);
            await _dbFile.UpdateAsync(model);
            await _dbFile.Save();
            return NoContent();
        }

        [HttpPatch("{id:int}", Name = "UpdateFilePartial")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdatePartialVilla(int id, JsonPatchDocument<FileUpdateDTO> patchDTO)
        {
            if (patchDTO == null || id == 0)
            {
                return BadRequest();
            }
            var file = await _dbFile.GetAsync(x => x.id == id, tracked: false);
            FileUpdateDTO filetopatch = _mapper.Map<FileUpdateDTO>(file);

            if (file == null)
            {
                return BadRequest();
            }
            patchDTO.ApplyTo(filetopatch, ModelState);

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            EfactFile villatodb = _mapper.Map<EfactFile>(filetopatch);
            await _dbFile.UpdateAsync(villatodb);
            return NoContent();
        }
    }
}
