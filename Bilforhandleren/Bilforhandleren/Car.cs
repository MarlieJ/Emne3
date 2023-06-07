using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bilforhandleren
{
    public class Car
    {
        public string Merke;
        public string Regnr;
        public int Aarsmod;
        public int Kmstand;
        public Car(string merke, string regnr, int aarsmod, int kmstand)
        {
            Merke = merke;
            Regnr = regnr;
            Aarsmod = aarsmod;
            Kmstand = kmstand;

        }
    }
    
}
