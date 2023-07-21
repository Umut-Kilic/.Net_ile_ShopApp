using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;

namespace Goksell_WebApp.Identity
{
    public static class SeedIdentity
    {
        public static async Task Seed(UserManager<User> userManager,RoleManager<IdentityRole> roleManager,IConfiguration configuration)
        {
            var userName = configuration["Data:AdminUser:username"];
            var email = configuration["Data:AdminUser:email"];
            var password = configuration["Data:AdminUser:password"];
            var role = configuration["Data:AdminUser:role"];

            if(await userManager.FindByNameAsync(userName) == null)
            {
                await roleManager.CreateAsync(new IdentityRole(role));

                var user = new User()
                {
                    UserName = userName,
                    Email = email,
                    FirstName = "Umut",
                    LastName = "Admin",
                    EmailConfirmed = true
                ,
                };

                var result = await userManager.CreateAsync(user,password);

                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(user, role);
                }
            }
            {

            }
        }
    }
}
