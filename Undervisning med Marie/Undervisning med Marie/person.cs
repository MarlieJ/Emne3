using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Undervisning_med_Marie
{
    public class Person
    {
        //egenskaper som beskriver objektet
        //ting objektet kan inneholde
        //Hva er egenskaper som kan beskrive en person?
        public string Name { get; set; }
        public int Age { get; set; }
        public string HairColor { get; set; }
        public string[] Bodyparts { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;

        }

        public Person()//hvis to ctor heter det samme, så er det overload. Det kan være man vil bruke flere eller færre parametre.
        {
            
        }
        public Person(string name, int age, string hairColor)
        {
            Name = name;
            Age = age;
            HairColor = hairColor;

        }
        //man kan skrive ctor for å få frem en constructor. 
        //Hvilke metoder burde høre til disse attributtene?
        //Hva kan objektet gjøre? Hva kan en person gjøre? Verb.
        public void IntroduceSelf()
        {
            Console.WriteLine($"Hi, my name is {Name}, and I am {Age} years old");//DollarTag foran gjør at man kan legge til barteklammer
        }
        public void Run(string pace = "slow")//hvis man vil bruke parameter men ikke alltid - default value. Kan sende med noe annet.
        {
            Console.WriteLine($"I am running{pace}");
        }
        public void Complain(string personer)
        {
            Console.WriteLine($"{personer} klager");
        }

    }
}
