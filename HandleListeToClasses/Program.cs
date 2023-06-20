using HandleListeToClasses;

product A = new product("Agurk", 40);
product B = new product("Brød", 70);
product C = new product("CapriSonne", 30);
var handlekurv = new ShoppingCart();
handlekurv.LeggVareikurven(A, 1);
handlekurv.LeggVareikurven(B, 1);
handlekurv.LeggVareikurven(B, 1);
handlekurv.LeggVareikurven(C, 1);
handlekurv.ShowProductsInCart();





            

       

   