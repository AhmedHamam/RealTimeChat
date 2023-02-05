using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace RealChat.Application
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddIdentityApplication(this IServiceCollection services)
        {
            //services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
           // services.AddMediatR(Assembly.GetExecutingAssembly());

            //services.AddTransient<ISendingEmailService, SendingEmailService>();
            //services.AddScoped<IUserService, UserService>();

            return services;
        }
    }
}
