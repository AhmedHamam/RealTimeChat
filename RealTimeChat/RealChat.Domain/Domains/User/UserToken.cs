using Microsoft.AspNetCore.Identity;

namespace RealChat.Domain.Domains.User
{
    public class UserToken : IdentityUserToken<int>
    {
        public virtual ApplicationUser User { get; set; }
    }
}