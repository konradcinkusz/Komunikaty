using System.Windows.Forms;
using Komunikaty.Interfaces;

namespace Komunikaty.ReceiverStatyczny
{
    public class Receiver : IReceiver
    {
        public void SendMessage(IMessage message)
        {
            MessageBox.Show("Odebrano wiadomość!"+message.Content);
        }
    }
}
