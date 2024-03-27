using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VentaWeb.Models;
using VentaWeb.Services;

namespace VentaWeb.Controllers
{
    public class VentaController : Controller
    {
        private readonly IVentaService ventaService;

        public VentaController(IVentaService ventaService)
        {
            this.ventaService = ventaService;
        }

        // GET: VentaController
        public async Task<IActionResult> Index()
        {
            var result = await this.ventaService.GetVentas();

            if (!result.success)
            {
                ViewBag.message = result.message;
                return View();
            }

            var Venta = result.data;

            return View(Venta);
        }

        // GET: VentaController/Details/5
        public async Task<IActionResult> Details(VentaSearch ventaid)
        {
            var result = await this.ventaService.VentaById(ventaid);

            if (!result.success)
            {
                ViewBag.message = result.message;
                return View();
            }

            var Venta = result.data;

            return View(Venta);

            
        }

        public ActionResult Create()
        {
            return View();
        }
        // GET: VentaController/Create
        [HttpPost]
        public async Task<IActionResult> Create(VentaCreateModel ventaModel)
        {
            var result = await this.ventaService.VentaAdd(ventaModel);
            if (!result.success)
            {
                ViewBag.message = result.message;
                return View();
            }
            return RedirectToAction("Index");
           
        }

        
        
    }
}
