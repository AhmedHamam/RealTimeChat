using Duende.IdentityServer.EntityFramework.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace RealChat.Infrastructure.Configurations
{
    public class UserClaimConfigurations : IEntityTypeConfiguration<UserClaim>
    {
        public void Configure(EntityTypeBuilder<UserClaim> builder)
        {
            builder.ToTable("UserClaims", "IdentitySchema");
            //builder.HasKey(x => x.Id);
        }
    }
}
