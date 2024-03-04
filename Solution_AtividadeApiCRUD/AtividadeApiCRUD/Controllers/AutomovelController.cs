using Microsoft.AspNetCore.Mvc;

namespace AtividadeApiCRUD.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AutomovelController : ControllerBase
    {
        private readonly ILogger<AutomovelController> _logger;

        public AutomovelController(ILogger<AutomovelController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "MinhaAPI/{Marca}")]
        public IActionResult Get([FromRoute]string Marca, [FromBody]string Veiculo, [FromHeader]string key)
        {
            return Ok();
        }

        [HttpPut(Name = "MinhaAPI2")]
        public IActionResult Put()
        {
            return Ok();
        }

        [HttpDelete(Name = "MinhaAPI")]
        public IActionResult Delete()
        {
            return Ok();
        }
    }
}
