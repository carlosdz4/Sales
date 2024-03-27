using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ventas.AppService.Models.Result
{
    public class GetNegocioResult<TModel> : ServicioResult
    {
        public TModel data { get; set; }
    }
}
