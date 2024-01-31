using Microsoft.AspNetCore.Mvc;

namespace ControleBiblioteca.Controllers
{
    public class EmprestimoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
