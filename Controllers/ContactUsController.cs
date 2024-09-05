using HomeGroom.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeGroom.Controllers
{

    public class ContactUsController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {

            return View();
        }
        [HttpPost]

        public IActionResult Index(ContactUs contact)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Complete");
            }

            return View();
        }

        public ActionResult Complete()
        {
            ViewData["Checkoutmsg"] = "Thanks for your feedback";
            return View();
        }

        //    [HttpPost]

        //    public List<ContactUs> Contacts { get; set; }
        //    public void Index(,string name)
        //    {
        //        var contacts = _serviceDbContext.Contact;
        //        contacts = new contacts
        //        {
        //            Name = contactus.Name,
        //            Email = contactus.Email,
        //            Subject = contactus.Subject
        //        };



        //};
    }
    }
