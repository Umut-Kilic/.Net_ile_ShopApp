using Business.Abstract;
using Business.Concrete;
using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataLayer.Abstract;
using DataLayer.Concrete;
using Goksell_WebApp.Identity;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;

namespace Goksell_WebApp
{
    public class Startup
    {
        private IConfiguration _configuration;
        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddDbContext<ApplicationContext>(options=>options.UseSqlServer(_configuration.GetConnectionString("MssqlConnection")));
            services.AddDbContext<ShopContext>(options=>options.UseSqlServer(_configuration.GetConnectionString("MssqlConnection")));
            
            
            services.AddIdentity<User, IdentityRole>().AddEntityFrameworkStores<ApplicationContext>().AddDefaultTokenProviders();

            services.Configure<IdentityOptions>(options =>
            {
                //password
                options.Password.RequireDigit = true;
                options.Password.RequireLowercase = true;
                options.Password.RequireUppercase = true;
                options.Password.RequiredLength = 6;
                options.Password.RequireNonAlphanumeric = true;

                //Lockout
                options.Lockout.MaxFailedAccessAttempts = 5;
                options.Lockout.DefaultLockoutTimeSpan=TimeSpan.FromMinutes(5);
                options.Lockout.AllowedForNewUsers = true;

                options.User.AllowedUserNameCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._+";
                options.User.RequireUniqueEmail = true;
                options.SignIn.RequireConfirmedEmail = false;
                options.SignIn.RequireConfirmedPhoneNumber = false;



            });

            services.ConfigureApplicationCookie(options =>
            {
                options.LoginPath = "/account/login";
                options.LogoutPath = "/account/logout";
                options.AccessDeniedPath = "/account/AccesDenied";
                options.SlidingExpiration = true;//istek yapýldýgý andan itibaren varolan deðer kadar oturum acýlma suresý uzar
                options.ExpireTimeSpan = TimeSpan.FromMinutes(30);//30 dk login olarak kalýrsýn ancak ýstek yapmazsan atýlýrsýn.
                options.Cookie = new CookieBuilder
                {
                    HttpOnly=true,//sadece bir hhtp ile elde ederiz js gibi scriptler ile ulaþamasýn
                    Name= "ShopApp.Security.Cookie",
                    SameSite=SameSiteMode.Strict
                };
            });

            /*services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<ICartRepository, CartRepository>();
            services.AddScoped<IOrderRepository, OrderRepository>();
            */

            services.AddScoped<IUnitofWork, UnitofWork>();

            services.AddScoped<IProductService, ProductManager>();
            services.AddScoped<ICategoryService, CategoryManager>();
            services.AddScoped<ICartService, CartManager>();
            services.AddScoped<ICartService, CartManager>();
            services.AddScoped<IOrderService, OrderManager>();

            services.AddControllersWithViews();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env,IConfiguration configuration,UserManager<User> userManager,RoleManager<IdentityRole> roleManager)
        {
            if (env.IsDevelopment())
            {
                SeedDatabase.Seed();
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }



            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseAuthentication();
            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                 name: "checkout",
                 pattern: "checkout",
                 defaults: new { controller = "Cart", action = "Checkout" }
             );
                endpoints.MapControllerRoute(
                 name: "cart",
                 pattern: "cart",
                 defaults: new { controller = "Cart", action = "Index" }
             );

                endpoints.MapControllerRoute(
                  name: "adminusercreate",
                  pattern: "admin/user/create",
                  defaults: new { controller = "Admin", action = "UserCreate" }
              );
                endpoints.MapControllerRoute(
                  name: "adminuseredit",
                  pattern: "admin/user/{id?}",
                  defaults: new { controller = "Admin", action = "UserEdit" }
              );

                endpoints.MapControllerRoute(
                  name: "adminusers",
                  pattern: "admin/user/list",
                  defaults: new { controller = "Admin", action = "UserList" }
              );
                endpoints.MapControllerRoute(
                  name: "adminroles",
                  pattern: "admin/role/list",
                  defaults: new { controller = "Admin", action = "RoleList" }
              );
                endpoints.MapControllerRoute(
                  name: "adminrolecreate",
                  pattern: "admin/role/create",
                  defaults: new { controller = "Admin", action = "RoleCreate" }
              );
                endpoints.MapControllerRoute(
                  name: "adminroleedit",
                  pattern: "admin/role/{id?}",
                  defaults: new { controller = "Admin", action = "RoleEdit" }
              );
                endpoints.MapControllerRoute(
                  name: "admincategorylist",
                  pattern: "admin/categories",
                  defaults: new { controller = "Admin", action = "categoryList" }
              );
                endpoints.MapControllerRoute(
                  name: "admincategoryCreate",
                  pattern: "admin/categories/create",
                  defaults: new { controller = "Admin", action = "categoryCreate" }
              );
                endpoints.MapControllerRoute(
                  name: "admincategoryEdit",
                  pattern: "admin/categories/{id?}",
                  defaults: new { controller = "Admin", action = "categoryEdit" }
              );

                endpoints.MapControllerRoute(
                  name: "adminproductlist",
                  pattern: "admin/products",
                  defaults: new { controller = "Admin", action = "ProductList" }
              );
                endpoints.MapControllerRoute(
                  name: "adminproductcreate",
                  pattern: "admin/products/createProducts",
                  defaults: new { controller = "Admin", action = "createproduct" }
              );
                endpoints.MapControllerRoute(
                  name: "adminproductupdate",
                  pattern: "admin/products/{id?}",
                  defaults: new { controller = "Admin", action = "productEdit" }
              );

                endpoints.MapControllerRoute(
                  name: "searchproductname",
                  pattern: "search",
                  defaults: new { controller = "Shop", action = "search" }
              );
                endpoints.MapControllerRoute(
                   name: "productdetails",
                   pattern: "about",
                   defaults: new { controller = "Shop", action = "about" }
               );
                endpoints.MapControllerRoute(
                   name: "productdetails",
                   pattern: "{url}",
                   defaults: new { controller = "Shop", action = "details" }
               );
                endpoints.MapControllerRoute(
                    name:"products",
                    pattern:"products/{category?}",
                    defaults : new {controller="Shop",action="list"}
                ); 

                endpoints.MapControllerRoute(
                        name: "default",
                        pattern: "{controller=Home}/{action=Index}/{id?}"
                    );
            });
            SeedIdentity.Seed(userManager,roleManager,configuration).Wait();
        }

       
    }
}
