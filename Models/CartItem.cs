using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeGroom.Models
{
    public class CartItem
    {
        public int CartItemId { get; set; }
        public Service Service { get; set; }
        public string User { get; set; }
        public string Name { get; set; }
        public string mob { get; set; }      
        public string ServiceName { get; set; }
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }
        public string Address { get; set; }
        public int Quantity { get; set; }
        public string CartId { get; set; } 

    }
}
