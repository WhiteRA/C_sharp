using Microsoft.AspNetCore.Mvc;
using MessageService.Services;
using MessageService.Dtos;
using System;
using Microsoft.AspNetCore.Authorization;

namespace MessageService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MessageController : ControllerBase
    {
        private readonly IMessageService _messageService;

        public MessageController(IMessageService messageService)
        {
            _messageService = messageService;
        }

        [HttpPost]
        public IActionResult SendMessage(MessageDto messageDto)
        {
            var result = _messageService.SendMessage(messageDto);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet]
        public IActionResult GetMessages(Guid userId)
        {
            var messages = _messageService.GetMessages(userId);
            return Ok(messages);
        }
    }
}

