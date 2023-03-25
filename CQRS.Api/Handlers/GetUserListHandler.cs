using CQRS.Api.Models;
using CQRS.Api.Queries;
using CQRS.Api.Repository;
using MediatR;

namespace CQRS.Api.Handlers
{
    public class GetUserListHandler : IRequestHandler<GetUserListQuery, List<User>>
    {
        private readonly IUserRepository _userRepository;
        public GetUserListHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public async Task<List<User>> Handle(GetUserListQuery request, CancellationToken cancellationToken)
        {
            return await _userRepository.GetUserListAsync();
        }
    }
}
