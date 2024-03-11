
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>()
                .HasMany(e => e.Ventas)
                .WithOne(e => e.Usuario)
                .HasForeignKey(e => e.IdUsuario)
                .IsRequired();
        }



        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Configuracion> Configuracion { get; set; }
        public DbSet<DetalleVenta> DetalleVenta { get; set; }
        public DbSet<Menu> Menu { get; set; }
        public DbSet<Negocio> Negocio { get; set; }
        public DbSet<NumeroCorrelativo> NumeroCorrelativo { get; set; }
        public DbSet<Producto> Producto { get; set; }
        public DbSet<Rol> Rol { get; set; }
        public DbSet<RolMenu> RolMenu { get; set; }
        public DbSet<TipoDocumentoVenta> TipoDocumentoVenta { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Venta> Venta { get; set; }





    }
}
