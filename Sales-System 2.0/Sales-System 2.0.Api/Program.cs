using Microsoft.EntityFrameworkCore;
using Sales_System_2._0.Infrastructure.Context;
using Sales_System_2._0.IOC.Dependencies;

namespace Publicaciones.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Agregar dependencia del contexto
            builder.Services.AddDbContext<SalesContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("SalesContext")));

            // Registrar dependencias del servicio de usuario
            builder.Services.AddUsuarioDependecy();

            // Agregar controladores y Swagger
            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();
            app.MapControllers();

            app.Run();
        }
    }
}
