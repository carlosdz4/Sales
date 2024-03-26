using Microsoft.Extensions.DependencyInjection;

using Ventas.AppService.Contracts;
using Ventas.AppService.Service;
using Ventas.Infraestructure.Dao;
using Ventas.Infraestructure.Interfaces;

namespace Ventas.IOC.VentasDependencies
{
    public static class VentasDependency
    {

        public static void AddVentasDependency(this IServiceCollection service)
        {
           service.AddScoped<IVentaDB, VentaDB>();
            service.AddTransient<IVentaService , VentasService>();
        }

    }
}
