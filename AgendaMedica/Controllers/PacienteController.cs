using Microsoft.AspNetCore.Mvc;

namespace AgendaMedica.Controllers
{
    public class PacienteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
