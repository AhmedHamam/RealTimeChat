using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealChat.Infrastructure
{
    public class IdentityDbContextFactory : IDesignTimeDbContextFactory<IdentityDatabaseContext>
    {
        public IdentityDatabaseContext CreateDbContext(string[] args)
        {
            var configBuilder = new ConfigurationBuilder();
            configBuilder.AddJsonFile("appsettings.json");
            var config = configBuilder.Build();
            var connectionString = config.GetValue<string>("ConnectionStrings:DefaultConnection");
            var optionsBuilder = new DbContextOptionsBuilder<IdentityDatabaseContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new IdentityDatabaseContext(optionsBuilder.Options);
        }
    }
}
