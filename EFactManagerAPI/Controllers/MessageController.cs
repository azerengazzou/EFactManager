using AutoMapper;
using EFactManagerAPI.Models.Dto.FilesDTO;
using EFactManagerAPI.Models;
using EFactManagerAPI.Repository.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using EFactManagerAPI.Models.Dto.MessagesDTO;
using Azure;
using System.Net;
using EFactManagerAPI.Models.Dto.RecordsDTO;

namespace EFactManagerAPI.Controllers
{
    [Route("api/FileMessagesAPI")]
    [ApiController]
    public class MessageController : ControllerBase
    {
        private readonly IMessageRepository _dbmessage;
        private readonly IMapper _mapper;

        public MessageController(IMessageRepository dbmessage,IMapper mapper)
        {
            _dbmessage = dbmessage;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<MessageDTO>>> GetMessages()
        {
            IEnumerable<MessageType> messageList = await _dbmessage.GetAllAsync();
            return Ok(_mapper.Map<List<MessageDTO>>(messageList));
        }

        [HttpGet("GetMessagesAndRecords")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<MessageDTO>>> GetMessagesAndRecords()
        {
            IEnumerable<MessageType> messageList = await _dbmessage.GetAllMessagesAndRecordsAsync();
            return Ok(_mapper.Map<List<MessageDTO>>(messageList));
        }


        [HttpGet("{id:int}", Name = "GetMessageById")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<MessageDTO>> GetMessageById(int id)
        {
            var message = await _dbmessage.GetAsync(x => x.id == id);

            if (message == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<MessageDTO>(message));
        }



        [HttpGet("messages/bycode/{code}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<MessageDTO> GetMessageByMessageCode(string code)
        {
            if (code.Length!=6)
            {
                return BadRequest();
            }
            var message = _dbmessage.GetMessageByCode(code);

            if (message == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<MessageDTO>(message));
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> CreateMessage([FromBody] MessageCreateDTO messageCreateDTO)
        {
                if (await _dbmessage.GetAsync(u => u.messageCode.ToLower() == messageCreateDTO.messageCode.ToLower()) != null)
                {
                    ModelState.AddModelError("CustomError", "Message already exist!");
                    return BadRequest(ModelState);
                }
                if (messageCreateDTO == null)
                {
                    return BadRequest();
                }
                MessageType message = _mapper.Map<MessageType>(messageCreateDTO);
                await _dbmessage.CreateAsync(message);
                return CreatedAtRoute("GetMessageById", new { id = message.id }, message);
        }


        [HttpDelete("{id:int}", Name = "DeleteMessage")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> DeleteMessage(int id)
        {
            if (id == null)
                {
                    return BadRequest();
                }
                var message = await _dbmessage.GetAsync(x => x.id == id);

                if (message == null)
                {
                    return NotFound(message);
                }
                await _dbmessage.RemoveAsync(message);
                await _dbmessage.Save();
                return Ok();
        }

    }
}
