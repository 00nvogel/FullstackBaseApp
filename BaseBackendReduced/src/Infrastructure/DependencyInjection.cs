using System.Reflection;
using BaseBackendReduced.Core;
using BaseBackendReduced.Core.Contracts;
using BaseBackendReduced.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BaseBackendReduced.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<AppDbContext>(options =>
            options.UseNpgsql(configuration.GetConnectionString("DefaultConnection")));

        services.AddScoped<IEventPublisher, EventDispatcher>();
        services.AddScoped<IUnitOfWork>(sp => sp.GetRequiredService<AppDbContext>());
        services.AddScoped<IExampleRepository, ExampleRepository>();

        return services;
    }

    public static IServiceCollection AddEventListeners(this IServiceCollection services, params Assembly[] assemblies)
    {
        services.Scan(scan => scan
            .FromAssemblies(assemblies)
            .AddClasses(classes => classes.AssignableTo(typeof(IEventListener<>)))
            .AsImplementedInterfaces()
            .WithScopedLifetime());

        return services;
    }
}
