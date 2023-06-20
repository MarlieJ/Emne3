namespace HarryPotter
{
    internal class MagicStore
    {
        public List<StoreItem> InventoryItems { get; private set; }
        public MagicStore()
        {
            InventoryItems = new List<StoreItem>() { new Animal("Owl"), new Animal("Rat"), new Animal("Cat"), new Wand("Phoenixwand"), new Wand("UnicornWand"), new Wand("MagicWand") };
        }
        public void WelcomeToTheStore()
        {
            Console.WriteLine($"Hello. Welcome to the store. Do you want to buy a pet or a wand? Write P for pet og W for wand: ");
            var chosenThing = Console.ReadLine();
            List<StoreItem> itemsToPrint = new List<StoreItem>();
            if(chosenThing == "P")
            {
               itemsToPrint = getAnimalItems();
            }
            else
            {
                itemsToPrint = getWandItems();
            }
            printProduct(itemsToPrint);
            Console.WriteLine("What product do you want? Type number: ");
            var chosenProduct = int.Parse(Console.ReadLine());
            Console.WriteLine($"Hope you will be satisfied with {InventoryItems[chosenProduct].Name}");
            

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
