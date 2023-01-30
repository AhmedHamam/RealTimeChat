using Microsoft.AspNetCore.Identity;

namespace RealChat.Domain.Domains.User
{
    public class UserClaim : IdentityUserClaim<int>
    {
        public virtual ApplicationUser? User { get; set; }
    }
}
