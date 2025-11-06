using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using PPA_Semana09.Models;
using PPA_Semana09.Services;
using System.Threading.Tasks;

namespace PPA_Semana09.Controllers
{
    public class RegistroController : Controller
    {
        private readonly ICarrerasProvider _carreras;

        public RegistroController(ICarrerasProvider carreras)
        {
            _carreras = carreras;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var carreras = await _carreras.ObtenerCarrerasAsync();
            ViewBag.Carreras = new SelectList(carreras);
            return View(new RegistroViewModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(RegistroViewModel model)
        {
            var carreras = await _carreras.ObtenerCarrerasAsync();
            ViewBag.Carreras = new SelectList(carreras);

            if (!ModelState.IsValid) return View(model);

            TempData["Ok"] = "¡Datos validados! (Pendiente guardar en BD)";
            return RedirectToAction(nameof(Confirmacion));
        }

        public IActionResult Confirmacion()
        {
            ViewBag.Mensaje = TempData["Ok"];
            return View();
        }
    }
}
