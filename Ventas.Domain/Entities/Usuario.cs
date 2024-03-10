using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.Domain.Core;

namespace Ventas.Domain.Entities
{
   public class Usuario : BaseEntity
    {

        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? correo { get; set; }

        public int Telefono { get; set; }

        public int IdRol { get; set; }

        public virtual Rol? Rol { get; set; }

        public string? UrlFoto { get; set; }

        public string? NombreFoto { get; set; }

        public string? Clave { get; set; }

        public ICollection<Venta>? Ventas { get; set; }
    }
}
