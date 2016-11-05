using HelloService.Interfaces;

namespace HelloService.Services
{
    public class MessageService : IMessageService
    {
        public string GetHello()
        {
            return "Hello World";
        }
    }
}
