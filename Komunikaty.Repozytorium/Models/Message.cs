using Komunikaty.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace Komunikaty.Repozytorium
{
    public class Message : IMessage
    {
        public Message()
        {

        }
        public Message(IMessage message)
        {
            this.ConfirmationRequired = message.ConfirmationRequired;
            this.Confirmed = message.Confirmed;
            this.Favourite = message.Favourite;
            this.MessageType = message.MessageType;
            this.Content = message.Content;
        }
        public int Id { get; set; }
        /// <summary>
        /// Czy wymagane potwierdzenie, domyślnie nie
        /// </summary>
        public bool ConfirmationRequired { get; set; } = false;
        /// <summary>
        /// Czy potwierdzono, domyślnie tak, ponieważ nie wymagamy domyślnie potwierdzania
        /// </summary>
        public bool Confirmed { get; set; } = true;
        /// <summary>
        /// Czy ulubione, domyślnie nie
        /// </summary>
        public bool Favourite { get; set; } = false;
        /// <summary>
        /// Jaki jest typ wiadomości, z tym polem sparowany jest od razu obrazek
        /// </summary>
        public MessageType MessageType { get; set; } = MessageType.None;
        /// <summary>
        /// Treść wiadomości
        /// </summary>
        [MaxLength(255)]
        public string Content { get; set; }
    }
}
