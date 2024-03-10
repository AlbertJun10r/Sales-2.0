using Microsoft.Extensions.DependencyInjection;
using Sales_System_2._0.Application.Contract;
using Sales_System_2._0.Application.Service;
using Sales_System_2._0.Infrastructure.Interfaces;
using Sales_System_2._0.Infrastructure.Repositories;
namespace Sales_System_2._0.IOC.Dependencies
{
    public static class UsuarioDependency
    {
        public static void AddUsuarioDependecy(this  IServiceCollection services)
        {
            services.AddScoped<IUsuarioRepository, UsuarioRepository>();
            services.AddTransient<IUsuarioService, UsuarioService>();
        }
    }
}
