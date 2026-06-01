using System;
using System.IO;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace TE23B_API_Klient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("=== API-Klient Demo ===\n");

            // 1. Serialisering - Objekt till JSON
            Santa santa = new Santa()
            {
                Name = "Nikolaus",
                Beard = 2,
                NumberOfPresents = 999999
            };

            string jsonString = JsonSerializer.Serialize(santa);
            Console.WriteLine("=== Serialiserad JSON ===");
            Console.WriteLine(jsonString);

            File.WriteAllText("santa.json", jsonString);

            // 2. Deserialisering - JSON till Objekt
            string readJson = File.ReadAllText("santa.json");
            Santa loadedSanta = JsonSerializer.Deserialize<Santa>(readJson);

            Console.WriteLine("\n=== Deserialiserad Santa ===");
            Console.WriteLine($"Namn: {loadedSanta.Name}");
            Console.WriteLine($"Skägg: {loadedSanta.Beard}");
            Console.WriteLine($"Antal presenter: {loadedSanta.NumberOfPresents}");

            // 3. Hämta Pokémon från PokeAPI
            await GetPokemonAsync("snorlax"); 

            Console.ReadKey();
        }

        // Hjälpmetod för att hämta Pokémon
        static async Task GetPokemonAsync(string pokemonName)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://pokeapi.co/api/v2/");

                HttpResponseMessage response = await client.GetAsync($"pokemon/{pokemonName}");

                if (response.IsSuccessStatusCode)
                {
                    string apiJson = await response.Content.ReadAsStringAsync();

                    var options = new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    };

                    Pokemon pokemon = JsonSerializer.Deserialize<Pokemon>(apiJson, options);

                    Console.WriteLine($"\n=== Pokémon Info: {pokemonName.ToUpper()} ===");
                    Console.WriteLine($"Namn: {pokemon.Name}");
                    Console.WriteLine($"Höjd: {pokemon.Height}");
                    Console.WriteLine($"Vikt: {pokemon.Weight}");
                }
                else
                {
                    Console.WriteLine($"Kunde inte hämta {pokemonName}: {response.StatusCode}");
                }
            }
        }
    }

    public class Santa
    {
        public string Name { get; set; }
        public int Beard { get; set; }
        public int NumberOfPresents { get; set; }
    }

    public class Pokemon
    {
        public string Name { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
    }
}