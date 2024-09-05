using HomeGroom.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeGroom.ViewModels
{
    public class FilterViewModel
    {
        public IEnumerable<Service> Services { get; set; }
        public string CurrentCategory { get; set; }
    }
}
