using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Ventas.Domain.Core;
using Ventas.Infraestructure.Core;

namespace Ventas.Infraestructure.Dao
{
    public abstract class daoBase<TEntity> : IDaoBase<TEntity> where TEntity : class
    {

        private List<TEntity> entities;

        protected daoBase()
        {
            this.entities = new List<TEntity>();
        }
        public virtual bool Exists(Func<TEntity, bool> filter)
        {
            return this.entities.Any(filter);
        }

        public virtual List<TEntity> GetAll()
        {
            return entities;
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
            return result;
        }

        
    }
}
