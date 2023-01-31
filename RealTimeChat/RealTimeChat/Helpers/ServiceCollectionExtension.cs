using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using RealChat.Domain.Domains.User;
using RealChat.Infrastructure;

namespace RealTimeChat.Helpers
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddIdentitySetup(this IServiceCollection services,
            IConfiguration configuration)
        {
            //#region Identity Configuration

            //var adminConfig = configuration.GetAdminClientConfig().Jwt;
            //var publicConfig = configuration.GetPublicClientConfig().Jwt;

            //services.AddAuthorization();

            //services.AddAuthorization(auth =>
            //{
            //    auth.AddPolicy("Bearer", new AuthorizationPolicyBuilder()
            //        .AddAuthenticationSchemes(JwtBearerDefaults.AuthenticationScheme‌​)
            //        .RequireAuthenticatedUser().Build());
            //});

            //services.AddIdentityCore<User>()
            //    .AddRoles<Role>()
            //    .AddEntityFrameworkStores<IdentityDatabaseContext>()
            //    .AddTokenProvider<DataProtectorTokenProvider<User>>(TokenOptions.DefaultProvider);

            //services.Configure<IdentityOptions>(options =>
            //{
            //    options.Password = IdentitySettings.PasswordOptions();
            //    options.Lockout = IdentitySettings.LockoutOptions(configuration);
            //    options.SignIn = IdentitySettings.SignInOptions();
            //    options.User = IdentitySettings.UserOptions();
            //});

            //services.AddAuthentication(x =>
            //{
            //    x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            //    x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            //}).AddJwtBearer(options =>
            //{
            //    var adminSigningKey = Convert.FromBase64String(adminConfig.Key);
            //    var publicSigningKey = Convert.FromBase64String(publicConfig.Key);
            //    options.TokenValidationParameters = new TokenValidationParameters
            //    {
            //        NameClaimType = ClaimTypes.NameIdentifier,
            //        ValidateIssuer = true,
            //        ValidIssuer = adminConfig.Issuer,
            //        ValidateAudience = true,
            //        ValidAudiences = new List<string>() { adminConfig.Audience, publicConfig.Audience },
            //        ValidateIssuerSigningKey = true,
            //        IssuerSigningKeys = new List<SecurityKey>()
            //    {
            //        new SymmetricSecurityKey(adminSigningKey),
            //        new SymmetricSecurityKey(publicSigningKey)
            //    },
            //    };
            //});

            //#endregion

            //#region CORS

            //services.AddCors(c => { c.AddPolicy("AllowOrigin", options => options.AllowAnyOrigin()); });

            //#endregion


            return services;
        }

        public static WebApplication UseIdentitySetup(this WebApplication app)
        {
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseCors(x => x.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());
            app.UseAuthentication();
            app.UseAuthorization();
            app.MapControllers();
          //  app.UseCurrentUser();
            return app;
        }
    }
}
