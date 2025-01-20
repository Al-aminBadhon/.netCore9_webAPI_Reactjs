using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using MyApp.Application.Commands;
using MyApp.Application.Queries;
using MyApp.Core.Entities;

namespace MyApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController(ISender sender) : ControllerBase
    {
        [HttpPost("")]
        public async Task<IActionResult> AddUser([FromBody] Users user)
        {
            var result = await sender.Send(new AddUserCommand(user));
            return Ok(result);
        }

        [HttpGet("users")]
        public async Task<IActionResult> GetAllUsers()
        {
            var allUser = await sender.Send(new GetAllUsersQuery());
            return Ok(allUser);
        }
        
        [HttpGet("users/{userId}")]
        public async Task<IActionResult> GetUserById([FromRoute] int userId)
        {
            var user = await sender.Send(new GetUserByIdQuery(userId));
            return Ok(user);
        }
        
        [HttpPut("updateUser/{userId}")]
        public async Task<IActionResult> UpdateUser([FromRoute] int userId,[FromBody] Users user)
        {
            // calling to (App.Application) Command
            var result = await sender.Send(new UpdateUserCommand(userId, user));
            return Ok(result);
        }
        [HttpDelete("deleteUser/{userId}")]
        public async Task<IActionResult> DeleteUser([FromRoute] int userId)
        {
            var result = await sender.Send(new DeleteUserCommand(userId));
            return Ok(result);
        }
    }
}
