using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPmedZiggyogChatGpt
{
    internal class Kontakt
    {
        public string Navn { get; private set; }
        public string TlfNr { get; private set; }
        public string Epost { get; private set;}

        public Kontakt(string navn, string tlfnr, string epost)
        {
            Navn = navn;
            TlfNr = tlfnr;
            Epost = epost;
        }

        public void VisInformasjon()
        {
            Console.WriteLine($"Navn: {Navn}\nTlfNr: {TlfNr}\nE-postadresse: {Epost}");
        }

    }
}
