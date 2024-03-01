using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.Domain.Entities;
using Ventas.Infraestructure.Core;
using Ventas.Infraestructure.Interfaces;

namespace Ventas.Infraestructure.Dao
{
    internal class CategoriaDB : daoBase<Categoria> , ICategoriaDB
    {
        public override DataResult Save(Categoria entity)
        {
            DataResult result = new DataResult();

            //logica para alamcenar la categoria

            return result;
        }
    }
}
