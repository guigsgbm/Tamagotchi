using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagotchi
{
    public class Stat
    {
            public int base_stat { get; set; }
            public int effort { get; set; }
            public Stat1 stat { get; set; }

        public class Stat1
        {
            public string name { get; set; }
            public string url { get; set; }
        }
        
        public string name
        {
            get { return stat.name; }
            set { }
        }
    }
}
