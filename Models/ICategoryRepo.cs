using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeGroom.Models
{
    public interface ICategoryRepo
    {
        public IEnumerable<Category> AllCategories { get; }
    }
}
