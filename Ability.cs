using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagotchi
{
    public class Ability
    {
        public Ability1 ability { get; set; }
        public class Ability1
        {
            public string name { get; set; }
            public string url { get; set; }
        }
        public bool is_hidden { get; set; }
        public int slot { get; set; }

        public string name
        {
            get { return ability.name; }
            set {}
        }
    }
}