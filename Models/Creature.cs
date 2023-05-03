using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tamagotchi.Services;

namespace Tamagotchi
{
    public class Creature
    {
        private Random random = new Random();

        public Creature()
        {
            this._happiness = random.Next(20,100);
            this._hunger = random.Next(20, 100);
            this._rest = random.Next(20, 100);
        }
        

        public Ability[] abilities { get; set; }
        public string name { get; set; }
        public Stat[] stats { get; set; }
        public Type[] types { get; set; }
        public int height { get; set; }
        public int weight { get; set; }



        private int _hunger;
        public int Hunger
        {
            get { return this._hunger; }
            set { this._hunger = value; }
        }

        private int _happiness;
        public int Happiness
        {
            get { return this._happiness; }
            set { this._happiness = value; }
        }

        private int _rest;
        public int Rest
        {
            get { return this._rest; }
            set { this._rest = value; }
                
        }
    }
}