
using HelloEntities;

namespace HelloService.Interfaces
{
    public interface IMessageService
    {
        Message GetMessage(int id);
    }
}
