using System.Xml.Linq;

namespace _1_1_med_marie
{
    internal class Program
    {//Alle metodene i main på være static.
        static void Main(string[] args)
        {
            string name = AskForName();//kjør denne funksjonen, og gjør alt som står inni der, og ta i mot det den returnerer, og spar det i variabelen. Den lagrer kun det funksjonen returnerer.
            printWelcomeMsg(name, 29);//name her snakker med name1 placeholderen på metodelinjen printwlecomemsg(string name1).
        }
        static string AskForName()//bruker parentes til å sende med data utenfor metoden.
        {
            Console.WriteLine("Kan du skrive navnet ditt?");
            string inputName = Console.ReadLine();

            return inputName;
        }
        static void printWelcomeMsg(string name1, int ageVar)//hvis jeg ikke skal spare på noe til senere fra metoden, så trenger jeg ikke returnere noe - altså må jeg bruke void.
        {
            Console.WriteLine("Hei! Du heter: " + name1 + ageVar);

        }

        //Console.WriteLine("kan du skrive navnet ditt?");
            //string inputname = Console.Readline();
            //Console.WriteLine("hei! navnet ditt er"+ inputname )
    }
   
}