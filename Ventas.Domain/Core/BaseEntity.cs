using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ventas.Domain.Core
{
   public abstract class BaseEntity
    {

        public BaseEntity()
        {
            
            FechaRegistro = DateTime.Now;
            Eliminado = false;
        }
       
        public DateTime FechaRegistro { get; set; }

        public int IdUsuarioCreacion { get; set; }

        public DateTime? FechaMod { get; set; }

        public int IdUsuarioMod { get; set; }

        public int IdusuarioElimino { get; set; }

        public DateTime? FechaElimino { get; set; }

        public bool Eliminado { get; set; }
    }
}
