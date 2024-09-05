using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeGroom.Models
{
    public class Service
    {
        public int ServiceId { get; set; }
        public string ServiceName { get; set; }
        public string  Name { get; set; }
        public int Mob { get; set; }
        public decimal Price { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }
        public string ImagePath { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
