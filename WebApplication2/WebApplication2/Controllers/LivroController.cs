using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    public class LivroController : Controller
    {
        Data.ContextoDB contexto = new Data.ContextoDB();

        public IActionResult Index()
        {
            var livros = contexto.Livros.ToList();

            return View(livros);
        }
    }
}
