namespace HobbyKalkulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] hobbies = { "kunstmaling", "svømming", "å lage plastelina", "perle-spiser" };
            Random rnd = new();//For å få tilgang til metodene i classen, så må jeg instansiere classen en første gang i dokumentet. Vi assigner den til en variabel, så vi kan bruke den videre. 
            Random rnd1 = new Random();
            var rnd2 = new Random();//alle de 3 over er det samme/gjør det samme.
            int rndNum = rnd.Next(hobbies.Length);//Hvorfor må jeg ha det her? Føles som jeg lager oveflødig kode.
            

            Console.WriteLine("Hei! Er du klar for å finne din nye hobby? Si meg ditt navn: ");
            string name = Console.ReadLine();
            Console.WriteLine("Kult " + name + " ,vi du at jeg skal fortelle deg hvilken hobby som kan passe for deg?");
            string answer = Console.ReadLine();

            if (answer == "nei" || answer == "Nei") //du må ha med hele linja før || tegnet, etter "eller"tegnet.
            {
                Console.WriteLine("Det var synd, kom tilbake en annen dag hvis du vil.");
            }
            else
            {
                Console.WriteLine("Spennende, jeg tror " + hobbies[rndNum] + " kunne passe for deg!");
            }

        }
    }
}