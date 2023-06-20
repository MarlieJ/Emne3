using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lagerbeholdning
{
    internal class InventoryItemHandleKurv : ISellable
    {
        public string _name { get; private set; }
        public int _amount { get; private set; }
        public double _price { get; private set; }
        public InventoryItemHandleKurv(string name, int amount, double price)
        {
            _name = name;
            _amount = amount;
            _price = price;
        }

        public double settPris()
        {
            double sluttpris = _price * _amount;
            Console.WriteLine($"Prisen for {_amount} {_name} er {sluttpris}");
            return sluttpris;
        }

    }
}
