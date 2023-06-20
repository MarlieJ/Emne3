using System.Diagnostics;

Console.Write("Gyldig tips: \r\n - H, U, B\r\n - halvgardering: HU, HB, UB\r\n - helgardering: HUB\r\nHva har du tippet for denne kampen? ");
string bet = Console.ReadLine();
int homeGoals = 0;
int awayGoals = 0;
bool matchIsRunning = true;
while (matchIsRunning)
{
    Console.Write("Kommandoer: \r\n - H = scoring hjemmelag\r\n - B = scoring bortelag\r\n - X = kampen er ferdig\r\nAngi kommando: ");
    string command = Console.ReadLine();
    matchIsRunning =( command != "X"); //denne condition er true. Så lenge det ikke blir skrevet X er den true, og linjene skal leses videre.
    //en annen måte å skrive det på: if (command == "X") matchIsRunning = false;
    if (command == "H") homeGoals++;
    else if (command == "B") awayGoals++;
    Console.WriteLine($"Stillingen er {homeGoals}-{awayGoals}.");
}

string result = homeGoals == awayGoals ? "U" : homeGoals > awayGoals ? "H" : "B";//?
bool isBetCorrect = bet.Contains(result);//dette er en bool - contains altså. Inneholder den dette? True||false. Variabelen som heter isbetcorrect har fått en bool verdi/er en bool. 
string isBetCorrectText = isBetCorrect ? "riktig" : "feil"; //Det er alltid true først.
Console.WriteLine($"Du tippet {isBetCorrectText}");

/*
//Ternery operator (en if/else på én linje)
var result = homeGoals == awayGoals ? "U" : homeGoals > awayGoals ? "H" : "B";
// result = (er dette true-------- ? Ja, ellers : (er dette true  ? Ja, ellers: ))

//Kan også skriver slik:
var result = "";
if (homeGoals == awayGoals) result = "U";
else if (homeGoals > awayGoals) result == "H";
else if (homeGoals < awayGoals) result == "B";
*/


//Loops og hvordan de kjører og viktigst hvordan de stopper: 

//For each: den kjører et visst antall ganger basert på en samlings lengde (liste, array +++).
//Hvis arrayet inneholder 10 elementer, så kjører den 10 ganger og ikke fler. Da stopper den.


//For loop: den er nesten lik som for each, men du har mer kontroll.
//Iterasjon: en gjennom"lesning" av en loop.
//Du kan hente ut hvor i loopen du er, og spesifisere hvordan den skal lese loopen. 
// i ++ kunne vært i + 2 f eks. Her kan man f eks skrive mye greier for å kontrollere loopen, men det kan man ikke i for each.
////Exit-condition: for loop (i index; condition;  i ++) hvis condition ikke lenger er true, så skal loopen stoppe.
//For(var i=0; i<10(dette er en bool); i++) DVS condition her er at i skal være mindre enn 10, og så lenge den er det, så kjører den videre. Den stopper når den er mer enn 10.

//While-loop: den kjører så lenge en condition = true. 
//Så fort den ikke er det så vil den stoppe, den kjører ikke ferdig all koden inni loopen, den bare slutter med en gang. 
//Etter hver eneste linje i koden så sjekker den om condition fortsatt = true.
//Vi vil ikke ha denne når vi vil forsikre oss om at koden i loopen kjører ferdig før loopen stopper.
//Denne stopper når condition er false, stopper på denne linja i iterasjonen.

//Do while - loop:
//do
//{
//}
//while (true)
//Denne vil bare sjekke om condition er true når den har kjørt gjennom hele loopen.
//Hvis du endrer condition til false ila loopen, vil den fortsatt kjøre iterasjonen(en gjennomkjøring av en loop) ferdig.
//Denne stopper når condition er false etter iterasjonen er kjørt ferdig.

//VIKTIG: 
//Alle loops må ha en exit condition.

//NØKKELORD: 
//return - i en loop så gjør den noe annet enn det den vanligvis gjør. Den stopper metoden som loopen ligger inne i. Bare return;
//break - stopper loopen, ikke metoden.
//continue - stopper den iterasjonen du er på i loopen, og kan evt gå til neste.