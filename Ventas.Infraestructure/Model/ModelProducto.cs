using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ventas.Infraestructure.Model
{
    public class ModelProducto
    {
        public int Id { get; set; }
        public string? Marca { get; set; }

        public int stock { get; set; }

        public string? CodigoBarra { get; set; }

        public string? NombreCategoria { get; set; }
    }
}
