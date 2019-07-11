using Komunikaty.Interfaces;
using Komunikaty.Repozytorium.DataAccess;
using System.Collections.Generic;
using System.Data.Entity;
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

        public int GetLastId()
        {
            return messageContext.Messages.Last().Id;
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

        public void UpdateMessage(IMessage message)
        {
            var messageTemp = new Message { Id = message.Id };
            messageContext.Entry(messageTemp).State = EntityState.Deleted;
            messageContext.SaveChanges();
            SaveMessage(message);
        }
    }
}
