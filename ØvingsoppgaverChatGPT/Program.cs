Console.WriteLine("Hello You :D What's your name?");
string inputName = Console.ReadLine();
Console.WriteLine($"Hello {inputName}");
Console.WriteLine("Har du lyst til å regne litt med meg? Skriv to tall som du vil addere, trykk enter imellom hvert tall :)");
int tall1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("+");
string taVarePåTallet = Console.ReadLine();
int tall2 = int.Parse(taVarePåTallet);

Console.WriteLine($"{tall1} + {tall2} = {tall1 + tall2}");
Console.WriteLine("Nå skal vi ha det litt gøy og gjøre " +
    "3 andre matematiske operasjoner med tallene du la inn: subtraksjon, multiplikasjon og divisjon");
int subtraksjon = tall1 - tall2;
int multiplikasjon = tall1 * tall2;
int divisjon = tall1 / tall2;

Console.WriteLine($"{tall1} - {tall2} = {subtraksjon}");
Console.WriteLine($"{tall1} * {tall2} = {multiplikasjon}");
Console.WriteLine($"{tall1} / {tall2} = {divisjon}");




Console.WriteLine("Trykk enter for å avslutte programmet");
Console.ReadKey();
