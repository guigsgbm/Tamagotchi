using System.Net;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using Tamagotchi;

string URL;
URL = "https://pokeapi.co/api/v2/pokemon/pikachu";

HttpClient client = new HttpClient();
HttpResponseMessage response = await client.GetAsync(URL);
response.EnsureSuccessStatusCode();
string responseBody = await response.Content.ReadAsStringAsync();


Creature creature = JsonSerializer.Deserialize<Creature>(responseBody);

Console.WriteLine($"Nome: {creature.name}");
Console.WriteLine($"Altura: {creature.height}");
Console.WriteLine($"Peso: {creature.weight}");

foreach(Ability ability in creature.abilities)
{
    Console.WriteLine(ability.name);
}

foreach(Stat stat in creature.stats)
{
    Console.WriteLine($"{stat.name}: {stat.base_stat}");
}

foreach(Tamagotchi.Type type in creature.types)
{
    Console.WriteLine($"Tipo: {type.name}");
}

Console.ReadLine();
