using MeuPrimeiroASPNET.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace MeuPrimeiroASPNET.Controllers
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
            return View();
        }

        public IActionResult Sobre()
        {
            HomeModel minhaModel =  new HomeModel();
            minhaModel.Sobre = "Aqui você poderá ter mais informações sobre mim!";
            minhaModel.Nome = "Josefino";
            minhaModel.FotoPerfil = "https://th.bing.com/th/id/OIP.DMDfV6N9jhYjyQCLGLlH5QHaLH?rs=1&pid=ImgDetMain0";

            return View(minhaModel);
        }

        public IActionResult Contatos()
        {
            HomeModel minhaModel = new HomeModel();
            minhaModel.Cidade = "São Paulo";
            minhaModel.Nome = "Josefino Souza";
            minhaModel.Email = "josefino@gmail.com";
            minhaModel.Fone = "(11) 9 9999-1234";
            minhaModel.Idade = 27;

            return View(minhaModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}