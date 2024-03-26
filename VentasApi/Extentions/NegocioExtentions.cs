using Ventas.AppService.Dtos;
using Ventas.AppService.Models;

namespace VentasApi.Extentions
{
    public static class NegocioExtentions
    {
        public static NegocioAddDto ConvertFromNegocioCreateToNegocioDto(NegocioModel model)
        {
            return new NegocioAddDto()
            {
                Direccion = model.Direccion,
                NumeroDocumento = model.NumeroDocumento,
                SimboloMoneda = model.SimboloMoneda,
                Correo = model.Correo,
                Nombre = model.Nombre,
                NombreLogo = model.NombreLogo,
                PorcentajeImpuesto = model.PorcentajeImpuesto,
                Telefono = model.Telefono,
                UrlLogo = model.UrlLogo,
            };
        }
    }

}
