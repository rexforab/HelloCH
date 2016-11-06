using HelloEntities;
using HelloRepository.Interfaces;
using HelloService.Interfaces;

namespace HelloService.Services
{
    public class MessageService : IMessageService
    {
        public readonly IMessageRepository _messageRepository;

        public MessageService(IMessageRepository messageRepository)
        {
            _messageRepository = messageRepository;
        }

        public string GetMessageText(int id)
        {
            return _messageRepository.GetMessageById(id).HelloMessage;
        }
    }
}
