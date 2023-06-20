namespace HarryPotter
{
    internal class Character
    {
        public string name { get; private set; } //det er vanlig å bruke stor forbokstav på public property navn.
        public string house { get; private set; }
        public Animal pet { get; private set; }
        public Wand wand { get; private set; }
        public Character(string NName, string HHouse, string PPet, string WWand)//når du sender med parameterne skal du bruke liten
        {
            name = NName;
            house = HHouse;
            pet = new Animal(PPet);//denne tar imot "OWl" fra new character i program.cs og sender det videre til animalklassen sitt animalName
            wand = new Wand(WWand);
        }
        public void PersonIntro()
        {
            Console.WriteLine($"Hallo my name is {name}, and I'm in the house of {house}. I have a {pet.Name} and a {wand.Name}-wand.");
        }
        public void Spell()
        {

        }
    }

}
