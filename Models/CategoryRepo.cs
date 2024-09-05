using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeGroom.Models
{
    public class CategoryRepo : ICategoryRepo
    {
        private readonly ServiceDbContext _serviceDbContext;
        public CategoryRepo(ServiceDbContext serviceDbContext)
        {
            _serviceDbContext = serviceDbContext;
        }
        public IEnumerable<Category> AllCategories => _serviceDbContext.Categories;
    }
}
