namespace Uke_1_oppgave //kan linke til denne senere i andre filer med "using Uke_1_oppgave" (dependency til annet prosjekt)
{
    internal class Program //program er en intern klasse, kan kun brukes i prosjektet jeg har nå 
    {
        static void Main(string[] args)
        {
            while (true)
            {
                HobbyGenerator();
            }
        }

        static void HobbyGenerator()
        {
            var hobbyer = new string[] {
                " elsker å strikke",
                " danser disco når ingen ser på",
                " sparker baller",
                " bygger store legoslott",
                " prøver å lære seg å svømme" //må ikke være komma på den siste. Men det kan ¯\_(ツ)_/¯
            };

            Console.WriteLine("Who would like a new hobby?"); //Who would like a new hobby?
            var navn = Console.ReadLine(); //Når du trykker enter, vil den lese det du skrev på linja, og "var navn" vil få verdien [det som du skrev]
            if (navn == "exit") Environment.Exit(0);

            var random = new Random(); //vi lager en ny "instanse" av Random klassen
            var tilfeldigTall = random.Next(4); //Gir et tilfeldig tall: maks 4 (kan ikke være mindre en 0 uansett)

            var setningenMin = navn + hobbyer[tilfeldigTall];
            Console.WriteLine(setningenMin);
        }

        /*
         javascript     frontend (javascript)
         python         backend (veldig lett/simpelt, men kraftig. Dårlig på store skala applikasjoner)
         Java           frontend + backend (10/90)
         C / C++        backend (autistenes favoritt)
         PHP            backend (mye database håndtering)
         C#             frontend + backend (40/60)
         */
    }
}