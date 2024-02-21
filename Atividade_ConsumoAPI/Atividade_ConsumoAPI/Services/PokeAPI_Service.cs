using Atividade_ConsumoAPI.Poke;

namespace Atividade_ConsumoAPI.Services
{
    public class PokeAPI_Service
    {
        public class PokeApiService
        {
            private readonly HttpClient _httpClient;

            public PokeApiService(HttpClient httpClient)
            {
                _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
                _httpClient.BaseAddress = new Uri("https://pokeapi.co/api/v2/");
            }

            public async Task<Pokemon> GetPokemonAsync(string nomePokemon)
            {
                try
                {
                    var response = await _httpClient.GetFromJsonAsync<Pokemon>($"https://pokeapi.co/api/v2/pokemon/{nomePokemon.ToLower()}");

                    return response;
                }
                catch (HttpRequestException)
                {
                    throw;
                }
            }
        }

    }
}
