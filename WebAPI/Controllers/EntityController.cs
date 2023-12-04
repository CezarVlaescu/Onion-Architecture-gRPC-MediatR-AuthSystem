using MediatR;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Dtos;

namespace WebAPI.Controllers
{
    // Api controller for entity operations
    [ApiController]
    [Route("[controller]")]
    public class EntityController : ControllerBase
    {
        private readonly IMediator _mediator;

        public EntityController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // Define the endpoint here using _mediator to send commands/queries

        [HttpPost]

        public async Task<ActionResult<EntityDto>> CreateEntity(CreateEntityCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        /*[HttpGet]
        [Route("createEntity")]
        public async Task<ActionResult<EntityDto>> CreateEntity(CreateEntityCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }*/
    }
}
