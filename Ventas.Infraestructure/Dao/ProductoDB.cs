using Microsoft.Extensions.Logging;
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
   public class ProductoDB : daoBase<Producto>, IProductoDB
    {
        private readonly SalesContex contex;
        private readonly ILogger<ProductoDB> logger;

        public ProductoDB(SalesContex contex , ILogger<ProductoDB> logger) : base(contex)
        {
            this.contex = contex;
            this.logger = logger;
        }

        public List<ModelProducto> GetProducts() { 
        
        List<ModelProducto> products = new List<ModelProducto>();

            try
            {
                products = (from po in contex.Producto
                            join ca in contex.Categoria on po.IdCategoria equals ca.Id
                            where po.Eliminado == false && ca.Eliminado == false
                            select new ModelProducto
                            {
                                Id = po.IdCategoria,
                                CodigoBarra = po.CodigoBarra,
                                Marca = po.Marca,
                                NombreCategoria = ca.Descripcion
                            }).ToList();

                //products = contex.Producto.Where(po => !po.Eliminado).Join(contex.Categoria.Where(ca => !ca.Eliminado),
                //    po => po.IdCategoria, ca => ca.Id, (po, ca) => new ModelProducto
                //    {
                //        Id = po.Id,
                //        CodigoBarra = po.CodigoBarra,
                //        Marca = po.Marca,
                //        NombreCategoria = ca.Descripcion

                //    }).ToList();
            }
            catch (Exception ex)
            {

                this.logger.LogError(ex.ToString());
            }

            return products;

            
        }
    }
}
