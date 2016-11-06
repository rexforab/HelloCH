using Microsoft.AspNetCore.Mvc;
using HelloService.Interfaces;

namespace HelloWorld.Controllers
{
    [Route("api/[controller]")]
    public class HelloController : Controller
    {
        private readonly IMessageService _messageService;

        public HelloController(IMessageService messageService)
        {
            _messageService = messageService;
        }

        // GET api/hello
        [HttpGet]
        public string Get()
        {
            return _messageService.GetMessageText(1);
        }
        
    }
}
