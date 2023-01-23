using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
