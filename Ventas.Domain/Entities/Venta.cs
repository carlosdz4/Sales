﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.Domain.Core;

namespace Ventas.Domain.Entities
{
    public class Venta 
    {
        public Venta()
        {
            FechaRegistro = DateTime.Now;
        }
        [Key]
        public int Id { get; set; }
        public string? NumeroVenta { get; set; }
        public int IdTipoDocumentoVenta { get; set; }

        public virtual TipoDocumentoVenta? TipoDocumentoVenta { get; set; }
        public int IdUsuario { get; set; }

        public virtual  Usuario? Usuario { get; set; }
        public string? DocumentoCliente { get; set; }
        public string? Nombrecliente { get; set; }

        public decimal SubTotal { get; set; }

        public decimal ImpuestoTotal { get; set; }

        public decimal Total { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int IdUsuarioCreacion { get; set; }

       


    }
}
