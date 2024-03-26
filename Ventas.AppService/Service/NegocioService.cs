using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.AppService.Contracts;
using Ventas.AppService.Core;
using Ventas.AppService.Dtos;
using Ventas.Infraestructure.Interfaces;

namespace Ventas.AppService.Service
{
    public class NegocioService : INegocioService
    {
        private readonly INegocioDB negocioDB;
        private readonly ILogger<NegocioService> logger;

        public NegocioService(INegocioDB negocioDB , ILogger<NegocioService> logger)
        {
            this.negocioDB = negocioDB;
            this.logger = logger;
        }
        public async Task<ServiceResult> AddNegocio(NegocioAddDto negocioAddDto)
        {
            ServiceResult result = new ServiceResult();


            try
            {
                var guardado = this.negocioDB.Save(new Domain.Entities.Negocio
                {

                    Nombre = negocioAddDto.Nombre,
                    NombreLogo = negocioAddDto.NombreLogo,
                    NumeroDocumento = negocioAddDto.NumeroDocumento,
                    Correo = negocioAddDto.Correo,
                    Direccion = negocioAddDto.Direccion,
                    Telefono = negocioAddDto.Telefono,
                    UrlLogo = negocioAddDto.UrlLogo,
                    PorcentajeImpuesto = negocioAddDto.PorcentajeImpuesto,


                });

                if (guardado.Success)
                {
                    result.Message = "El Negocio se creo con exito";
                    result.Success = true;
                }
                
            }
            catch (Exception ex)
            {
                result.Success = false;
                this.logger.LogError($"Error: {ex.Message}", ex.ToString());
            }
            

            


            return result;
        }

        public async Task<ServiceResult> GetNegocio()
        {
            ServiceResult result = new ServiceResult();

            try
            {
                var query = (from ne in negocioDB.GetAll()
                             where ne.Eliminado != false
                             select new Models.NegocioModel
                             {
                                 Correo = ne.Correo,
                                 Direccion = ne.Direccion,
                                 Nombre = ne.Nombre,
                                 NombreLogo = ne.NombreLogo,
                                 NumeroDocumento = ne.NumeroDocumento,
                                 PorcentajeImpuesto = ne.PorcentajeImpuesto,
                                 SimboloMoneda = ne.SimboloMoneda,
                                 Telefono = ne.Telefono,
                                 UrlLogo = ne.UrlLogo,



                             }).ToList();

                result.Data = query;

            }
            catch (Exception ex)
            {

                this.logger.LogError($"Error: {ex.Message}", ex.ToString());
            }

            return result;

            
        }

        public Task<ServiceResult> GetNegocioByName(string name)
        {
            throw new NotImplementedException();
        }
    }
}
