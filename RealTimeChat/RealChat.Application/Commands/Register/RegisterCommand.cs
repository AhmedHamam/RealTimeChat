using MediatR;
using System.ComponentModel.DataAnnotations;

namespace RealChat.Application.Commands.Register
{
    public class RegisterCommand : IRequest<string>
    {
        [Required]
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
}
