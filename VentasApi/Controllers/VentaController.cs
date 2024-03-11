using Microsoft.AspNetCore.Mvc;
using Ventas.Infraestructure.Dao;
using Ventas.Infraestructure.Interfaces;

namespace VentasApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VentaController : Controller
    {

       
        private readonly IVentaDB ventaDB;

        public VentaController( IVentaDB ventaDB)
        {
           
            this.ventaDB = ventaDB;
        }


        [HttpGet("int:IdUsuario")]
        public IActionResult Venta(int IdUsuario)
        {



            var venta = ventaDB.modelVendedorVentas(IdUsuario);

            return Ok(venta);

        }

    }
}
