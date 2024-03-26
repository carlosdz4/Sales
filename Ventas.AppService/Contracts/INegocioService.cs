using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.AppService.Core;
using Ventas.AppService.Dtos;

namespace Ventas.AppService.Contracts
{
    public interface INegocioService
    {
        public Task<ServiceResult> GetNegocio();
        public Task<ServiceResult> GetNegocioByName(string name);
        public Task<ServiceResult> AddNegocio(NegocioAddDto  negocioAddDto);
    }
}
