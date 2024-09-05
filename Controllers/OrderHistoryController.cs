using HomeGroom.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeGroom.Controllers
{
    public class OrderHistoryController : Controller
    {
        //DI
        private readonly ServiceDbContext _serviceDbContext;
        public OrderHistoryController(ServiceDbContext serviceDbContext)
        {
            _serviceDbContext = serviceDbContext;
        }
        //Getting the details of cartitems to store for order history
        public IActionResult Index()
        {
            List<CartItem> contextList = _serviceDbContext.CartItems.ToList();
            return View(contextList);
        }
    }
}
