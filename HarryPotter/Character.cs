using System.IO.Pipes;
using System.Runtime.CompilerServices;

namespace HarryPotter
{
    internal class Character
    {
        public string name { get; private set; } //det er vanlig å bruke stor forbokstav på public property navn.
        public string house { get; private set; }
        public Animal pet { get; private set; }
        public Wand wand { get; private set; }
        public List<Animal> PetList { get; private set; }
        public List<Wand> WandList { get; private set; }
        public Letter Inbox { get; private set; }//skal ikke legges inn i ctor, fordi den eksisterer ikke når du ble født. Ekstern kilde.
        public Character(string NName, string HHouse, string PPet, string WWand)//når du sender med parameterne skal du bruke liten
        {
            name = NName;
            house = HHouse;
            pet = new Animal(PPet);//denne tar imot "OWl" fra new character i program.cs og sender det videre til animalklassen sitt animalName
            wand = new Wand(WWand);
            PetList = new List<Animal>() {pet};//nå koder {pet} for Kristtorn definert i new character klassen i program
            WandList = new List<Wand>() {wand};

            
        }
        public void PersonIntro()
        {
            Console.WriteLine($"Hello my name is {name}, and I'm in the house of {house}. I have a {pet.Name} and a {wand.Name}-wand.");//hvorfor fungerer det uten å implementere x i parameterne??
        }

        public int chooseProductInStoreNumber()
        {
            Console.WriteLine("What product do you want? Type number: ");
            var chosenProduct = int.Parse(Console.ReadLine());
            return chosenProduct;
        }
        public void takeItemAndRun(StoreItem product)
        {
            if (product is Animal)//når jeg skal sjekke obejkttype / klasse, så vil den ikke ha == men is.
            {
                PetList.Add((Animal)product); //product endrer form fra StorItem til Animal. Animal er det jeg vil gjøre det om til, og det som kommer etter må da bli det i parentesen før.
            }
            else { WandList.Add((Wand)product); }
        }
        public void showItemsInList()
        {
            Console.WriteLine(name + " har: ");
            foreach (var item in WandList)
            {
                Console.WriteLine($"{item.Name}.");
            }
            foreach (var item in PetList)
            {
                Console.WriteLine($"{item.Name}.");
            }
        }
        public void Spell()
        {
            bool throwingSpell = true;
            while (throwingSpell)
            {
                //string fluetekst = "throw a spell vingardium"; kan skrive en string bare og gjengi med var-navn i CW'en.
                Console.WriteLine("Throw a spell: Vingardium Leviosa or Hokus Pokus!");
                string givenSpell = Console.ReadLine().ToLower();
                if (givenSpell == "vingardium leviosa")
                {
                    Console.WriteLine("Fjæren flyr, lurer på om jeg kan bruke den samme trylleformlen til sopelimet mitt...");
                    throwingSpell = false;
                }
                else if (givenSpell == "hokus pokus")
                {
                    Console.WriteLine("Wow, fyrverkeriet jeg tryllet ble magisk!");
                    throwingSpell = false;
                }
                else
                {
                    Console.WriteLine("Det er ikke en formel, prøv igjen.");
                }
            }
        }
        /*
         * Harry skal skrive et brev
         * Harry sender brevet med uglen
         * Uglen flyr
         * Hermine får brevet fra uglen 
         * Hermine leser brevet
         */
        
        public void writeLetterToPerson(List<Character> CharacterList)
        {
            for (int i = 0; i < CharacterList.Count; i++)
            {
                Console.WriteLine($"{i} {CharacterList[i].name}");
            }
            int chosenCharacterNumber = Convert.ToInt32(Console.ReadLine());
            Character personToReceiveLetter = CharacterList[chosenCharacterNumber];
            Console.WriteLine("Write your message:");
            var letterText = Console.ReadLine();
            var letterToSend = new Letter(letterText, this);//denne karakteren som kaller på funksjonen er avsender.
            sendLetter(letterToSend, personToReceiveLetter);
        }
        public void sendLetter(Letter letterToSend, Character person2)
        {
            pet.flyWithLetter(letterToSend, person2);
        }
        public void recieveLetter(Letter letterToSend)
        {
            Inbox = letterToSend;
            readLetter();//trenger ikke sende med letterToSend parameter her, fordi brevet allerede tilhører denne klassen.
        }
        public void readLetter()
        {
            Console.WriteLine($"You recieved a letter from {Inbox.LetterSender.name} that says: {Inbox.Text}");
        }
    }

}
