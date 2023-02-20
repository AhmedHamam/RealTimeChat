﻿using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using RealChat.Domain.Domains.User;
using System.Reflection;

namespace RealChat.Application
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddIdentityApplication(this IServiceCollection services)
        {
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            services.AddMediatR(Assembly.GetExecutingAssembly());
            services.AddScoped<PasswordHasher<ApplicationUser>>();


            return services;
        }
    }
}
