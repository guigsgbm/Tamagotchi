using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagotchi.Models
{
    public static class MyAccount
    {
        private static string _username { get; set; }
        public static string Username
        {
            get { return _username; }
            set { _username = value; }
        }
        public static List<Creature> Creatures { get; set; }

        public static void SetCreature(Creature creature)
        {
            Creatures.Add(creature);
        }

    }
}
