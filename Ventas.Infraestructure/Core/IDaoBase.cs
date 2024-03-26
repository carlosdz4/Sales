using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Ventas.Domain.Core;

namespace Ventas.Infraestructure.Core
{
   public interface IDaoBase<TEntity> where TEntity : class 
    {
        DataResult Save(TEntity entity);

        List<TEntity> GetAll();

        List<TEntity> GetFilterWithEntities(Func<TEntity, bool> filter);
        TEntity GetById(Func<TEntity, bool> filter);

        int Commit();
        bool Exists(Func<TEntity , bool> filter);
    }
    
}
