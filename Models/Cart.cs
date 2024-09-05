using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeGroom.Models
{
    public class Cart
    {
        public string CartId { get; set; }
        public List<CartItem> CartItems { get; set; }
        private readonly ServiceDbContext _serviceDbContext;
        public Cart(ServiceDbContext serviceDbContext)
        {
            _serviceDbContext = serviceDbContext;
        }
        //Getting Differen Cart for all users using different session
        public static Cart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>().HttpContext.Session;
            var context = services.GetService<ServiceDbContext>();
            string Id = session.GetString("CartId") ?? Guid.NewGuid().ToString();
            session.SetString("CartId", Id);

            return new Cart(context) { CartId = Id };
        }
        //Addint to the cart services
        public void AddToCart(Service service, string str, DateTime date, DateTime time, string name, string addr1, string addr2)
        {
            var CartItem = _serviceDbContext.CartItems.SingleOrDefault(
                s => s.Service.ServiceId == service.ServiceId && s.CartId == CartId);
            DateTime myTime = default(DateTime).Add(time.TimeOfDay);
            if (CartItem == null)
            {
                CartItem = new CartItem
                {
                    Service = service,
                    CartId = CartId,
                    User = str,
                    Name = name,
                    Date = date.Date,
                    Time = myTime,
                    ServiceName = service.ServiceName,
                    Address = string.Concat(addr1,addr2),                    
                    Quantity = 1
                };
                _serviceDbContext.CartItems.Add(CartItem);
            }
            else
            {
                CartItem.Quantity++;
            }
            _serviceDbContext.SaveChanges();
        }
        //Fetching the cartitems by id
        public List<CartItem> GetCartItems()
        {
            return CartItems ?? (
                CartItems =
                _serviceDbContext.CartItems.Where(c => c.CartId == CartId)
                .Include(s => s.Service).ToList());
            
        }
        //Calculating total amount in the cart
        public decimal GetTotal()
        {
            var items = GetCartItems();
            decimal total = 0;
            foreach (var calc in items)
            {
                total += calc.Service.Price * calc.Quantity;
            }
            return (total);
        }
        //Delete service by id in cart
        public void RemoveFromCart(int orderid)
        {
            var items = GetCartItems();
            foreach (var del in items)
            {
                if (del.Service.ServiceId == orderid)
                {
                    _serviceDbContext.CartItems.Remove(del);
                    break;
                }
            }
            _serviceDbContext.SaveChanges();

        }
        //Delete all services in cart
        public void ClearCart()
        {
            var items = GetCartItems();
            foreach (var del in items)
                _serviceDbContext.CartItems.Remove(del);
            _serviceDbContext.SaveChanges();
        }
        //Counting total serivces booked
        public int CountOrders()
        {
            var items = GetCartItems();
            return (items.Count());
        }
    }
}
