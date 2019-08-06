using System;
using System.Collections;
using System.Collections.Generic;

namespace CartApp
{
   
    public class Cart
    {
        private List<CartItem> _cart;
        private double _totalAmount=0f;
       // private object _item;
        private double _discount;
        public Cart()
        {
            _cart = new List<CartItem>();
        }
       
        public double GetTotal()
        {
            foreach(CartItem _item in _cart)
            {
                _totalAmount += _item.GetCartTotal();
            }
            return _totalAmount;
        }
        public double GetTotalDiscount()
        {
            _discount= (double)(_totalAmount) * (double)(0.5f);
            return _discount;
        }
        public void AddToCart(CartItem cartItem)
        {
            _cart.Add(cartItem);
        }
    }
}
