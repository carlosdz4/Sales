using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Ventas.Domain.Core;
using Ventas.Infraestructure.Context;
using Ventas.Infraestructure.Core;

namespace Ventas.Infraestructure.Dao
{
    public abstract class daoBase<TEntity> : IDaoBase<TEntity> where TEntity : class
    {


        private readonly DbSet<TEntity> entities;
        private readonly SalesContex contex;

        protected daoBase(SalesContex contex)
        {
            this.contex = contex;
            this.entities = contex.Set<TEntity>();
        }

       
        public virtual List<TEntity> GetFilterWithEntities(Func<TEntity , bool> filter)
        {
            return entities.Where(filter).ToList();
        }

        public virtual bool Exists(Func<TEntity, bool> filter)
        {
            return this.entities.Any(filter);
        }

        public virtual List<TEntity> GetAll()
        {
            return entities.ToList();
        }

        public virtual TEntity GetById(Func<TEntity, bool> filter)
        {
            return entities.First(filter);
        }

        public virtual DataResult Save(TEntity entity)
        {
            DataResult result = new DataResult();
            this.entities.Add(entity);
            result.Success = true;

            this.Commit();
            return result;
        }

        public int Commit()
        {
           return this.contex.SaveChanges();
        }


    }
}
