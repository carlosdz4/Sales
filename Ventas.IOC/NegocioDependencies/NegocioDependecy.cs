using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.AppService.Contracts;
using Ventas.AppService.Service;
using Ventas.Domain.Entities;
using Ventas.Infraestructure.Dao;
using Ventas.Infraestructure.Interfaces;

namespace Ventas.IOC.NegocioDependencies
{
    public static class NegocioDependecy
    {
        public static void AddNegocioDependecy(this IServiceCollection services)
        {
            services.AddScoped<INegocioDB, NegocioDB>();
            services.AddTransient<INegocioService , NegocioService>();
        }
    }
}
