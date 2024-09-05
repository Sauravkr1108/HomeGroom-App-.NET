using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeGroom.Models
{
    public class ServiceDbContext : DbContext
    {
        public ServiceDbContext(DbContextOptions<ServiceDbContext> options) : base(options)
        {

        }
        public DbSet<Service> Services { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        //public DbSet<ContactUs> Contact { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //seeding
            //Categorydb
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "Cleaning" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "Grooming" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "Electrician" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 4, CategoryName = "Carpenter" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 5, CategoryName = "Plumber" });

            //Servicedb
            modelBuilder.Entity<Service>().HasData(new Service
            {
                ServiceId = 1,
                ServiceName = "AC Repair",
                ImagePath = "~/Images/ac.jpg",
                Price = 1500,
                CategoryId = 3
            });
            modelBuilder.Entity<Service>().HasData(new Service
            {
                ServiceId = 2,
                ServiceName = "Fridge Repair",
                ImagePath = "~/Images/fridge.png",
                Price = 1000,
                CategoryId = 3
            });
            modelBuilder.Entity<Service>().HasData(new Service
            {
                ServiceId = 3,
                ServiceName = "Fan Repair",
                ImagePath = "~/Images/fan.jpg",
                Price = 500,
                CategoryId = 3
            });
            modelBuilder.Entity<Service>().HasData(new Service
            {
                ServiceId = 4,
                ServiceName = "Salon for Male",
                ImagePath = "~/Images/male.jpg",
                Price = 200,
                CategoryId = 2
            });
            modelBuilder.Entity<Service>().HasData(new Service
            {
                ServiceId = 5,
                ServiceName = "Salon for female",
                ImagePath = "~/Images/female.jpg",
                Price = 200,
                CategoryId = 2
            });
            modelBuilder.Entity<Service>().HasData(new Service
            {
                ServiceId = 6,
                ServiceName = "Massage",
                ImagePath = "~/Images/massage.jpg",
                Price = 500,
                CategoryId = 2
            });
            modelBuilder.Entity<Service>().HasData(new Service
            {
                ServiceId = 7,
                ServiceName = "Pest Control",
                ImagePath = "~/Images/pest.jpg",
                Price = 1000,
                CategoryId = 1
            });
            modelBuilder.Entity<Service>().HasData(new Service
            {
                ServiceId = 8,
                ServiceName = "Room Cleaning",
                ImagePath = "~/Images/room.jpg",
                Price = 2000,
                CategoryId = 1
            });
            modelBuilder.Entity<Service>().HasData(new Service
            {
                ServiceId = 9,
                ServiceName = "Kitchen Cleaning",
                ImagePath = "~/Images/kitchen.jpg",
                Price = 2000,
                CategoryId = 1
            });
            modelBuilder.Entity<Service>().HasData(new Service
            {
                ServiceId = 10,
                ServiceName = "Bathroom Cleaning",
                ImagePath = "~/Images/bathroom.jpg",
                Price = 2000,
                CategoryId = 1
            });
            modelBuilder.Entity<Service>().HasData(new Service
            {
                ServiceId = 11,
                ServiceName = "Water Leakage",
                ImagePath = "~/Images/water.jpg",
                Price = 1500,
                CategoryId = 5
            });
            modelBuilder.Entity<Service>().HasData(new Service
            {
                ServiceId = 12,
                ServiceName = "Pipe Fixing",
                ImagePath = "~/Images/pipe.jpg",
                Price = 500,
                CategoryId = 5
            });

        }
    }
}
