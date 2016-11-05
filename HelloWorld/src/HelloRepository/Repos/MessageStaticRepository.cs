using HelloEntities;
using HelloRepository.Interfaces;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloRepository
{
    public class MessageStaticRepository : IMessageRepository
    {
        private static List<Message> _messages = new List<Message>();

        public MessageStaticRepository()
        {
            Add(new Message() {Id = 1, HelloMessage = "Hello World" });
        }

        public void Add(Message item)
        {
            _messages.Add(item);
        }
        
        public List<Message> GetAllMessages()
        {
            return _messages;
        }

        public Message GetMessageById(int id)
        {
            return _messages.FirstOrDefault(x => x.Id == id);
        }
    }
}
