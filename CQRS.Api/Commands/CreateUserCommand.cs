using CQRS.Api.Models;
using MediatR;

namespace CQRS.Api.Commands
{
    public class CreateUserCommand :IRequest<User>
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }

        public CreateUserCommand(string name, string email, string passport, string phone)
        {
            Name = name;
            Email = email;
            Password = passport;
            Phone = phone;

        }
    }

}
