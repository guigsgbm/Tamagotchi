using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagotchi
{
    public class Iterations
    {

        Creature creature = new Creature();

        public static void PlayWithCreature(Creature creature)
        {
            creature.Happiness += 20;
            creature.Rest -= 15;
        }

        public static void RestCreature(Creature creature)
        {
            creature.Rest += 20;
            creature.Happiness += 5;
            creature.Hunger -= 500;
        }

        public static void FeedCreature(Creature creature)
        {
            creature.Hunger += 20;
            creature.Happiness += 5;
            creature.Rest -= 10;
        }


    }
}
