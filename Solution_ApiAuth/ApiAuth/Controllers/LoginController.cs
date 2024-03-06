using ApiAuth.Repository;
using ApiAuth.Services;
using Microsoft.AspNetCore.Mvc;

namespace ApiAuth.Controllers
{
    [ApiController]
    [Route("V1/auth")]
    public class LoginController : Controller
    {
        [HttpPost]
        [Route("login")]
        public async Task<ActionResult<dynamic>> Authenticate([FromBody] User model)
        {
            var user = UserRepository.Get(model.UserName, model.Password);

            if (user is null)
            {
                return NotFound(new { message = "User or Password are wrong." });
            }

            var token = TokenServices.GenerateToken(user);

            user.Password = " ";
            return new
            {
                user = user,
                token = token,
            };
        }
    }
}
