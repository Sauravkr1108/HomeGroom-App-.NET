using HomeGroom.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeGroom.ViewModels
{
    public class ServiceViewModel
    {
        public IEnumerable<Service> AllServices { get; set; }
        
        public string CurrentCategory { get; set; }

    }
}
