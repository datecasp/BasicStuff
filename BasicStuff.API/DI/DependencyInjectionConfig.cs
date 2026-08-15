using BasicStuff.Domain.Interfaces;
using BasicStuff.Infra.Context;
using BasicStuff.Infra.Repositories;
using BasicStuff.Infra.UoW;
using BasicStuff.Domain.Services;

namespace BasicStuff.API.DI;
public static class DependencyInjectionConfig
{
    public static IServiceCollection ResolveDependencies(this IServiceCollection services)
    {
        services.AddScoped<AppDbContext>();

        services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
        services.AddScoped<IUnitOfWork, UnitOfWork>();
        services.AddScoped<IUsuarioService, UsuarioService>();

        return services;
    }
}

