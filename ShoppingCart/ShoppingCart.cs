using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartModels
{
    public class ShoppingCart : ShoppingCartBase

    {
        private List<ShoppingCartItem> _items = new List<ShoppingCartItem>();
        private double vat;

        public List<ShoppingCartItem> CartList()
        {
            return _items;
        }
        public double GetSubTotal()
        {
            double total = 0;
            foreach (ShoppingCartItem item in _items)
            {
                total += item.Price;
            }
            return total;
        }
        public double Vat()

        {
            double vat = 0;
            vat = GetSubTotal() + GetSubTotal() * 0.15;
            return vat;
        }

            