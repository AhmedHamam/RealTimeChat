﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RealChat.Domain.Domains.User;

namespace RealChat.Infrastructure.Configurations
{
    public class UserRoleConfigurations : IEntityTypeConfiguration<UserRole>
    {
        public void Configure(EntityTypeBuilder<UserRole> builder)
        {
            builder.ToTable("UserRoles", "IdentitySchema");
            builder.HasKey(x => new { x.UserId, x.RoleId });

        }
    }
}
