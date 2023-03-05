// <copyright file="DependencyInjection.cs" company="Hircasa - Prueba Reclutamiento">
// Copyright (c) Hircasa - Prueba Reclutamiento. All rights reserved.
// </copyright>
namespace HIRCASA.MX.CORE.LIB.INFRASTRUCTURE
{
    using HIRCASA.MX.CORE.LIB.DOMAIN.Interfaces.Clients;
    using HIRCASA.MX.CORE.LIB.INFRASTRUCTURE.Persistence;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;

    /// <summary>
    /// DependencyInjection.
    /// </summary>
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("SqlServer");
            services.AddDbContext<AppDataContext>(options =>
            {
                options.UseSqlServer(connectionString);
            });

            services.AddScoped<Func<AppDataContext>>((provider) => () => provider.GetService<AppDataContext>());
            services.AddScoped<IClientsUnit, ClientsUnit>();

            return services;
        }
    }
}
