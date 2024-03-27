using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VentaWeb.Models;
using VentaWeb.Services;

namespace VentaWeb.Controllers
{
    public class NegocioController : Controller
    {
        private readonly INegocioService negocioService;

        public NegocioController(INegocioService negocioService)
        {
            this.negocioService = negocioService;
        }

        // GET: NegocioController
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var result = await this.negocioService.GetNegocios();

            if (!result.success)
            {
                ViewBag.message = result.message;
                return View();
            }

            var Negocio = result.data;

            return View(Negocio);
        }

        // GET: NegocioController/Details/5

        
        public async Task<IActionResult> Details( NegocioSearch search)
        {
            var result = this.negocioService.GetNegocioByName(search).Result;

             if (!result.success)
            {
                ViewBag.message = result.message;
                return View();
            }

            var Negocio = result.data;

            return View(Negocio);
        }

        // GET: NegocioController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NegocioController/Create
        [HttpPost]
        
        public async Task<IActionResult> Create(NegocioModel negocioModel)
        {
            
            var result = await this.negocioService.SaveNegocio(negocioModel);


                 if (!result.success)
            {
                ViewBag.message = result.message;
                return View();
            }

            

            return RedirectToAction("Index");
            
        }

        // GET: NegocioController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: NegocioController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: NegocioController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: NegocioController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
