using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.Domain.Entities;
using Ventas.Infraestructure.Context;
using Ventas.Infraestructure.Core;
using Ventas.Infraestructure.Exceptions;
using Ventas.Infraestructure.Interfaces;

namespace Ventas.Infraestructure.Dao
{
    public class NegocioDB : daoBase<Negocio>, INegocioDB
    {
        private readonly SalesContex contex;
        private readonly ILogger<NegocioDB> logger;
        private readonly IConfiguration configuration;

        public NegocioDB(SalesContex contex , ILogger<NegocioDB> logger , IConfiguration configuration) : base(contex)
        {
            this.contex = contex;
            this.logger = logger;
            this.configuration = configuration;
        }

        public override List<Negocio> GetAll()
        {
            return base.GetFilterWithEntities(x => x.Eliminado == false);
        }

        public override DataResult Save(Negocio entity)
        {
            DataResult result = new DataResult();

            try
            {
                if (base.Exists(x => x.Id == entity.Id))
                {

                    throw new NegocioException("El Negocio ha sido Duplicado");
                    
                }
                else
                {
                    base.Save(entity);
                    result.Success = true;
                    
                }
                
            }
            catch (Exception ex)
            {
                result.Message = "error al agregar un negocio";
                result.Success = false;
                this.logger.LogError(result.Message, ex.ToString());
                throw;
            }
            

            return  result;
        }

        public Negocio ObtenerNegocio(string nombre)
        {


            return base.GetById(x => x.Nombre.Equals(nombre));

        }
    }
}
