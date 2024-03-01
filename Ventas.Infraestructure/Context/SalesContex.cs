
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.Domain.Entities;

namespace Ventas.Infraestructure.Context
{
    public class SalesContex : DbContext
    {
        public SalesContex(DbContextOptions<SalesContex> options) : base(options)
        {
        }

        
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Configuracion> Configuracions { get; set; }
        public DbSet<DetalleVenta> DetalleVentas { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Negocio> Negocios { get; set; }
        public DbSet<NumeroCorrelativo> NumeroCorrelativos { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Rol> Rols { get; set; }
        public DbSet<RolMenu> RolMenus { get; set; }
        public DbSet<TipoDocumentoVenta> TipoDocumentoVentas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Venta> Ventas { get; set; }





    }
}
