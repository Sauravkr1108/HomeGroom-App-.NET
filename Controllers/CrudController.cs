using HomeGroom.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeGroom.Controllers
{
    public class CrudController : Controller
    {
        private readonly ServiceDbContext _serviceDbContext;
        public CrudController(ServiceDbContext serviceDbContext)
        {
            _serviceDbContext = serviceDbContext;
        }
        [HttpGet]
        public ActionResult Index()
        {
            List<Service> serviceList = _serviceDbContext.Services.ToList();
            return View(serviceList);
        }
        public ActionResult Create()
        {

            return View();
        }
        public ActionResult Delete()
        {

            return View();
        }
        public ActionResult Update()
        {
            return View();
        }

    }
}
