using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ApiAuth.Controllers
{
    [ApiController]
    [Route("V1/account")]
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("Anonimo")]
        [AllowAnonymous]
        public string Anonymous() => "Anonimo!";

        [HttpGet]
        [Route("Autenticado")]
        [Authorize]
        public string Authenticated() => string.Format($"Autenticado - {User.Identity.Name}");

        [HttpGet]
        [Route("Manager")]
        [Authorize(Roles = "manager")]
        public string Manager() => "Manager";

        [HttpGet]
        [Route("Employee")]
        [Authorize(Roles = "employee")]
        public string Employee() => "Employee";

        [HttpGet]
        [Route("Group")]
        [Authorize(Roles = "employee, manager")]
        public string Group() => "Employee or Manager";
    }
}
