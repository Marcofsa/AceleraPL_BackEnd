using Microsoft.AspNetCore.Mvc;
using static Atividade_ConsumoAPI.Services.PokeAPI_Service;

namespace Atividade_ConsumoAPI.Controllers
{
    public class PokeAPIController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [ApiController]
        [Route("[controller]")]
        public class PokemonController : ControllerBase
        {
            private readonly PokeApiService _pokeApiService;

            public PokemonController(PokeApiService pokeApiService)
            {
                _pokeApiService = pokeApiService;
            }

            [HttpGet("{name}")]
            public async Task<IActionResult> GetPokemon(string name)
            {
                var pokemon = await _pokeApiService.GetPokemonAsync(name);
                if (pokemon == null)
                    return NotFound();

                return Ok(pokemon);
            }
        }
    }
}
