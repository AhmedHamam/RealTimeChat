﻿using Microsoft.AspNetCore.Identity;
using RealChat.Domain.Domains.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealChat.Infrastructure
{
    public static class IdentityDbContextSeed
    {
        public static async Task SeedDataAsync(IdentityDatabaseContext databaseContext, UserManager<User> userManager)
        {
            // seed 
            await SeedRoles(databaseContext);
            await SeedSuperAdmin(databaseContext, userManager);

            // Save changes
            await databaseContext.SaveChangesAsync();
        }

        private static async Task SeedRoles(IdentityDatabaseContext databaseContext)
        {
            if (databaseContext.Roles.Any()) return;

            var names = Enum.GetNames(typeof(RolesEnum));
            var values = (RolesEnum[])Enum.GetValues(typeof(RolesEnum));

            for (var i = 0; i < names.Length; i++)
            {
                var role = new Role(names[i], values[i].GetDescription());
                await databaseContext.Roles.AddAsync(role);
            }

            // Save changes
            await databaseContext.SaveChangesAsync();
        }

        private static async Task SeedSuperAdmin(IdentityDatabaseContext databaseContext, UserManager<User> userManager)
        {
            const string email = "superadmin@gmail.com";
            const string password = "Admin@2010";
            var user = await userManager.FindByNameAsync(email);

            if (user is not null) return;

            var rolesFromDb = databaseContext.Roles.ToList();

            var newUser = new CreateUserFactory(email)
                .WithRoles(rolesFromDb, RolesEnum.SuperAdmin)
                .Build();

            await userManager.CreateAsync(newUser, password);

            newUser.AddUserClaim(ClaimKeys.FirstName, "Super");
            newUser.AddUserClaim(ClaimKeys.LastName, "Admin");
            newUser.AddUserClaim(ClaimKeys.IsActive, true.ToString());
            newUser.AddUserClaim(ClaimKeys.BusinessId, null);
            await databaseContext.SaveChangesAsync();
        }
    }
}
