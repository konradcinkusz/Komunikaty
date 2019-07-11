using Komunikaty.Interfaces;
using System.Windows.Forms;

namespace Komunikaty
{
    public partial class SendWindow : Form
    {
        private IMessages messagesDataAccess;
        private class MessageTypeMapping
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
        public SendWindow(IMessages messagesDataAccess)
        {
            this.messagesDataAccess = messagesDataAccess;
            InitializeComponent();
            foreach (IMessage message in messagesDataAccess.GetAllMessage())
            {
                string[] row = { message.Content, new MessageTypeMapping(message.MessageType).ToString()};
                var listViewItem = new ListViewItem(row);
                MessagesListView.Items.Add(listViewItem);
                if (message.Favourite)
                {

                }
            }
        }
    }
}
