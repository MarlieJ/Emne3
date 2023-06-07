namespace Den_styggeste_kalkulatoren
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Hva skal vi gjøre her? Steg for seg
            Brukern må få noen instruksjoner
            Brukern må skrive inn et tall
                Vi må sjekke om brukern har skrevet noe
                    Vi burde sjekke om det brukern har skrevet bare inneholder sifre
            Brukern må skrive inn tall nr 2
                Vi må sjekke om brukern har skrevet noe
                    Vi burde sjekke om det brukern har skrevet bare inneholder sifre
            Vi legger sammen begge tallene
            Vis resultatet til brukern
            */


            Console.WriteLine("Kalkulator, skriv et tall du vil addere:");
            //string tallInput = Console.ReadLine();
            string input = Console.ReadLine(); //brukerinput

            if (input != "") //hvis brukern har skrevet noe, altså hvis det IKKE er en tom string
            {
                int tallInput1 = int.Parse(input); //konverter input til tall (int)

                Console.WriteLine($"Tallet er {tallInput1}, hva vil du addere det med?");

                string input2 = Console.ReadLine(); //brukerinput
                if (input2 != "") //hvis brukern har skrevet noe, altså hvis det IKKE er en tom string
                {
                    int tallInput2 = Convert.ToInt32(input2); //konverter input til tall (int)
                    Console.WriteLine($"Du la til {tallInput2}");
                    Console.WriteLine($"{tallInput1} + {tallInput2} = {tallInput1 + tallInput2}");
                }
            }
            else //hvis brukern IKKE har skrevet noe
            {
                 Console.WriteLine("Du har ikke skrevet noe din idiot :D"); //kjeft
            }

            /*
             problemstillinger:
                null, "" (tom string) og undefined er forskjellige verdier, for å sjekke mot alle disse gjør vi slik:
                    if (string.IsNullOrEmpty(input) == false) //denne sjekker bare om den er null eller ""
                    if (string.IsNullOrEmpty(input) == false && input != undefined) //denne sjekker det samme, men om den er undefined i tilegg
                Hvis vi gjør det over vet vi at brukern har skrevet noe, men hvordan kan vi sjekke at det brukern har skrevet faktisk er et tall?
                    if (input.All(char.IsDigit)) //sjekker mot hver eneste karakter i stringen, om IsDigit returnerer true
            */
        }
    }
}
//if(input.ToLower() == "ja")
//int tallInputV1 = int.Parse(tallInput);
//int tallInput1V1 = int.Parse(tallInput1);