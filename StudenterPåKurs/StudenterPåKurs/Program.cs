//using StudenterPåKurs;

using System.Collections.Generic;
using StudenterPåKurs;

Students stud1 = new Students("Heibert", 42, "Radiobilkjøring");
Students stud2 = new Students("Ronny", 33, "Radiobilkjøring");
var stud3 = new Students("Kari", 82, "Strikkekurs");
var stud4 = new Students("Bjørg", 75, "Strikkekurs");

List<Students> studentList = new List<Students>() {stud1,stud2,stud3,stud4};




var NyStudent = new Students();

Console.WriteLine("Legg til student");
Console.WriteLine("Hva er studentens navn?");
NyStudent.Name = Console.ReadLine();
Console.WriteLine("Hva er studentens alder?");
NyStudent.Age = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Hvilket kurs deltar studenten på?" + "Aktuelle kurs er for tiden: Radiobilkjøring, Strikkekurs og svømming");
NyStudent.Course = Console.ReadLine();
Console.WriteLine($"Vil du legge til {NyStudent.Name}, {NyStudent.Age} år, til kurset {NyStudent.Course}? Vennligst oppgi ja/nei.");
string svar = Console.ReadLine();
if (svar == "ja")
{
    Console.WriteLine($"Så bra!,{NyStudent.Name} {NyStudent.Age} år, er nå lagt til i kurset: {NyStudent.Course}.");
    studentList.Add(NyStudent);
}
else if (svar == "nei")
{
    Console.WriteLine("Den er grei.");//Kan man få koden her til å starte på nytt med å legge inn elev?
}
else { 
}
Console.WriteLine("Print elevListe:");
foreach (var item in studentList)
{

}
    var valgtKurs = Console.ReadLine();
Console.WriteLine($"Disse elevene deltar på {valgtKurs}:");
foreach (var item in studentList)
{
    if (valgtKurs == item.Course)
    {
        Console.WriteLine($"\n{item.Name}, \n{item.Age}");
    }
}



//Console.WriteLine("Velg et kurs for å printe elevliste: velg: Radiobilkjøring, Strikkekurs, svømming ");
//
//Students(valgtKurs);









/*Her er et javascript obj - gjør det om til en klasse i C#

var student = {
navn: “Heibert”,
alder: 42,
kurs: Radiobilkjøring
};


Bruk så denne klassen til å lage flere studenter, og lagre disse i et array eller en List.
Gjør så man kan skrive/velge et kurs i konsollen, og så listes studentene på det valgte kurset ut i konsollen.*/

