using HomeGroom.Models;
using HomeGroom.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeGroom.Components
{
    public class CartCount : ViewComponent
    {
        //DI
        private readonly Cart _cart;

        public CartCount(Cart cart)
        {
            _cart = cart;
        }
        //Populate CartItems for Cart
        public IViewComponentResult Invoke()
        {
            var items = _cart.GetCartItems();
            _cart.CartItems = items;

            var cartviewmodel = new CartViewModel()
            {
                Cart = _cart,
                CartTotal = _cart.GetTotal(),

            };
            return View(cartviewmodel);
        }
    }
}
