using MediatR;
using Microsoft.AspNetCore.Identity;
using RealChat.Domain.Domains.User;
using RealChat.Infrastructure;

namespace RealChat.Application.Commands.Register
{
    public class RegisterHandler : IRequestHandler<RegisterCommand, string>
    {
        IdentityDatabaseContext _context;
        UserManager<ApplicationUser> _userManager;

        public RegisterHandler(UserManager<ApplicationUser> userManager, IdentityDatabaseContext context)
        {
            _userManager = userManager;
            _context = context;
        }
        public async Task<string> Handle(RegisterCommand request, CancellationToken cancellationToken)
        {
            //Your business
            var user = new ApplicationUser();
            user.UserName = request.UserName;
            user.Email = request.Email;
            user.FirstName = request.FirstName;
            user.LastName = request.LastName;
            user.PhoneNumber = request.PhoneNumber;
            
            user.EmailConfirmed = false;
            user.PhoneNumberConfirmed = false;
            user.LockoutEnabled = false;

            try
            {
                var result = await _userManager.CreateAsync(user, request.Password);
                if (!result.Succeeded) throw new Exception(result.Errors.ToStringDetails());

            }
            catch (Exception ex)
            {
                
                return ex.Message+Environment.NewLine+"Inner"+ ex.InnerException?.Message;
            }

            return user.Id.ToString() ;
        }
        
    }
}
