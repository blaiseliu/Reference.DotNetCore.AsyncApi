using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Reference.DotNetCore.AsyncApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NotesController:ControllerBase
    {
        private readonly ILogger<NotesController> _logger;

        

        public NotesController(ILogger<NotesController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<string> Get()
        {
            return null;
        }
    }
}
