using Microsoft.AspNetCore.Identity;

namespace RealChat.Domain.Domains.User
{
    public class RoleClaim : IdentityRoleClaim<int>
    {
        public virtual Role Role { get; set; }
    }
}