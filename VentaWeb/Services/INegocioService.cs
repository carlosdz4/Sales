using Ventas.AppService.Models.Result;
using VentaWeb.Models;

namespace VentaWeb.Services
{
    public interface INegocioService
    {
        Task<GetNegocioResult<List<NegocioModel>>> GetNegocios();

        Task<GetNegocioResult<NegocioModel>> GetNegocioByName(NegocioSearch name);
        Task<ServicioResult> SaveNegocio(NegocioModel Createnegocio);



    }
}
