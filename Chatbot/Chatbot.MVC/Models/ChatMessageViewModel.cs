using static System.Net.Mime.MediaTypeNames;

namespace Chatbot.MVC.Models
{
    public class ChatMessageViewModel
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid SessionId { get; set; }
        public string Sender { get; set; }
        public string Message { get; set; }
        public bool IsApproved { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime Timestamp { get; set; }
        //public ChatMessageViewModel(string message, string sender)
        //{
        //    Message = message;
        //    Sender = sender;
        //}
    }
}
