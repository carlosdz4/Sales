using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.Domain.Core;

namespace Ventas.Domain.Entities
{
    public class DetalleVenta 
    {
        public int Id { get; set; }

        public int Idventa { get; set; }
        public virtual Venta Venta { get; set; }

        public int IdProducto { get; set; }

        public string MarcaProducto { get; set; }

        public string DescripcionProducto { get; set; }

        public string CategoriaProducto { get; set; }

        public int Cantidad { get; set; }
        public decimal Precio { get; set; }

        public decimal Total { get; set; }


    }
}
