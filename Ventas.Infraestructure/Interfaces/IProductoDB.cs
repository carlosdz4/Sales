using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.Domain.Entities;
using Ventas.Infraestructure.Core;
using Ventas.Infraestructure.Model;

namespace Ventas.Infraestructure.Interfaces
{
    public interface IProductoDB : IDaoBase<Producto>
    {
        public List<ModelProducto> GetProducts();
    }
}
