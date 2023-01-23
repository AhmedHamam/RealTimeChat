using MediatR;

namespace RealChat.Application.Commands.Register
{
    public class RegisterHandler : IRequestHandler<RegisterCommand, string>
    {
        public Task<string> Handle(RegisterCommand request, CancellationToken cancellationToken)
        {
            //Your business

            throw new NotImplementedException();
        }
    }
}
