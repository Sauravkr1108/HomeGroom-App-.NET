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
    public class MenuController : Controller
    {
        private readonly IServiceRepo _serviceRepo;
        private readonly ICategoryRepo _categoryRepo;
        public MenuController(IServiceRepo serviceRepo, ICategoryRepo categoryRepo)
        {
            _serviceRepo = serviceRepo;
            _categoryRepo = categoryRepo;
        }
        //Searching and Filtering
        public IActionResult Index(string search, int category)
        {

            if (search == null)
            {
                IEnumerable<Service> services;
                string currentCategory;
                if (category == 0)
                {
                    services = _serviceRepo.AllServices.OrderBy(m => m.ServiceId);
                    currentCategory = "All Services";
                }
                else
                {
                    services = _serviceRepo.AllServices.Where(m => m.CategoryId == category).OrderBy(m => m.ServiceId);
                    currentCategory = _categoryRepo.AllCategories.FirstOrDefault(c => c.CategoryId == category)?.CategoryName;
                }
                TempData["Category"] = currentCategory;
                return View(new ServiceViewModel
                {
                    AllServices = services,
                    CurrentCategory = currentCategory
                });
            }
            else
            {
                var serviceViewModel1 = new ServiceViewModel
                {
                    AllServices = _serviceRepo.AllServices
                };
                if (!String.IsNullOrEmpty(search))
                {
                    var serviceViewModel2 = new ServiceViewModel
                    {
                        AllServices = _serviceRepo.AllServices.Where(x => x.ServiceName.ToUpper().Contains(search) || x.ServiceName.ToLower().Contains(search) || search == null)
                    };
                    return View(serviceViewModel2);

                }
                return View(serviceViewModel1);
            }


        }
        //Getting details of user
        [Authorize]
        [System.Web.Mvc.HandleError()]
        public ActionResult Details(int serviceId)
        {
            var menudetails = _serviceRepo.AllServices.Single(rec => rec.ServiceId == serviceId);
            return View(menudetails);
        }
        //Map Api
        public ActionResult Map()
        {
            return View();
        }
    }
}
