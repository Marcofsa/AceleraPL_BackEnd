using Microsoft.AspNetCore.Mvc;

namespace ControleBiblioteca.Controllers
{
    public class LivroController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
