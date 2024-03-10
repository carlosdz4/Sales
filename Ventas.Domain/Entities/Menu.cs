using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.Domain.Core;

namespace Ventas.Domain.Entities
{
    public class Menu : BaseEntity
    {
        public int Id { get; set; }
        public int Descripcion { get; set; }


        public int? IdMenuPadre { get; set; }

        public virtual Menu? MenuPadre { get; set; }

        public ICollection<RolMenu>? RolMenus { get; set; }

        public string? Icono { get; set; }
        public string? Controlador { get; set; }

        public string? PaginaAccion { get; set; }
    }
}
