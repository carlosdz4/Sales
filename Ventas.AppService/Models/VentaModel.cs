using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ventas.AppService.Models
{
    public class VentaModel
    {
        public string? NumeroVenta { get; set; }
        public int IdTipoDocumentoVenta { get; set; }

        public int IdUsuario { get; set; }

        public string? DocumentoCliente { get; set; }
        public string? Nombrecliente { get; set; }

        public decimal SubTotal { get; set; }

        public decimal ImpuestoTotal { get; set; }

        public decimal Total { get; set; }

        public DateTime FechaRegistro { get; set; }

        public int IdUsuarioCreacion { get; set; }
    }
}
