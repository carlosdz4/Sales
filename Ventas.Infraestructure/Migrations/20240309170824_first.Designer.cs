﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Ventas.Infraestructure.Context;

#nullable disable

namespace Ventas.Infraestructure.Migrations
{
    [DbContext(typeof(SalesContex))]
    [Migration("20240309170824_first")]
    partial class first
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.27")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Ventas.Domain.Entities.Categoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Eliminado")
                        .HasColumnType("bit");

                    b.Property<bool>("EsAtivo")
                        .HasColumnType("bit");

                    b.Property<DateTime>("FechaElimino")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaMod")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaRegistro")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdUsuarioCreacion")
                        .HasColumnType("int");

                    b.Property<int>("IdUsuarioMod")
                        .HasColumnType("int");

                    b.Property<int>("IdusuarioElimino")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Categoria");
                });

            modelBuilder.Entity("Ventas.Domain.Entities.Configuracion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Propiedad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Recurso")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Valor")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Configuracion");
                });

            modelBuilder.Entity("Ventas.Domain.Entities.DetalleVenta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<string>("CategoriaProducto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DescripcionProducto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdProducto")
                        .HasColumnType("int");

                    b.Property<int>("Idventa")
                        .HasColumnType("int");

                    b.Property<string>("MarcaProducto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Precio")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Total")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("VentaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("VentaId");

                    b.ToTable("DetalleVenta");
                });

            modelBuilder.Entity("Ventas.Domain.Entities.Menu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Controlador")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Descripcion")
                        .HasColumnType("int");

                    b.Property<bool>("Eliminado")
                        .HasColumnType("bit");

                    b.Property<bool>("EsAtivo")
                        .HasColumnType("bit");

                    b.Property<DateTime>("FechaElimino")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaMod")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaRegistro")
                        .HasColumnType("datetime2");

                    b.Property<string>("Icono")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("IdMenuPadre")
                        .HasColumnType("int");

                    b.Property<int>("IdUsuarioCreacion")
                        .HasColumnType("int");

                    b.Property<int>("IdUsuarioMod")
                        .HasColumnType("int");

                    b.Property<int>("IdusuarioElimino")
                        .HasColumnType("int");

                    b.Property<int?>("MenuPadreId")
                        .HasColumnType("int");

                    b.Property<string>("PaginaAccion")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MenuPadreId");

                    b.ToTable("Menu");
                });

            modelBuilder.Entity("Ventas.Domain.Entities.Negocio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Correo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Eliminado")
                        .HasColumnType("bit");

                    b.Property<bool>("EsAtivo")
                        .HasColumnType("bit");

                    b.Property<DateTime>("FechaElimino")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaMod")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaRegistro")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdUsuarioCreacion")
                        .HasColumnType("int");

                    b.Property<int>("IdUsuarioMod")
                        .HasColumnType("int");

                    b.Property<int>("IdusuarioElimino")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombreLogo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeroDocumento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("PorcentajeImpuesto")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("SimboloMoneda")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UrlLogo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Negocio");
                });

            modelBuilder.Entity("Ventas.Domain.Entities.NumeroCorrelativo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CantidadDigitos")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaActualizaciones")
                        .HasColumnType("datetime2");

                    b.Property<string>("Gestion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UltimoNumero")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("NumeroCorrelativo");
                });

            modelBuilder.Entity("Ventas.Domain.Entities.Producto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("CategoriaId")
                        .HasColumnType("int");

                    b.Property<string>("CodigoBarra")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Eliminado")
                        .HasColumnType("bit");

                    b.Property<bool>("EsAtivo")
                        .HasColumnType("bit");

                    b.Property<DateTime>("FechaElimino")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaMod")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaRegistro")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdCategoria")
                        .HasColumnType("int");

                    b.Property<int>("IdUsuarioCreacion")
                        .HasColumnType("int");

                    b.Property<int>("IdUsuarioMod")
                        .HasColumnType("int");

                    b.Property<int>("IdusuarioElimino")
                        .HasColumnType("int");

                    b.Property<string>("Marca")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombreImagen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Precio")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.Property<string>("UrlImagen")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaId");

                    b.ToTable("Producto");
                });

            modelBuilder.Entity("Ventas.Domain.Entities.Rol", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Eliminado")
                        .HasColumnType("bit");

                    b.Property<bool>("EsAtivo")
                        .HasColumnType("bit");

                    b.Property<DateTime>("FechaElimino")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaMod")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaRegistro")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdUsuarioCreacion")
                        .HasColumnType("int");

                    b.Property<int>("IdUsuarioMod")
                        .HasColumnType("int");

                    b.Property<int>("IdusuarioElimino")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Rol");
                });

            modelBuilder.Entity("Ventas.Domain.Entities.RolMenu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("Eliminado")
                        .HasColumnType("bit");

                    b.Property<bool>("EsAtivo")
                        .HasColumnType("bit");

                    b.Property<DateTime>("FechaElimino")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaMod")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaRegistro")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdMenu")
                        .HasColumnType("int");

                    b.Property<int>("IdRol")
                        .HasColumnType("int");

                    b.Property<int>("IdUsuarioCreacion")
                        .HasColumnType("int");

                    b.Property<int>("IdUsuarioMod")
                        .HasColumnType("int");

                    b.Property<int>("IdusuarioElimino")
                        .HasColumnType("int");

                    b.Property<int?>("MenuId")
                        .HasColumnType("int");

                    b.Property<int?>("RolId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MenuId");

                    b.HasIndex("RolId");

                    b.ToTable("RolMenu");
                });

            modelBuilder.Entity("Ventas.Domain.Entities.TipoDocumentoVenta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Eliminado")
                        .HasColumnType("bit");

                    b.Property<bool>("EsAtivo")
                        .HasColumnType("bit");

                    b.Property<DateTime>("FechaElimino")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaMod")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaRegistro")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdUsuarioCreacion")
                        .HasColumnType("int");

                    b.Property<int>("IdUsuarioMod")
                        .HasColumnType("int");

                    b.Property<int>("IdusuarioElimino")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("TipoDocumentoVenta");
                });

            modelBuilder.Entity("Ventas.Domain.Entities.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Clave")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Eliminado")
                        .HasColumnType("bit");

                    b.Property<bool>("EsAtivo")
                        .HasColumnType("bit");

                    b.Property<DateTime>("FechaElimino")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaMod")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaRegistro")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdRol")
                        .HasColumnType("int");

                    b.Property<int>("IdUsuarioCreacion")
                        .HasColumnType("int");

                    b.Property<int>("IdUsuarioMod")
                        .HasColumnType("int");

                    b.Property<int>("IdusuarioElimino")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombreFoto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RolId")
                        .HasColumnType("int");

                    b.Property<int>("Telefono")
                        .HasColumnType("int");

                    b.Property<string>("UrlFoto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("correo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("RolId");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("Ventas.Domain.Entities.Venta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("DocumentoCliente")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Eliminado")
                        .HasColumnType("bit");

                    b.Property<bool>("EsAtivo")
                        .HasColumnType("bit");

                    b.Property<DateTime>("FechaElimino")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaMod")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaRegistro")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdTipoDocumentoVenta")
                        .HasColumnType("int");

                    b.Property<int>("IdUsuario")
                        .HasColumnType("int");

                    b.Property<int>("IdUsuarioCreacion")
                        .HasColumnType("int");

                    b.Property<int>("IdUsuarioMod")
                        .HasColumnType("int");

                    b.Property<int>("IdusuarioElimino")
                        .HasColumnType("int");

                    b.Property<decimal>("ImpuestoTotal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Nombrecliente")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeroVenta")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("SubTotal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("TipoDocumentoVentaId")
                        .HasColumnType("int");

                    b.Property<decimal>("Total")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("UsuarioId")
                        .HasColumnType("int");

                    b.Property<int?>("VentaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TipoDocumentoVentaId");

                    b.HasIndex("UsuarioId");

                    b.HasIndex("VentaId");

                    b.ToTable("Venta");
                });

            modelBuilder.Entity("Ventas.Domain.Entities.DetalleVenta", b =>
                {
                    b.HasOne("Ventas.Domain.Entities.Venta", "Venta")
                        .WithMany()
                        .HasForeignKey("VentaId");

                    b.Navigation("Venta");
                });

            modelBuilder.Entity("Ventas.Domain.Entities.Menu", b =>
                {
                    b.HasOne("Ventas.Domain.Entities.Menu", "MenuPadre")
                        .WithMany()
                        .HasForeignKey("MenuPadreId");

                    b.Navigation("MenuPadre");
                });

            modelBuilder.Entity("Ventas.Domain.Entities.Producto", b =>
                {
                    b.HasOne("Ventas.Domain.Entities.Categoria", "Categoria")
                        .WithMany("Productos")
                        .HasForeignKey("CategoriaId");

                    b.Navigation("Categoria");
                });

            modelBuilder.Entity("Ventas.Domain.Entities.RolMenu", b =>
                {
                    b.HasOne("Ventas.Domain.Entities.Menu", "Menu")
                        .WithMany("RolMenus")
                        .HasForeignKey("MenuId");

                    b.HasOne("Ventas.Domain.Entities.Rol", "Rol")
                        .WithMany("RolMenus")
                        .HasForeignKey("RolId");

                    b.Navigation("Menu");

                    b.Navigation("Rol");
                });

            modelBuilder.Entity("Ventas.Domain.Entities.Usuario", b =>
                {
                    b.HasOne("Ventas.Domain.Entities.Rol", "Rol")
                        .WithMany("Usuarios")
                        .HasForeignKey("RolId");

                    b.Navigation("Rol");
                });

            modelBuilder.Entity("Ventas.Domain.Entities.Venta", b =>
                {
                    b.HasOne("Ventas.Domain.Entities.TipoDocumentoVenta", "TipoDocumentoVenta")
                        .WithMany("Ventas")
                        .HasForeignKey("TipoDocumentoVentaId");

                    b.HasOne("Ventas.Domain.Entities.Usuario", "Usuario")
                        .WithMany("Ventas")
                        .HasForeignKey("UsuarioId");

                    b.HasOne("Ventas.Domain.Entities.Venta", null)
                        .WithMany("Ventas")
                        .HasForeignKey("VentaId");

                    b.Navigation("TipoDocumentoVenta");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Ventas.Domain.Entities.Categoria", b =>
                {
                    b.Navigation("Productos");
                });

            modelBuilder.Entity("Ventas.Domain.Entities.Menu", b =>
                {
                    b.Navigation("RolMenus");
                });

            modelBuilder.Entity("Ventas.Domain.Entities.Rol", b =>
                {
                    b.Navigation("RolMenus");

                    b.Navigation("Usuarios");
                });

            modelBuilder.Entity("Ventas.Domain.Entities.TipoDocumentoVenta", b =>
                {
                    b.Navigation("Ventas");
                });

            modelBuilder.Entity("Ventas.Domain.Entities.Usuario", b =>
                {
                    b.Navigation("Ventas");
                });

            modelBuilder.Entity("Ventas.Domain.Entities.Venta", b =>
                {
                    b.Navigation("Ventas");
                });
#pragma warning restore 612, 618
        }
    }
}
