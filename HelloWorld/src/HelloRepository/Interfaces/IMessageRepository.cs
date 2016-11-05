using HelloEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloRepository.Interfaces
{
    public interface IMessageRepository
    {
        void Add(Message item);

        List<Message> GetAllMessages();

        Message GetMessageById(int id);
    }
}
