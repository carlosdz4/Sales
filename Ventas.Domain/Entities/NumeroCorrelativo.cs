using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ventas.Domain.Entities
{
  public class NumeroCorrelativo
    {

        public int Id { get; set; }
        public int UltimoNumero { get; set; }
        public int CantidadDigitos { get; set; }

        public string Gestion { get; set; }

        public DateTime FechaActualizaciones { get; set; }
    }
}
