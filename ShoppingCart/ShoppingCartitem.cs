﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    public class ShoppingCartItem
    {
        private double _price;
        private string _itemname;
        public ShoppingCartItem(string itemname, double price)
        {
            _itemname = itemname;
            _price = price;
        }
        private List<ShoppingCartItem> _item = new List<ShoppingCartItem>();
        private double vat;
        public void AddShoppingItem(ShoppingCartItem item)
        {
            _item.Add(item);
        }

        internal List<ShoppingCartItem> CartList()
        {
            throw new NotImplementedException();
        }

        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }
        public string ItemName
        {
            get { return _itemname; }
            set { _itemname = value; }
        }

        internal string GetSubTotal()
        {
            throw new NotImplementedException();
        }

        public List<ShoppingCartItem> ItemCartitems { get; }
    }
       return _ShoppingCartModel

}
