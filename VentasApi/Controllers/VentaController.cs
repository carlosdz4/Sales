using Microsoft.AspNetCore.Mvc;
using Ventas.AppService.Contracts;
using Ventas.Infraestructure.Dao;
using Ventas.Infraestructure.Interfaces;

namespace VentasApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VentaController : Controller
    {

       
        
        private readonly IVentaService ventaService;

        public VentaController(IVentaService ventaService)
        {
           
           
            this.ventaService = ventaService;
        }

        [HttpGet("GetVentas")]

        public async Task<IActionResult> GetVentas()
        {
            var Ventas = await this.ventaService.GetVentas();

            return Ok(Ventas);
        }


        //[HttpGet("int:IdUsuario")]
        //public IActionResult Venta(int IdUsuario)
        //{



        //    var venta = ventaDB.modelVendedorVentas(IdUsuario);

        //    return Ok(venta);

        //}

    }
}
