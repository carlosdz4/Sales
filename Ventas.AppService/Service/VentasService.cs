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
using Ventas.Infraestructure.Dao;
using Ventas.Infraestructure.Interfaces;

namespace Ventas.AppService.Service
{
    public class VentasService : IVentaService
    {
        private readonly IVentaDB ventaDB;
        private readonly ILogger<VentasService> logger;
        

        public VentasService(IVentaDB ventaDB , ILogger<VentasService> logger  )
        {
            this.ventaDB = ventaDB;
            this.logger = logger;
           
        }
        public async Task<ServiceResult> AddVentas(VentasAddDto ventasAddDto)
        {
            ServiceResult result = new ServiceResult();
            


            try
            {
              

                

                var guardado = this.ventaDB.Save(new Venta
                {
                    Nombrecliente = ventasAddDto.Nombrecliente,
                    NumeroVenta = ventasAddDto.NumeroVenta,
                    DocumentoCliente = ventasAddDto.DocumentoCliente,
                    SubTotal = ventasAddDto.SubTotal,
                    ImpuestoTotal = ventasAddDto.SubTotal,
                    Total = ventasAddDto.Total,
                    IdTipoDocumentoVenta = ventasAddDto.IdTipoDocumentoVenta,
                    IdUsuario = ventasAddDto.IdUsuario,
                    


                });

                if (guardado.Success)
                {
                    result.Success = true;
                    result.Message = "La venta se creo con exito";
                }

            }
            catch (Exception ex)
            {

                result.Success = false;
                this.logger.LogError($"Error: {ex.Message}", ex.ToString());
            }

            return result;

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
                                 Id = ve.Id,



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

        public async Task<ServiceResult> GetVentasById(int VentaId)
        {
            ServiceResult result = new ServiceResult();



            try
            {
                var query = this.ventaDB.GetById(x => x.Id == VentaId);

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
    }
}
