using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.AppService.Contracts;
using Ventas.AppService.Service;
using Ventas.Infraestructure.Dao;
using Ventas.Infraestructure.Interfaces;

namespace Ventas.IOC.UsuarioDependecies
{
    public static class UsuarioDependecy
    {
        public static void AddUsuarioDependency(this IServiceCollection service)
        {
            service.AddScoped<IUsuarioDB, UsuarioDB>();
            
        }

    }
}
