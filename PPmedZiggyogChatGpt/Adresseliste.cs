using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPmedZiggyogChatGpt
{
    internal class Adresseliste
    {
        private List<Kontakt> kontakter;
        public Adresseliste()
        {
            kontakter = new List<Kontakt>();
        }
        public void LeggTilKontakt(Kontakt enNyKontakt)
        {
            kontakter.Add(enNyKontakt);
        }
        public void FinnKontakt(string søkeOrd)
        {
            if(søkeOrd == Kontakt.Navn)
            {

            }
        }
        public void VisAlleKontakter()
        {
            foreach (var item in kontakter)
            {
                item.VisInformasjon();
            }
        }

    }
}
