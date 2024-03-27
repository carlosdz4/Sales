using Ventas.AppService.Models.Result;

namespace VentaWeb.Models.Result
{
    public class GetResult<TModel> : ServicioResult
    {
        public TModel data { get; set; }

    }
}
