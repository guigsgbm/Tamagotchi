using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagotchi
{
    public class DefaultCreatures
    {

        public static List<string> defaultCreatures = new List<string>();

        
        static DefaultCreatures()
        {
            defaultCreatures.Add($"Charmander");
            defaultCreatures.Add($"Bulbasaur");
            defaultCreatures.Add($"Venusaur");
        }
        

        public static void GetCreatures()
        {
            foreach (var creature in defaultCreatures)
            {
                Console.WriteLine($"{defaultCreatures.IndexOf(creature) +1} - {creature}");
            }
        }


        
    }
}
