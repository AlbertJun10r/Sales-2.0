using Microsoft.EntityFrameworkCore;
using Sales_System_2._0.Infrastructure.Context;
using Sales_System_2._0.IOC.Dependencies;
using Sales_System_2._0.Web.Services;

namespace SalesOnline.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);


            // Agregar dependencia del contexto //
            builder.Services.AddDbContext<SalesContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("SalesContext")));




            // Dependencia de los repositorios //
            builder.Services.AddUsuarioDependecy();
            builder.Services.AddScoped<IWebService, WebService>();


            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}