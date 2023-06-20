using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lagerbeholdning
{
    internal class ElectronicItem : InventoryItemHandleKurv
    {
        public string _color { get; private set; }
        public string _insurance { get; private set; }
        public ElectronicItem (string name, int amount, double price, string color, string insurance) : base(name, amount, price)
        {
            _color = color;
            _insurance = insurance;
        }
    }
}
