using CQRS.Api.Commands;
using CQRS.Api.Models;
using CQRS.Api.Repository;
using MediatR;

namespace CQRS.Api.Handlers
{
    public class DeleteUserHandler: IRequestHandler<DeletedUserCommand, long>
    {
        private readonly IUserRepository _userRepository;
        public DeleteUserHandler( IUserRepository userRepository) 
        {
            _userRepository = userRepository;   
        }

        public async Task<long> Handle(DeletedUserCommand request, CancellationToken cancellationToken)
        {
            User user = await _userRepository.GetUserByIdAsync(request.Id);
            if (user == null)
            {
                return default;
            }
            return await _userRepository.DeleteUserAsync(user.Id);

        }
    }
}
