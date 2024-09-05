using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeGroom.Models
{
    public interface IServiceRepo
    {
        public IEnumerable<Service> AllServices { get; }
    }
}
