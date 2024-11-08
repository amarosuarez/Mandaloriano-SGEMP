using MandalorianoBL;
using MandalorianoENT;
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
                clsVistaMisionesVM vistaModel = new clsVistaMisionesVM();
                resultado = View(vistaModel);
            } catch (HourException h)
            {
                ViewBag.Error = h.Message;
                resultado = View("FueraHora");
            }
               catch (Exception e)
            {
                resultado = View("Error");
            }

            return resultado;
        }

        [HttpPost]
        public IActionResult Index(int id)
        {
            IActionResult resultado;

            try
            {
                // Lanzamos una excepci�n de forma manual para probar el bloque catch
                //throw new Exception("Excepci�n de prueba");

                // Obtenemos la misi�n seleccionada
                clsMisionENT misionSeleccionada = clsObtenerMisionesBL.obtenerMisionByIDBL(id);

                clsVistaMisionesVM vistaModel = new clsVistaMisionesVM(misionSeleccionada);

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
