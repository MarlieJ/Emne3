using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bossfight
{
    
    

    internal class GameCharacter
    {
        public int Health { get; private set; } //dette er en vanlig innkapslings-property
        int Strength;//"property" i classen, som fortsatt er en int
        int Stamina;
        string Name;
        int startStamina;
        public GameCharacter(int h, int str, int sta, string name)
        {
            Health = h;
            Strength = str; 
            Stamina = sta;
            Name = name;
            startStamina = sta;
        }
        public void Fight(GameCharacter opponent)
        {
            if (Stamina >= 10)
            {
                //hero          boss
                opponent.LooseHealth(Strength);//det er fortsatt boss-GameCharacteren som er parentesen
                                               //hero skal miste liv tilsvarende styrken som jeg eier
                Console.WriteLine($"{Name} attacked {opponent.Name}, {opponent.Name} now has {opponent.Health} left. ");
                Stamina -= 10;
            }
            else { Recharge(); }
        }
        public void Recharge()
        {
            Stamina = startStamina;
            Console.WriteLine($"{Name} tried to attack, but is out of stamina: recharging.");
        }
        public void LooseHealth(int strength)
        {
            if (Health > 0)
            {
                Health -= strength; //health = health  - strength
            }
            else { Console.WriteLine(Name + "won the fight"); }
        }
    }
}
