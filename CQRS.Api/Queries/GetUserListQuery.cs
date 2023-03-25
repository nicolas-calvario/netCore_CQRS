using CQRS.Api.Models;
using MediatR;

namespace CQRS.Api.Queries
{
    public class GetUserListQuery: IRequest<List<User>>
    {

    }
}
