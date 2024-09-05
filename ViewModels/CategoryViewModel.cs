using HomeGroom.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeGroom.ViewModels
{
    public class CategoryViewModel
    {
        public IEnumerable<Category> AllCategories { get; set; }
    }
}
