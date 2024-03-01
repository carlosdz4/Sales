using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.Domain.Core;

namespace Ventas.Domain.Entities
{
    public class RolMenu : BaseEntity
    {
        public int Id { get; set; }

        public int IdRol { get; set; }
        public Rol Rol { get; set; }

        public int IdMenu { get; set; }

        public Menu Menu { get; set; }


    }
}
