using Komunikaty.Interfaces;

namespace Komunikaty.ViewModels
{
    /// <summary>
    /// Helper do wiadomości
    /// </summary>
    public class MessageTypeMapping
    {
        private readonly string communicate = "Brak";

        public MessageTypeMapping(MessageType messageType)
        {
            switch (messageType)
            {
                case MessageType.None:
                    communicate = "Brak";
                    break;
                case MessageType.Error:
                    communicate = "Błąd";
                    break;
                case MessageType.Warning:
                    communicate = "Ostrzeżenie";
                    break;
                case MessageType.Information:
                    communicate = "Informacja";
                    break;
                default:
                    communicate = "Błąd konwersji";
                    break;
            }
        }
        public override string ToString()
        {
            return communicate;
        }
    }
}
