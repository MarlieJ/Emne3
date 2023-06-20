using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandleListeToClasses
{
    internal class product
    {
        public string Name {  get; private set; }
        public int Price { get; private set; }
        public product(string name, int price)
        {
            Name = name;
            Price = price;
        }
    }
}
