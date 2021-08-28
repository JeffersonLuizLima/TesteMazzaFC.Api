using TesteMazzaFC.Api.Intefaces;
using TesteMazzaFC.Api.Notificacoes;
using Microsoft.Extensions.DependencyInjection;

namespace TesteMazzaFC.Api.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<INotificador, Notificador>();

            return services;
        }
    }
}