using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Ventas.AppService.Contracts;
using Ventas.AppService.Models;
using Ventas.Infraestructure.Exceptions;
using Ventas.Infraestructure.Interfaces;
using VentasApi.Extentions;

namespace VentasApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NegocioController : Controller
    {
        private readonly INegocioService negocioService;

        public NegocioController( INegocioService negocioService)
        {
            this.negocioService = negocioService;
        }

        [HttpGet("GetNegocio")]

        public async Task<IActionResult> GetNegocio() { 
        
            var result = await negocioService.GetNegocio();
        
          

            return Ok(result);
        }

        [HttpPost("GetNegocioByName")]

        public async Task<IActionResult> GetNegocioByName([FromBody] string name)
        {
            var result = await negocioService.GetNegocioByName(name);

            if (!result.Success) { return BadRequest(); }
            
            return Ok(result);
        }

        [HttpPost("AddNegocio")]

        public async Task<IActionResult> AddNegocio([FromBody] NegocioModel  negocioModel)
        {
            var negocio = NegocioExtentions.ConvertFromNegocioCreateToNegocioDto(negocioModel);

            var result = await negocioService.AddNegocio(negocio);



            return Ok(result);
        }

    }
}
