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
    public class UsuarioDB : daoBase<Usuario>, IUsuarioDB
    {
        private readonly SalesContex contex;

        public UsuarioDB(SalesContex contex) : base(contex)
        {
            this.contex = contex;
        }
    }
}
