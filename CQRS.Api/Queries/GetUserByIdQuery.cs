using CQRS.Api.Models;
using MediatR;

namespace CQRS.Api.Queries
{
    public class GetUserByIdQuery : IRequest<User>
    {
        public long Id { get; set; }
    }
}
