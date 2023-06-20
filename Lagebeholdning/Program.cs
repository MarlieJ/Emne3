// See https://aka.ms/new-console-template for more information
using Lagerbeholdning;

Console.WriteLine($"");
var Item1 = new ClothingItem("Bukse", 1, 400, "L", "Blå");
var Item2 = new ClothingItem("Bukse", 2, 300, "L", "Gul");
var Item3 = new ClothingItem("Kjole", 2, 500, "L", "Rosa");
var Item4 = new ElectronicItem("Mobiltelefon", 1, 7000, "Blå", "Skjermforsikring");




/*Lag en base klasse som heter “InventoryItem” hvor du har info om itemets navn, antall og pris.

Lag to klasser til, ClothingItem og ElectronicItem. Disse skal ha informasjon om størrelse og farge f.eks på klær og f.eks forsikringsinformasjon og spenning på det elektriske.
La disse klassene arve av baseklassen, slik at de også får bruke navn, antall og pris.

Lag et interface ISellable som har en funksjon som kalkulerer pris. Implementer dette interfacet i ClothingItem og ElectronicItem
Lag noen forskjellige items for å sjekke at det fungerer som tenkt.*/