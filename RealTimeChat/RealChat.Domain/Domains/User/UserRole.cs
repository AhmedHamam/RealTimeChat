using Microsoft.AspNetCore.Identity;

namespace RealChat.Domain.Domains.User
{
    public class UserRole : IdentityUserRole<int>
    {
        public virtual Role Role { get; set; }
        public virtual ApplicationUser User { get; set; }
    }
}