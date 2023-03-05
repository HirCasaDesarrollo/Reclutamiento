// <copyright file="DependencyInjection.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
namespace HIRCASA.MX.CORE.LIB.APPLICATION
{
    using System.Reflection;
    using MediatR;
    using Microsoft.Extensions.DependencyInjection;

    /// <summary>
    /// DependencyInjection.
    /// </summary>
    public static class DependencyInjection
    {
        /// <summary>
        /// Adds the application.
        /// </summary>
        /// <param name="services">The services.</param>
        /// <returns>Service collection</returns>
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());
            // services.AddScoped<IEmailLogic, EmailLogic>();

            return services;
        }
    }
}
