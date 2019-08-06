using System;
using System.Collections.Generic;
using System.Text;

namespace CartApp
{
    public class CartItem
    {
        public Product Item;
        public int Quantity;
        public double TotalCost;
        public CartItem(Product item, int quantity)
        {
            this.Item = item;
            this.Quantity = quantity;
            TotalCost = this.Item.Price * this.Quantity;
        }
        public double GetCartTotal()
        {
            return TotalCost;
        }
    }
    
}
