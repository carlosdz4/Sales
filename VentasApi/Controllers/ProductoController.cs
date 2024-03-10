using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Ventas.Infraestructure.Interfaces;
using Ventas.Infraestructure.Model;

namespace VentasApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductoController : Controller
    {
        private readonly IProductoDB productoDB;

        public ProductoController( IProductoDB productoDB )
        {
            this.productoDB = productoDB;
        }

        [HttpGet]
        public IActionResult GetAll() {

            

          var  products = productoDB.GetProducts();

            return Ok(products);

        }

    }
}
