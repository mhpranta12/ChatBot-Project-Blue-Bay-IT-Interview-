using Chatbot.MVC.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Chatbot.MVC.Controllers.api
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChatController : ControllerBase
    {
        [HttpPost("send")]
        public IActionResult Send(ChatMessageViewModel request)
        {
            var data = new ChatMessageViewModel()
            {
                Id = Guid.Empty,
                Message = "OK",

            };
            return Ok(data);
        }
        [HttpGet("history")]
        public IActionResult History(ChatMessageViewModel request)
        {
            var data = "df";
            return Ok(data);
        }
        [HttpPost("update/{id}")]
        public IActionResult UpdateMessage(ChatMessageViewModel request)
        {
            var data = "df";
            return Ok(data);
        }
        [HttpPost("delete/{id}")]
        public IActionResult DeleteMessage(ChatMessageViewModel request)
        {
            var data = "df";
            return Ok(data);
        }
        [HttpPatch("/{id}/approve")]
        public IActionResult ApproveMessage(ChatMessageViewModel request)
        {
           var data = "df";
            return Ok(data);
        }
    }
}
