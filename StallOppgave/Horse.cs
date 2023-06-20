using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StallOppgave
{
    internal class Horse
    {
        public string Name;
        public int Speed;
        public int Distance = 0;
        public Horse(string name, int speed)
        {
            Name = name;
            Speed = speed;
        }

        public void feedHorse(string food)
        {
            Console.WriteLine($"You are feeding the horse: {food}");
        }
        public void brushHorse()
        {
            Console.WriteLine($"You are brushing {Name}");
        }
        public void run()
        {
            Distance += Speed;
            Console.WriteLine($"{Name} has run {Distance}");

        }
    }
    
}
