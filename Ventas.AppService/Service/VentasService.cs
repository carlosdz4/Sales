using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.AppService.Contracts;
using Ventas.AppService.Core;
using Ventas.AppService.Dtos;
using Ventas.Domain.Entities;
using Ventas.Infraestructure.Interfaces;

namespace Ventas.AppService.Service
{
    public class VentasService : IVentaService
    {
        private readonly IVentaDB ventaDB;
        private readonly ILogger<VentasService> logger;

        public VentasService(IVentaDB ventaDB , ILogger<VentasService> logger)
        {
            this.ventaDB = ventaDB;
            this.logger = logger;
        }
        public Task<ServiceResult> AddVentas(VentasAddDto ventasAddDto)
        {
            throw new NotImplementedException();
        }

        public async Task<ServiceResult> GetVentas()
        {
            ServiceResult result = new ServiceResult();

            try
            {
                var resultado = this.ventaDB.GetAll();

                var query = (from ve in this.ventaDB.GetAll()
                             
                             select new Models.VentaModel()
                             {
                                 NumeroVenta = ve.NumeroVenta,
                                 IdTipoDocumentoVenta = ve.IdTipoDocumentoVenta,
                                 IdUsuario = ve.IdUsuario,
                                 DocumentoCliente = ve.DocumentoCliente,
                                 Nombrecliente = ve.Nombrecliente,
                                 SubTotal = ve.SubTotal,
                                 ImpuestoTotal = ve.ImpuestoTotal,
                                 Total = ve.Total,
                                 FechaRegistro = ve.FechaRegistro,
                                 IdUsuarioCreacion = ve.IdUsuarioCreacion,




                             }).ToList();

               
                
                result.Data = query;
                result.Success = true;
            }
            catch (Exception ex)
            {
                result.Success = false;

                this.logger.LogError($"Error: {ex.Message}", ex.ToString());
            }
            return result;
        }

        public Task<ServiceResult> GetVentasByName(string NumeroVenta)
        {
            throw new NotImplementedException();
        }
    }
}
