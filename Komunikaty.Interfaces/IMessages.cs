using System.Collections.Generic;

namespace Komunikaty.Interfaces
{
    public interface IMessages
    {
        void SaveMessage(IMessage message);
        IMessage GetMessage(int messageId);
        List<IMessage> GetAllMessage();
    }
}