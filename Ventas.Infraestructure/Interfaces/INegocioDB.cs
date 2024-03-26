using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.Domain.Entities;
using Ventas.Infraestructure.Core;

namespace Ventas.Infraestructure.Interfaces
{
    public interface INegocioDB : IDaoBase<Negocio>
    {
    }
}
