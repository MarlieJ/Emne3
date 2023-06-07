namespace NewTamagotchi
{
    internal class Program
    {
        public static bool Running = true;
        public static List<pets> Pets = new List<pets> ();
        static void Main(string[] args)
        {
            Pets.Add(new pets("Knut", 37, "Høne"));
            while (Running)
            {
                TamagotchiSimulator();
            }
        }
    }
    private static void TamagotchiSimulator()
    {
        var rnd = new Random();
        var pet = Pets[rnd.Next(pets.Count)];
        Console.WriteLine(pet._name);
        if (string.)
    }


}
/*
 * Lag en konsoll applikasjon hvor man kan generere opp flere forskjellige virtuelle kjæledyr.
Bruk constructor i klassen.
Man skal ikke ha lov til å endre data som navn, age eller noen andre characteristics utenfra klassen.


Lag funksjonalitet som gjør at man kan gi dyret mat,
bruk en overload til å gi en annen feedback til console dersom det er favorittmaten til dyret -
f eks “Hurra dette er det beste jeg vet tusen takk for maten!” istedenfor f.eks “Takk for maten”.
 */