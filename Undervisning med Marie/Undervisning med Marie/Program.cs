namespace Undervisning_med_Marie
    //namespace hvis man ønsker å bruke noe derfra i et annet prosjekt, så kan man ha med using statement  = skriv: "using + namespacet sitt navn fra det prosjektet du vil. Du må hente ut noe public, du får ikke henta internal.
    //internal er for en class. Man kan også ha pblic class, men internal attributter - og da arver ikke attributtene public.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var linn = new Person("Linn", 25);
            var marie = new Person("Marie", 0);
            var kjartan = new Person("Kjartan", 356);
            var Terje = new Person("Terje", 67, "no hair");
            //var ulrik = new Person()
            //hold over parentes her så ser du hvor mange overloads som er, hvilke funksjoner du kan bruke.


            //det samme som Person marie = new Person. Men Mer vanlig å kalle var fordi det er kortere.
            var personArray = new Person[3];//du må si hvor mange plasser i array. 
            List<Person> list/*variabelNavn, kan hete hva som helst*/ = new List<Person>()//liste er mer dynamis ennn array.
            //kan skrive var list istedenfor list person list.
            {linn, marie};
            list.Add(kjartan);
            list.Add(Terje);
            //list.remove er også en funksjon

            //hvis jeg vil at alle skal intorudsere seg fra array 
            foreach (var person in list) { 
            person.IntroduceSelf();}

            /*linn.IntroduceSelf();
            marie.IntroduceSelf();*/

            //list.Find +++
            var linnObj = list.First(x => x.Name == "Linn");//Dt første treffet man finner som mathcer en egenskap.
            linnObj.Run();//kan kjøre uten parameter, selv om den egentlig kjører med parameter.
            linnObj.Run("fast");
            var aldre = list.Find(x => x.Age <= 67);
            aldre.Complain($"{aldre}");
        
        
        
        }
    }
}