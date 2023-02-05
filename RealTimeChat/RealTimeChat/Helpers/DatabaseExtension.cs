using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using RealChat.Infrastructure;

namespace RealTimeChat.Helpers
{
    public static class DatabaseExtension
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="scope"></param>
        public static async Task MigrateDatabase(this IServiceScope scope)
        {
            var identityDbContext = scope.ServiceProvider.GetRequiredService<IdentityDatabaseContext>();
            //await identityDbContext.Database.MigrateAsync();
        }

        /// <summary>
        /// </summary>
        /// <param name="scope"></param>
        public static async Task SeedDatabase(this IServiceScope scope)
        {
            //var identityDbContext = scope.ServiceProvider.GetRequiredService<IdentityDatabaseContext>();
            //var userManager = scope.ServiceProvider.GetRequiredService<UserManager<User>>();
            //await IdentityDbContextSeed.SeedDataAsync(identityDbContext, userManager);
        }
    }
}