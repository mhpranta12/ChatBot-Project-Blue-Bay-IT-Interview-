using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chatbot.Domain.Core.Entities.Messages
{
    public class Message
    {
        public Guid Id { get; set; }
        public string Text { get; set; }
        public string? ContentURL { get; set; }
        public Guid UserId { get; set; }
        public Message(string text, string contentUrl)
        {
            Text = text;
            ContentURL = contentUrl;
        }
    }
}
