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
        [Route("[controller][action]")]
        public class PokemonController : ControllerBase
        {
            private readonly PokeApiService _pokeApiService;

            public PokemonController(PokeApiService pokeApiService)
            {
                _pokeApiService = pokeApiService;
            }

            [HttpGet("{nomePokemon}")]
            public async Task<IActionResult> GetPokemon(string nomePokemon)
            {
                var pokemon = await _pokeApiService.GetPokemonAsync(nomePokemon);

                if (pokemon == null) 
                { 
                  return NotFound();
                }

                return Ok(pokemon);
            }
        }
    }
}
