using HomeGroom.Models;
using HomeGroom.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeGroom.Controllers
{
    public class CartController : Controller
    {

        private readonly IServiceRepo _serviceRepo;
        private readonly Cart _Cart;

        public CartController(IServiceRepo serviceRepo, Cart Cart)
        {
            _serviceRepo = serviceRepo;
            _Cart = Cart;
        }

        [Authorize]
        public IActionResult Index()
        {
            var items = _Cart.GetCartItems();
            _Cart.CartItems = items;

            var cartviewmodel = new CartViewModel()
            {
                Cart = _Cart,
                CartTotal = _Cart.GetTotal(),

            };
            return View(cartviewmodel);
        }
        //Populating with details for the service chosen and adding to cart
        
        [HttpPost]
        public RedirectToActionResult AddtoShoppingCart(int serviceId,DateTime date,DateTime  time,string name,string mob,string addr1,string addr2)
        {
            _serviceRepo.AllServices.FirstOrDefault(m => m.ServiceId == serviceId).Date = date;
            _serviceRepo.AllServices.FirstOrDefault(m => m.ServiceId == serviceId).Time = time;
            _serviceRepo.AllServices.FirstOrDefault(m => m.ServiceId == serviceId).Name = name;
            //_serviceRepo.AllServices.FirstOrDefault(m => m.ServiceId == serviceId).Mob = Int.Parse(mob); 
            _serviceRepo.AllServices.FirstOrDefault(m => m.ServiceId == serviceId).Address1 = addr1;
            _serviceRepo.AllServices.FirstOrDefault(m => m.ServiceId == serviceId).Address2 = addr2;
            string str = User.Identity.Name;
            var selectedService = _serviceRepo.AllServices.FirstOrDefault(m => m.ServiceId == serviceId);
            if (selectedService != null)
            {
                _Cart.AddToCart(selectedService,str,date, time, name, addr1, addr2);
            }
            return RedirectToAction("Index");

        }

        //Delete by id
        public ActionResult Delete(int id)
        {
            _Cart.RemoveFromCart(id);
            return RedirectToAction("Index");
        }
        //Delete all items from cart
        public ActionResult Clear()
        {
            _Cart.ClearCart();
            return RedirectToAction("Index");
        }
        //Counting total services booked
        public ActionResult CountOrders()
        {
            var items = _Cart.GetCartItems();
            ViewData["count"] = items.Count().ToString();
            return View();
        }
    }
}

