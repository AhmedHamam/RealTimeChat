using Base.Infrastructure;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RealChat.Domain.Domains.User;
using System.Reflection;

namespace RealChat.Infrastructure
{
    public class IdentityDatabaseContext : IdentityDbContext<
       ApplicationUser, Role, int,
       UserClaim, UserRole, UserLogin,
       RoleClaim, UserToken>
    {
        public IdentityDatabaseContext()
        {
        }

        public IdentityDatabaseContext(DbContextOptions<IdentityDatabaseContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            foreach (var relationship in builder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }

            builder.GetOnlyNotDeletedEntities();
        }
    }
}
