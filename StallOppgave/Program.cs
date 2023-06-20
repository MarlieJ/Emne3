using StallOppgave;

var hest1 = new Horse("Vero", 30);
var hest2 = new Horse("Batman", 35);
var hest3 = new Horse("Rudy", 20);
List<Horse> horses = new List<Horse>();
horses.Add(hest1);
horses.Add(hest2);
horses.Add(hest3);

Console.WriteLine("Velkommen til stallen");
Console.WriteLine($"Velg en hest du vil mate: Vero, Batman eller Rudy");
var valgtHest= Console.ReadLine();
Horse chosenHorse = horses.First(x => x.Name == valgtHest);
chosenHorse.feedHorse("eple");
Console.WriteLine($"Du skal stelle hesten nå");
chosenHorse.brushHorse();
Console.WriteLine("Nå starter hesteløpet:");

bool horseRace = true;
while (horseRace)
{
    foreach(var horseNavn in horses)
    {
        horseNavn.run();
        if (horseNavn.Distance > 3000)
        {
            horseRace = false;
        }
    }
    
}



//metode (her eller horse class)

