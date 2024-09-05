using HomeGroom.Models;
using HomeGroom.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeGroom.Controllers
{
    public class HomeController : Controller
    {
        private readonly IServiceRepo _serviceRepo;
        private readonly ICategoryRepo _categoryRepo;
        public HomeController(IServiceRepo serviceRepo, ICategoryRepo categoryRepo)
        {
            _serviceRepo = serviceRepo;
            _categoryRepo = categoryRepo;
        }
        public IActionResult Index()
        {
            var categoryViewModel = new CategoryViewModel
            {
                AllCategories = _categoryRepo.AllCategories
            };
            return View(categoryViewModel);
        }
        
    }
}
