using PPmedZiggyogChatGpt;

Console.WriteLine("Velkommen til adresselisten, legg til en kontakt");
Adresseliste adresseliste = new();
{
    adresseliste.LeggTilKontakt(new Kontakt("Per", "32845530", "PerPersson@gmail.com"));
    adresseliste.LeggTilKontakt(new Kontakt("Emil", "29043756", "Emil@gmail.com"));
    adresseliste.LeggTilKontakt(new Kontakt("Sara", "47382946", "Sara@gmail.com"));
    adresseliste.LeggTilKontakt(new Kontakt("Arne", "47678889", "arnearnesen@gmail.com"));
}
adresseliste.VisAlleKontakter();
var søkeOrd = Console.ReadLine();
//kontakter.FinnKontakt();
