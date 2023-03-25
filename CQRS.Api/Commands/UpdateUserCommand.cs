using CQRS.Api.Models;
using MediatR;

namespace CQRS.Api.Commands
{
    public class UpdateUserCommand :IRequest<long>
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }

        public UpdateUserCommand(long id, string name, string email, string passport, string phone)
        {
            Id = id;
            Name = name;
            Email = email;
            Password = passport;
            Phone = phone;

        }
    }

}
