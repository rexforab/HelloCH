using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
            return _messageService.GetMessage(1).HelloMessage;
        }
        
    }
}
