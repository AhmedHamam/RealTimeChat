using Microsoft.AspNetCore.Identity;

namespace RealChat.Domain.Domains.User
{
    public class UserClaim : IdentityUserClaim<int>
    {
        public ApplicationUser? User { get; set; }
    }
}
