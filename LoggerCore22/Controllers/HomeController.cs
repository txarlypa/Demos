using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using TestLoggerCore22.Errors;
using TestLoggerCore22.Models;
namespace TestLoggerCore22.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger _logger;
        //private readonly Errors.Errors _errors;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            //_errors = errors;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            //_logger.LogInformation("Mi primer log de informacion, by CP");
            //_logger.LogError("Mi primer log de error, by CP");
            ////_errors.Add("44. Error añadido desde la clase de errores");
            //StaticErrors.Add("Error añadido desde mi clase estatica", _logger);

            using (_logger.BeginScope("Mi mensaje personalizado", "Nombre:Carlos", "Apellido1:Para", "Apellido2:Gordo"))
            {
                _logger.LogInformation("Este es mi mensaje enriquecido");
            }

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
