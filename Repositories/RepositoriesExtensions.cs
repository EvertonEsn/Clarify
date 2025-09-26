using Clarify.Repositories.Interfaces;

namespace Clarify.Repositories;

public static class RepositoriesExtensions
{
    public static void ConfigurePersistenceApp(this IServiceCollection services)
    {
        services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
        services.AddScoped<IGrupoRepository, GrupoRepository>();
        services.AddScoped<IContaRepository, IContaRepository>();
        services.AddScoped<ILancamentoRepository, ILancamentoRepository>();
        services.AddScoped<IPartidaRepository, IPartidaRepository>();
    }
}