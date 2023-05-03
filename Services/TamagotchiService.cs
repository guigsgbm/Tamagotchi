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

        public static Creature GetCreatureJsonObjAsync(string creatureName)
        {
            creatureName = creatureName.ToLower();

            using HttpClient client = new()
            {
                BaseAddress = new Uri($"https://pokeapi.co/api/v2/pokemon/ + {creatureName}")
            };
            var creature = client.GetFromJsonAsync<Creature>(creatureName);

            return creature.Result;
        }
    }
}
