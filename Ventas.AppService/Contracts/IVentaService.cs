using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.AppService.Core;
using Ventas.AppService.Dtos;

namespace Ventas.AppService.Contracts
{
    public interface IVentaService
    {

        public Task<ServiceResult> GetVentas();
        public Task<ServiceResult> GetVentasById(int id);
        public Task<ServiceResult> AddVentas(VentasAddDto ventasAddDto);
    }
}
