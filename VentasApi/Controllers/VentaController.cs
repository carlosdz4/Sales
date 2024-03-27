using Microsoft.AspNetCore.Mvc;
using Ventas.AppService.Contracts;
using Ventas.AppService.Models;
using Ventas.AppService.Service;
using Ventas.Infraestructure.Dao;
using Ventas.Infraestructure.Interfaces;
using VentasApi.Extentions;

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

        [HttpPost("AddVenta")]

        public async Task<IActionResult> AddVenta([FromBody] VentaModel ventaModel)
        {
            var venta = VentaExtentions.ConvertFromVentaCreateToVentaDto(ventaModel);

            var result = await this.ventaService.AddVentas(venta);

            if (!result.Success) { return BadRequest(); }

            return Ok(result);
        }

        [HttpPost("GetVentaById")]

        public async Task<IActionResult> GetVentaById([FromBody] int Id)
        {
            
            var result = await this.ventaService.GetVentasById(Id);

            if (!result.Success) { return BadRequest(); }

            return Ok(result);
        }


        //[HttpGet("int:IdUsuario")]
        //public IActionResult Venta(int IdUsuario)
        //{



        //    var venta = ventaDB.modelVendedorVentas(IdUsuario);

        //    return Ok(venta);

        //}

    }
}
