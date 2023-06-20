namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Skriv inn en tekst");
            string tekst = Console.ReadLine();
            tekst = tekst.ToLower();
            int teller = 0;

            if (tekst == "a" ||
                tekst == "e" ||
                tekst == "i" ||
                tekst == "o" ||
                tekst == "u" ||
                tekst == "y" ||
                tekst == "æ" ||
                tekst == "ø" ||
                tekst == "å")
            {
                Console.WriteLine($"Det var {teller++} vokaler i teksten din");
            }
            else { };
            return;
        }
    }
}