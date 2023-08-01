using System.Security.Cryptography.X509Certificates;

namespace HarryPotter
{
    internal class MagicStore
    {
        public List<StoreItem> InventoryItems { get; private set; }
        public MagicStore()
        {
            InventoryItems = new List<StoreItem>() { new Animal("Owl"), new Animal("Rat"), new Animal("Cat"), new Wand("Phoenixwand"), new Wand("UnicornWand"), new Wand("MagicWand") };
        }
        public void WelcomeToTheStore(Character PersonX)
        {
            bool inStore = true;
            while (inStore)
            {
                Console.WriteLine($"Hello. Welcome to the store {PersonX.name}. Do you want to buy a pet or a wand? Write P for pet og W for wand. Type X for exit.");
                var chosenThing = Console.ReadLine().ToLower();
                List<StoreItem> itemsToPrint = new List<StoreItem>();
                if (chosenThing == "p")
                {
                    itemsToPrint = getAnimalItems();
                }
                else if (chosenThing == "w")
                {
                    itemsToPrint = getWandItems();
                }
                else
                {
                    Console.WriteLine("Takk, ha en fin dag.");
                    inStore = false;
                    break;
                }

                printProduct(itemsToPrint);
                var chosenProdInStore = PersonX.chooseProductInStoreNumber();

                var chosenProd = itemsToPrint[chosenProdInStore];
                Console.WriteLine($"I {PersonX.name} choose {chosenProd.Name}.");
                Console.WriteLine($"Hope you will be satisfied with {chosenProd.Name}");
                PersonX.takeItemAndRun(chosenProd);
                /*
                 * 1. Velge en vare
                 * 2. Gå til disken og kjøpe den
                 * 3. Ta med seg varen og gå
                 */
            }

        }
        public List<StoreItem> getAnimalItems()
        {
                var itemsToPrint = InventoryItems.Where(item => item is Animal).ToList();//where = der hvor () = item er objektType Animal.
            return itemsToPrint;
        }
        public List<StoreItem> getWandItems()
        {
            var wandsToPrint = InventoryItems.Where(item => item is Wand).ToList();
            return wandsToPrint;
        }
        public void printProduct(List<StoreItem> ItemsToPrint)
        {
            Console.WriteLine($"You can choose between:");
            for (int i = 0; i < ItemsToPrint.Count; i++)
            {
                Console.WriteLine(i + " " + ItemsToPrint[i].Name + "\n");
            }
                
        }
        

    }
}
