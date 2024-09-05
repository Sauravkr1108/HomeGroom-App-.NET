using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeGroom.Models
{
    public class ServiceRepo : IServiceRepo
    {
        private readonly ServiceDbContext _serviceDbContext;
        public ServiceRepo(ServiceDbContext serviceDbContext)
        {
            _serviceDbContext = serviceDbContext;
        }
        public IEnumerable<Service> AllServices
        {
            get
            {
                return _serviceDbContext.Services.Include(c => c.Category);
            }
        }
    }
}
