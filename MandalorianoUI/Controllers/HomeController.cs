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
            IActionResult resultado;
            try
            {
                var vistaModel = new clsVistaMisionesVM();
                resultado = View(vistaModel);
            } catch (Exception e)
            {
                resultado = View("Error");
            }

            return resultado;
        }

        [HttpPost]
        public IActionResult Index(clsVistaMisionesVM vistaModel)
        {
            IActionResult resultado;

            try
            {
                // Lanzamos una excepción de forma manual para probar el bloque catch
                //throw new Exception("Excepción de prueba");

                // Obtenemos la misión seleccionada
                var misionSeleccionada = clsObtenerMisionesBL.obtenerMisionByIDBL(vistaModel.id);

                // Actualizamos el model con los datos de la misión
                vistaModel.nombre = misionSeleccionada.nombre;
                vistaModel.descripcion = misionSeleccionada.descripcion;
                vistaModel.recompensa = misionSeleccionada.recompensa;

                resultado = View(vistaModel);
            }
            catch (Exception ex)
            {
                resultado = View("Error");
            }

            return resultado;
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
