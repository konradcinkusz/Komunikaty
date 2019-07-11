using Komunikaty.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Komunikaty.RepozytoriumStatyczne
{
    public class MessageStaticContext : IMessages
    {
        private class Message : IMessage
        {
            public Message()
            {

            }
            public Message(IMessage message)
            {
                this.Id = message.Id;
                this.ConfirmationRequired = message.ConfirmationRequired;
                this.Confirmed = message.Confirmed;
                this.Favourite = message.Favourite;
                this.MessageType = message.MessageType;
                this.Content = message.Content;
            }
            public int Id { get; set; }
            public bool ConfirmationRequired { get; set; }
            public bool Confirmed { get; set; }
            public bool Favourite { get; set; }
            public MessageType MessageType { get; set; } 
            public string Content { get; set; } 
        }
        private readonly static List<IMessage> messages = new List<IMessage>();
        public MessageStaticContext()
        {
            messages.Add(new Message
            {
                Id = 1,
                MessageType = MessageType.Warning,
                Content = "Test sprawdzający z matematyki nie odbędzie się"
            });
            messages.Add(new Message
            {
                Id = 2,
                MessageType = MessageType.Error,
                Content = "Z powodu braku zasilania odwołane lekcje",
                ConfirmationRequired = true,
                Confirmed = false
            });
            messages.Add(new Message
            {
                Id = 3,
                MessageType = MessageType.Information,
                Content = "Lekcję skrócone o 15 minut",
                ConfirmationRequired = true,
                Confirmed = false
            });
            messages.Add(new Message
            {
                Id = 4,
                MessageType = MessageType.None,
                Content = "Komunikat testowy",
            });
            messages.Add(new Message
            {
                Id = 5,
                MessageType = MessageType.None,
                Content = "Dziś dzień nauczyciela",
                Favourite = true
            });
        }
        public List<IMessage> GetAllMessage()
        {
            return messages.ToList();
        }

        public IMessage GetMessage(int messageId)
        {
            return messages.Single(message => message.Id == messageId);
        }

        public void SaveMessage(IMessage message)
        {
            messages.Add(new Message(message));
        }
    }
}
