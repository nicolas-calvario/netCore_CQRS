using MediatR;

namespace CQRS.Api.Commands
{
    public class DeletedUserCommand : IRequest<long>
    {
        public long Id { get; set; }
    }
}
