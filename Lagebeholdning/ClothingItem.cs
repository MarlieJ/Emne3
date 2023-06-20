using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lagerbeholdning
{
    internal class ClothingItem : InventoryItemHandleKurv
    {
        public string _size { get; private set; }
        public string _color { get; private set; }
        public ClothingItem(string name, int amount, double price, string size, string color) : base(name, amount, price) //base = kaller på : inventoryitemhandlekurv sin konstruktør
        {
            _size = size;
            _color = color;
        }
    }
}
