using Komunikaty.Interfaces;

namespace Komunikaty.ViewModels
{
    public class Message : IMessage
    {
        public Message(int Id)
        {
            this.Id = Id;
        }
        public int Id { get; set; }
        public bool ConfirmationRequired { get; set; }
        public bool Confirmed { get; set; }
        public bool Favourite { get; set; }
        public MessageType MessageType { get; set; }
        public string Content { get; set; }
    }

}
