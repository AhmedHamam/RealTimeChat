using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RealChat.Domain.Domains.User;

namespace RealChat.Infrastructure.Configurations
{
    public class UserTokenConfigurations : IEntityTypeConfiguration<UserToken>
    {
        public void Configure(EntityTypeBuilder<UserToken> builder)
        {
            builder.ToTable("UserTokens", "IdentitySchema");
            builder.HasKey(x => new { x.UserId, x.LoginProvider });
        }
    }
}
