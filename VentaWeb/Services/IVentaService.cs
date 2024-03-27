using System.Collections.Generic;
using Ventas.AppService.Models.Result;
using VentaWeb.Models;
using VentaWeb.Models.Result;

namespace VentaWeb.Services
{
    public interface IVentaService
    {
        Task<GetResult<List<VentaModel>>> GetVentas();
        Task<GetResult<VentaModel>> VentaById(VentaSearch search);

        Task<ServicioResult> VentaAdd(VentaCreateModel CreateVenta);
    }
}
