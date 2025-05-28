using Chatbot.MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;

namespace Chatbot.MVC.Controllers.Message
{
    public class MessageController : Controller
    {
        private readonly HttpClient _httpClient;
        public MessageController(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        [HttpGet]
        public async Task<IActionResult>  Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SendMessage(ChatMessageViewModel model)
        {
            var result = await _httpClient.GetAsync("https://localhost:7144//api/chat/send");
            var json = await result.Content.ReadAsStringAsync();
            var data = JsonConvert.DeserializeObject<ChatMessageViewModel>(json);
            return View(data);
        }
    }
}
