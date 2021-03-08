using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using YSKProje.ToDo.Entities.Concrete;

namespace YSKProje.ToDo.Web
{
    public static class IdentityInitializer
    {
        public static async Task SeedData(UserManager<AppUser> userManager, RoleManager<AppRole> roleManager)
        {
            var adminRole = await roleManager.FindByNameAsync("Admin");
            if (adminRole==null)
            {
                await roleManager.CreateAsync(new AppRole {Name = "Admin"});
            }  
            var memberRole = await roleManager.FindByNameAsync("Member");
            if (adminRole==null)
            {
                await roleManager.CreateAsync(new AppRole {Name = "Member"});
            }

            var adminUser = await userManager.FindByNameAsync("derya");
            if (adminUser==null)
            {
                AppUser user = new AppUser
                {
                    Name = "Derya",
                    Surname="Ünver",
                    UserName="derya",
                    Email="derya@gmail.com"
                };
                await userManager.CreateAsync(user,"1");
                await userManager.AddToRoleAsync(user, "Admin");
            }
        }
    }
}
