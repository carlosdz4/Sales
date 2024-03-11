using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.Domain.Entities;
using Ventas.Infraestructure.Context;
using Ventas.Infraestructure.Core;
using Ventas.Infraestructure.Interfaces;
using Ventas.Infraestructure.Model;

namespace Ventas.Infraestructure.Dao
{
    public class VentaDB : daoBase<Venta>, IVentaDB
    {
        private readonly SalesContex contex;

        public VentaDB(SalesContex contex) : base(contex)
        {
            this.contex = contex;
        }

        public ModelVendedorVentas modelVendedorVentas(int IdUsuario)
        {
            ModelVendedorVentas modelVendedorVentas = new ModelVendedorVentas();

            try
            {


                modelVendedorVentas = contex.Venta
                    .Where(v => v.IdUsuario == IdUsuario)
                    .GroupBy(v => v.Usuario.Nombre)
           .Select(g => new ModelVendedorVentas
           {
               NombreVendedor = g.Key,
               CantidadVenta = g.Count()
           }).First();

                
            }
            catch (Exception)
            {

                throw;
            }

            return modelVendedorVentas;
        }
    }
}
