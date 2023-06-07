using System.Reflection.Metadata.Ecma335;

namespace Oppgaver_om_variabeltilordning
{
    internal class Program
    {
        static int customerNumber = 523242;
        static string customerInfo = "KundeNavn: Kåre Berntsen";
        static bool isCustomer = true;
        static void Main(string[] args)
        {
            int int1 = 1;
            long long1 = 9223372036854775807;
            float float1 = 1.01f;
            double double1 = 1.02;
            decimal dec1 = 1.0234m;
            string string1 = "Hallo";
            char char1 = 'B';
            bool bool1 = true;


            int a = 5;
            decimal b = 3.0m;
            var summerer1 = a + b;

            Console.WriteLine( summerer1);

            Console.WriteLine( customerInfo );
            var count = GetCounter();
            var something = 0;
        }

        static int GetCustomerNumber()//Denne metoden skal returnere int.
        {
            
            return customerNumber; //Her har vi kalt på en variabel som inneholder int, da er datamaskinen fornøyd :D
        }
        static int GetCounter()
        {
            int counter = 0;
            counter = counter + 5;
            return counter; 

    }
}