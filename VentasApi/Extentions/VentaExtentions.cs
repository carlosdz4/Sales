using Ventas.AppService.Dtos;
using Ventas.AppService.Models;

namespace VentasApi.Extentions
{
    public static class VentaExtentions
    {

        public static VentasAddDto ConvertFromVentaCreateToVentaDto(this VentaModel ventaModel) {
            return new VentasAddDto()
            {
                ImpuestoTotal = ventaModel.ImpuestoTotal,
                DocumentoCliente = ventaModel.DocumentoCliente,
                IdTipoDocumentoVenta = ventaModel.IdTipoDocumentoVenta,
                IdUsuario = ventaModel.IdUsuario,
                NumeroVenta = ventaModel.NumeroVenta,
                SubTotal = ventaModel.SubTotal,
                Nombrecliente = ventaModel?.Nombrecliente,
                Total = ventaModel.Total,
                
            };
                }

    }
}
