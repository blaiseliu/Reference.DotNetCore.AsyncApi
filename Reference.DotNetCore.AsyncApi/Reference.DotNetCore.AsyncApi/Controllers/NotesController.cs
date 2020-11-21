using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Reference.DotNetCore.AsyncApi.Repositories;

namespace Reference.DotNetCore.AsyncApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NotesController:ControllerBase
    {
        private readonly ILogger<NotesController> _logger;
        private readonly INoteRepository _repository;

        public NotesController(ILogger<NotesController> logger, INoteRepository repository)
        {
            _logger = logger;
            _repository = repository;
        }

        [HttpGet]
        [Route("")]
        public async Task<IActionResult> Get()
        {
            var entities=await _repository.GetAllAsync();
            return Ok(entities);
        }
        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var entity= await _repository.FindAsync(id);
            if (entity == null) return NotFound();
            return Ok(entity);
        }
    }
}
