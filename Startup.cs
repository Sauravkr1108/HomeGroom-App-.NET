using HomeGroom.Data;
using HomeGroom.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeGroom
{
    public class Startup
    {
        public IConfiguration Configuration { get; set; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddControllersWithViews();
            services.AddScoped<IServiceRepo, ServiceRepo>();
            services.AddScoped<ICategoryRepo, CategoryRepo>();

            services.AddDbContext<ServiceDbContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")).EnableSensitiveDataLogging());
            
            services.AddDefaultIdentity<IdentityUser>().AddRoles<IdentityRole>().AddEntityFrameworkStores<HomeGroomContext>();
            services.AddScoped<Cart>(sp => Cart.GetCart(sp));
            services.AddHttpContextAccessor();
            services.AddSession();
/*
            services.AddAuthentication()
            .AddGoogle(opt =>
            {
                IConfigurationSection configurationSection =
                Configuration.GetSection("Authentication:Google");
                opt.ClientId = configurationSection["ClientId"];
                opt.ClientSecret = configurationSection["ClientSecret"];
                opt.SignInScheme = IdentityConstants.ExternalScheme;
            })
            .AddFacebook(opt =>
            {
                IConfigurationSection configurationSection =
                Configuration.GetSection("Authentication:Facebook");
                opt.ClientId = configurationSection["AppId"];
                opt.ClientSecret = configurationSection["AppSecret"];
                opt.SignInScheme = IdentityConstants.ExternalScheme;
            })
            .AddMicrosoftAccount(opt =>
            {
                IConfigurationSection configurationSection =
                Configuration.GetSection("Authentication:Microsoft");
                opt.ClientId = configurationSection["ClientId"];
                opt.ClientSecret = configurationSection["ClientSecret"];
                opt.SignInScheme = IdentityConstants.ExternalScheme;
            });*/

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseFileServer();
            app.UseRouting();
            app.UseSession();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id:int?}"
                    );
                endpoints.MapRazorPages();
            });
        }
    }
}
