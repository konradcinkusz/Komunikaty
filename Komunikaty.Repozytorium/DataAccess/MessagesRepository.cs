using Komunikaty.Interfaces;
using Komunikaty.Repozytorium.DataAccess;
using System.Collections.Generic;
using System.Linq;

namespace Komunikaty.Repozytorium
{
    public class MessagesRepository : IMessages
    {
        private readonly MessageContext messageContext = new MessageContext();

        public List<IMessage> GetAllMessage()
        {
            return messageContext.Messages.ToList<IMessage>();
        }

        public IMessage GetMessage(int messageId)
        {
            return messageContext.Messages.Single(m=>m.Id == messageId);
        }

        public void SaveMessage(IMessage message)
        {
            messageContext.Messages.Add(new Message(message));
            messageContext.SaveChanges();
        }
    }
}
