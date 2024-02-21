
using Atividade_ConsumoAPI.Poke;
using Microsoft.AspNetCore.Mvc;

namespace Atividade_ConsumoAPI
{
    internal class PokeApiClient
    {
        static async Task Main(string[] args)
        {
            string baseUrl = "https://pokeapi.co/api/v2/";

            using (HttpClient client = new HttpClient())
            {

                client.BaseAddress = new Uri(baseUrl);

                try
                {
                    HttpResponseMessage response = await client.GetAsync("pokemon");

                    if (response.IsSuccessStatusCode)
                    {
                        string responseBody = await response.Content.ReadAsStringAsync();

                        Console.WriteLine(responseBody);
                    }
                    else
                    {
                        Console.WriteLine("Falha na solicitação. Status: " + response.StatusCode);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ocorreu um erro: " + ex.Message);
                }
            }
        }
    }
}