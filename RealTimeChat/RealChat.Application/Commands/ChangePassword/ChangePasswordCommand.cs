using MediatR;

namespace RealChat.Application.Commands.ChangePassword
{
    public class ChangePasswordCommand:IRequest<string>
    {
        public string UserId { get; set; }
        public string OldPassword { get; set; }
        public string NewPassword { get; set; }
    }
}
