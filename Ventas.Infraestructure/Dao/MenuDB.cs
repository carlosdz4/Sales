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
    internal class MenuDB : daoBase<Menu>, IMenuDB
    {
        private readonly SalesContex contex;

        public MenuDB(SalesContex contex) : base(contex)
        {
            this.contex = contex;
        }
    }
}
