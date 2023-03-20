using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagotchi
{
    public class Type
    {
        public int slot { get; set; }
        public Type1 type { get; set; }

        public class Type1
        {
            public string name { get; set; }
            public string url { get; set; }
        }

        public string name
        {
            get { return type.name; }
            set { }
        }
    }
}