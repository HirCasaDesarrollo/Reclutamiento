using HIRCasa.Reclutamiento.Core.Connections;
using HIRCasa.Reclutamiento.Core.Context;
using HIRCasa.Reclutamiento.Core.Contracts;
using HIRCasa.Reclutamiento.Core.Repositories;
using Microsoft.EntityFrameworkCore;

namespace HIRCasa.Reclutamiento.API.Services;

public static class DependencyInjection
{
    public static IServiceCollection AddDependencyInjection(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<HIRCasaContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

        services.AddScoped<IHIRCasaContext>(provider => provider.GetRequiredService<HIRCasaContext>());

        services.AddScoped<IApplicationWriteDbConnection, ApplicationWriteDbConnection>();
        services.AddScoped<IApplicationReadDbConnection, ApplicationReadDbConnection>();

        services.AddTransient(typeof(IRepository<>), typeof(BaseRepository<>));
        services.AddTransient(typeof(IReadRepository<>), typeof(BaseRepository<>));
        services.AddTransient<IClienteRepository, ClienteRepository>();

        return services;
    }
}
