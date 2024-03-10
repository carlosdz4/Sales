using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.Domain.Entities;
using Ventas.Infraestructure.Context;
using Ventas.Infraestructure.Core;
using Ventas.Infraestructure.Interfaces;

namespace Ventas.Infraestructure.Dao
{
    internal class RolMenuDB : daoBase<RolMenu>, IRolMenuDB
    {
        private readonly SalesContex contex;

        public RolMenuDB(SalesContex contex) : base(contex)
        {
            this.contex = contex;
        }
    }
}
