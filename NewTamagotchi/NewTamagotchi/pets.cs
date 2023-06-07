using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace NewTamagotchi
{
    internal class pets
    {
        private string _name;
        private int _age;
        private string _species;
        private int _stomachFullness;



        public pets(string name, int age, string sepcies)
        {
            _name = name;
            _age = age;
            _species = sepcies;
            _stomachFullness = 0;

        }
        private void Feed()
        {
            _stomachFullness++;
            Console.WriteLine("Takk for maten.");
        }
        private void Feed(bool favoriteFood)
        {
            _stomachFullness += 2;
            Console.WriteLine("Hurra dette er det beste jeg vet, tusen takk for maten!");

        }

        /*
         var pets = new Pets("Knut", "37", "høne");
        pets.Feed()
         */
    }
}
