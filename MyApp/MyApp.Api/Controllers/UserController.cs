using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyApp.Application.Commands;
using MyApp.Core.Entities;

namespace MyApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController(IMediator mediator) : ControllerBase
    {
        [HttpPost("")]
        public async Task<IActionResult> AddUser([FromBody] Users user)
        {
            var result = await mediator.Send(new AddUserCommand(user));
            return Ok(result);
        }
    }
}
