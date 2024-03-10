using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.Domain.Core;

namespace Ventas.Domain.Entities
{
    public class Rol : BaseEntity
    {
        public int Id { get; set; }
        public string? Descripcion { get; set; }

        public ICollection<Usuario>? Usuarios { get; set; }
        public ICollection<RolMenu>? RolMenus { get; set; }

    }
}
