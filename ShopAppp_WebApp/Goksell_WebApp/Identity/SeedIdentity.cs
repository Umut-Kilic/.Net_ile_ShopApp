using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using System.Linq;
using System.Threading.Tasks;

namespace Goksell_WebApp.Identity
{
    public static class SeedIdentity
    {
        public static async Task Seed(UserManager<User> userManager,RoleManager<IdentityRole> roleManager,ICartService cartService,IConfiguration configuration)
        {

            var roles = configuration.GetSection("Data:Role").GetChildren().Select(i=>i.Value).ToArray();

            foreach (var item in roles)
            {
                if(!await roleManager.RoleExistsAsync(item))
                {
                await roleManager.CreateAsync(new IdentityRole(item));

                }

            }

            var users = configuration.GetSection("Data:Users");

            foreach (var section in users.GetChildren())
            {
                var userName = section.GetValue<string>("username");
                var password = section.GetValue<string>("password");
                var email = section.GetValue<string>("email");
                var role = section.GetValue<string>("role");
                var firstName = section.GetValue<string>("firstname");
                var lastName = section.GetValue<string>("lastname");


                if (await userManager.FindByNameAsync(userName) == null)
                {
                    var user = new User()
                    {
                        UserName = userName,
                        Email = email,
                        FirstName = firstName,
                        LastName = lastName,
                        EmailConfirmed = true
                    ,
                    };

                    var result = await userManager.CreateAsync(user, password);

                    if (result.Succeeded)
                    {
                        await userManager.AddToRoleAsync(user, role);
                        cartService.InitializeCart(user.Id);
                    }
                }


            }
        }
    }
}
