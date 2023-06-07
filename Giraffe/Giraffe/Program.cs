using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Giraffe
{
    class Program //A class is a container where we can put code
    {
        static void Main(string[] args)//this is the method/function - this is also a container for code, and an important one, where we can put all the code we want the program to execute 
        {//I need to put the code I want to execute inside of this "Main" methods curlybrackets 
         //A method is basically a block of code that we can call (,which is going to perfrom a specific task).

            Console.WriteLine("   /|");//Det du sier til datamaskinens hode er, hva vil brukeren at jeg skal gjøre? Jo printe en linje til konsollen, hvor det står det det står i klammene. Og så lese videre. It executes the orders you've given.
            Console.WriteLine("  / |");//Rekkefølgen har mye å si.
            Console.WriteLine(" /  |");// Alt av programmering er et sett med instruksjoner, i en spesifikk rekkefølge.
            Console.WriteLine("/___|");

            Console.WriteLine();

                //Console.ReadLine();

            //VARIABLES
            //A variable is a container for storing information - piece of data or information that I wanna keep track of and manage in my programs. 
            // Instead of changing every line manually, f ex if I wanted to chane a data 100 times, it would be very difficult to manage this data - instead I can make a variable :D
            //We need the type of data. Different containers can store different values : text, true/false etc. Nyttig for informasjon that occurs multiple times in the code (here story).
            string nameVar = "George";//string = tekst
            int ageVar;//int = integer = heltall på norsk, altså uten desimal.
                       //over deklarerer vi variabelen. Mens under gir vi variabelen en verdi.
            ageVar = 35;

            Console.WriteLine("There once was a man named " + nameVar);
            Console.WriteLine("He was " + ageVar + " years old");

            //Halfway through the story/code? I can change the variables value.
            ageVar = 72;
            nameVar = "Tom";
            Console.WriteLine("He really liked the name " + nameVar);
            Console.WriteLine("But didn't like being " + ageVar);

                //Console.ReadLine();

            //DATA TYPES (Variables? data types?). Different types of information or data we represent and use in C#: 
            //the different datatypes we can use created in Variables (that stores the data) ((it wouldn't show or be saved anywhere if not?))

            
            string phrase = "Giraffe Academy";   //plain text
            char grade = 'C';                    //one single character/letter. Only one character, not more. Use single quotation mark.
            int age = -30;                       //you don't need quotation mark. You can do negative numbers, with a substract sign in front. 
            float FloatVar;
            double dblVar;
            decimal decVar;
            // The number dataTypes above range from least accurate to most accurate. If you wanna be superprecise you wanna use decimal. While float is less precise. Less precise of decimals places. 
            double d1 = 3.2;                      //Anytime I use a decimal number I need to include the decimal. Use dot, not comma.
            bool isMale = true;                  //boolean is either true or false. That's it.

            //Above: the core datatypes.
            //There are a few more, but they're not so common.

            //You can represent the dataTypes above outside of variables.
            Console.WriteLine("Hello"); //Nå har jeg deklarert en datatype, men den er ikke stored noe sted utenom her.
            Console.WriteLine(30);      //Når jeg deklarer datatyper sånn som dette, blir det kalt en constant.
            Console.WriteLine(true);
            //Constant = not keeping track of it anywhere. It's just mentioned here.

            //WORKING WITH STRINGS 
            //one of the most useful types of data in C#

            Console.WriteLine();                                //The console.writeline is just gonna print out some data onto the screen.
            Console.WriteLine("Giraffe\nAcademy");              //  \n = new line
            Console.WriteLine("Giraffe\"Academy");              // the backslash gives you the opportunity to print the quotation mark.
            string phrase1 = "Giraffe Academy \"lagret\" i en variabel";
             //Indexposisjon: 0123456789+++
            Console.WriteLine(phrase1);                         //string fra variabel.
            string phrase2 = "Giraffe   Academy" + " is cool";     //Concatenation:  add two strings together. 
            Console.WriteLine(phrase2);

            Console.WriteLine("Dette er hvor mange characters it is in the variabel phrase2: " + phrase2.Length); //How to figure out how many characters are in a string (tar med mellomrom, ikke quotation mark)

            Console.WriteLine("med ToUpper gjør vi all teksten i phrase1 til store bokstaver: "  + phrase1.ToUpper());                 //modify the value of a string - til store bokstaver.
            Console.WriteLine("med ToUpper gjør vi all teksten i phrase1 til små bokstaver: "  + phrase1.ToLower());                 //modify the value of a string - til små bokstaver. 
            
            Console.WriteLine("med Contains metoden med parameter() får vi vite om phrase1 inneholder teksten Academy: " + phrase1.Contains("Academy"));                                  //Contains med parameter = (). Spør om variabelen inneholder string med teksten Academy, med stor bokstav foran. Hadde det vært liten blir det false. Med stor blir det true, siden det er stor A som er brukt i teksten i variabelen.
            Console.WriteLine("character with indexplace 6 phrase1 is: " + phrase1[6] + ".");      //Finne character in the string in the variable via indexplacement. 0 er alltid den første, og så teller det oppover.
            Console.WriteLine(phrase1.IndexOf("Academy"));                                          //Indexen til stringen academy starter på index 8.
            Console.WriteLine(phrase1.IndexOf('F'));                                            //Indexen til den første character






            Console.ReadLine();





        }
    }   
}