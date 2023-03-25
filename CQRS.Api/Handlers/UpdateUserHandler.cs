using CQRS.Api.Commands;
using CQRS.Api.Models;
using CQRS.Api.Repository;
using MediatR;

namespace CQRS.Api.Handlers
{
    public class UpdateUserHandler: IRequestHandler<UpdateUserCommand, long>
    {
        private readonly IUserRepository _userRepository;
 
        public UpdateUserHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;   
        }

        public async Task<long> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
        {
            User userUpdate = await _userRepository.GetUserByIdAsync(request.Id);
            if (userUpdate == null)
                return default;
            
            userUpdate.Name= request.Name;
            userUpdate.Email= request.Email;
            userUpdate.Password= request.Password;
            userUpdate.Phone= request.Phone;

            return await _userRepository.UpdateUserAsync(userUpdate);
        }
    }
}
