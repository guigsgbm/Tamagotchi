using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Json;


namespace Tamagotchi.Services
{
    public class TamagotchiService
    {
        
        public static async Task<Creature> GetCreatureJsonObjAsync(string creatureName)
        {
            creatureName = creatureName.ToLower();

            using HttpClient client = new()
            {
                BaseAddress = new Uri($"https://pokeapi.co/api/v2/pokemon/ + {creatureName}")
            };
            Creature creature = await client.GetFromJsonAsync<Creature>(creatureName).ConfigureAwait(false);

            return creature;
        }
    }
}
