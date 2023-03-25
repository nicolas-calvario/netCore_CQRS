using CQRS.Api.Commands;
using CQRS.Api.Models;
using CQRS.Api.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CQRS.Api.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UserController(IMediator mediator)
        {
            _mediator= mediator;
        }

        [HttpGet]
        public async Task<List<User>> GetListUsersAsync()
        {
            return await _mediator.Send(new GetUserListQuery());
        }

        [HttpGet("userId")]
        public async Task<User> GetUserbyIdAsync(long userId)
        {
            User user = await _mediator.Send(new GetUserByIdQuery() { Id= userId });
            return user;
        }

        [HttpPost]
        public async Task<User> AddUserAsync(User user)
        {
           return await _mediator.Send(new CreateUserCommand(user.Name, user.Email, user.Password, user.Phone));
        }

        [HttpPut]
        public async Task<long> UpdateUserAsync(User user)
        {
            return await _mediator.Send(new UpdateUserCommand(user.Id, user.Name, user.Email, user.Password, user.Phone));
        }

        [HttpDelete]
        public async Task<long> DeleteUserAsync(long Id)
        {
            return await _mediator.Send(new DeletedUserCommand() { Id = Id });
        }
      
    }
}
