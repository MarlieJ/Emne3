using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandleListeToClasses
{
    internal class ShoppingCart
    {
        public List<product> shoppingCart;
        public List<int> antall;

        public ShoppingCart()
        {
            shoppingCart = new List<product>();
            antall = new List<int>();
        }
    
        public void LeggVareikurven (product product, int amount)
        {
            if (shoppingCart.Contains(product))
            {
                var productLine = shoppingCart.IndexOf(product);
                antall[productLine] += amount;
            }
            else
            {
                shoppingCart.Add(product);
                antall.Add(amount);
            }
            Console.WriteLine($"Du har lagt {amount} stk. {product.Name} i kurven");

        }
        public void ShowProductsInCart()
        {
            if (shoppingCart.Count == 0) {
                Console.WriteLine("Handlekurven er tom");
                return;
            }
            Console.WriteLine("Handlekurv");
            var totalPris = 0;
            for (int i = 0; i < shoppingCart.Count; i++)
            {
                var Vare = shoppingCart[i];
                var TotalAntall = antall[i];
                var pris = shoppingCart[i].Price;
                var vareLinjeTotal = pris * TotalAntall;
                Console.WriteLine($"{TotalAntall} stk. {Vare.Name} a kroner {pris} = {vareLinjeTotal}");
                totalPris += vareLinjeTotal;


            }
            Console.WriteLine("totalpris:" + totalPris);

        }

    }
}
