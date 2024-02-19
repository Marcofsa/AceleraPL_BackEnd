using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    public class EmprestimoController : Controller
    {
        Data.ContextoDB contexto = new Data.ContextoDB();

        public IActionResult Index()
        {
            var emprestimos = contexto.Emprestimos.ToList();

            return View(emprestimos);
        }
    }
}
