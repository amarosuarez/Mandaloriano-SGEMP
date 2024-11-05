using MandalorianoBL;
using MandalorianoUI.Models;
using MandalorianoUI.Models.VM;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace MandalorianoUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var vistaModel = new clsVistaMisionesVM();
            return View(vistaModel);
        }

        [HttpPost]
        public IActionResult Index(clsVistaMisionesVM vistaModel)
        {
            // Obtener la misión basada en el id seleccionado
            var misionSeleccionada = clsObtenerMisionesBL.obtenerMisionByIDBL(vistaModel.id);

            // Actualizar el ViewModel con la misión seleccionada
            vistaModel.nombre = misionSeleccionada.nombre;
            vistaModel.descripcion = misionSeleccionada.descripcion;
            vistaModel.recompensa = misionSeleccionada.recompensa;

            return View(vistaModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
