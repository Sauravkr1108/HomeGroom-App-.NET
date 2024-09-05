using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeGroom.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder builder)
        {

            // Seed Roles

            List<IdentityRole> roles = new List<IdentityRole>()
            {
                new IdentityRole { Name = "Admin", NormalizedName = "ADMIN" },
               
            };

            builder.Entity<IdentityRole>().HasData(roles);

            var passwordHasher = new PasswordHasher<IdentityUser>();

            List<IdentityUser> users = new List<IdentityUser>()
            {
 
                new IdentityUser
                {
                    UserName = "user2@hotmail.com",
                    NormalizedUserName = "USER2@HOTMAIL.COM",
                    Email = "user2@hotmail.com",
                    NormalizedEmail = "USER2@HOTMAIL.COM",
                },

                
            };

            builder.Entity<IdentityUser>().HasData(users);

            
            List<IdentityUserRole<string>> userRoles = new List<IdentityUserRole<string>>();


            users[0].PasswordHash = passwordHasher.HashPassword(users[0], "User.123");
            

            userRoles.Add(new IdentityUserRole<string>
            {
                UserId = users[0].Id,
                RoleId = roles.First(q => q.Name == "Admin").Id

            });

            

            builder.Entity<IdentityUserRole<string>>().HasData(userRoles);
        }
    }
}
