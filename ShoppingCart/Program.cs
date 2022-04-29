using System;

namespace ShoppingCart
{
    public class Program
    {
        static void Main(string[] args)
        {
           ShoppingCart cart = new ShoppingCart();

            ShoppingCartItem item = new ShoppingCartItem("Laptop", 3500);
            cart.AddShoppingItem(item);
            item = new ShoppingCartItem("Washing machine", 6700);
            cart.AddShoppingItem(item);
            item = new ShoppingCartItem("Microwave", 2500);
            cart.AddShoppingItem(item);
            System.Collections.Generic.List<ShoppingCartItem> items = cart.CartList();
            
            foreach (ShoppingCartItem item_ in items)
            {
                Console.WriteLine(item_.ItemName + " " + item_.Price);
            }
            //Console.WriteLine(items);
            Console.WriteLine("Sub total "
                + cart.GetSubTotal());
            Console.WriteLine("Subtotal".Vat());
        }
    }
}
