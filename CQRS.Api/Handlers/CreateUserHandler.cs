using CQRS.Api.Commands;
using CQRS.Api.Models;
using CQRS.Api.Repository;
using MediatR;

namespace CQRS.Api.Handlers
{
    public class CreateUserHandler: IRequestHandler<CreateUserCommand, User>
    {
        private readonly IUserRepository _userRepository;
        public CreateUserHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;   
        }

        public async Task<User> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            User useNew = new User()
            {
                Name= request.Name,
                Email= request.Email,
                Password= request.Password,
                Phone= request.Phone,
            };
            return await _userRepository.AddUserAsync(useNew);
        }
    }
}
