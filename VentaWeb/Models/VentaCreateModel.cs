namespace VentaWeb.Models
{
    public class VentaCreateModel
    {
        public string? numeroVenta { get; set; }
        public int idTipoDocumentoVenta { get; set; }

        public int idUsuario { get; set; }

        public string? documentoCliente { get; set; }
        public string? nombrecliente { get; set; }

        public decimal subTotal { get; set; }

        public decimal impuestoTotal { get; set; }

        public decimal total { get; set; }

       // public DateTime fechaRegistro { get; set; }

        public int idUsuarioCreacion { get; set; }
    }
}
