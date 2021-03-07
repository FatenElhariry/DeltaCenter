using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using SharedKernel.Constants;

namespace DeltaCenter.Infrastructure.Identity
{
    public class AppIdentityDbContextSeed
    {
        public static async Task SeedAsync(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            await roleManager.CreateAsync(new IdentityRole(Roles.ADMINISTRATOR));

            var defaultUser = new ApplicationUser { UserName = "Faten", Email = "aelhariry78@yahoo.com" };
            await userManager.CreateAsync(defaultUser, Defaults.DEFAULT_PASSWORD);

            //string adminUserName = "admin@microsoft.com";
            //var adminUser = new ApplicationUser { UserName = adminUserName, Email = adminUserName };
            //await userManager.CreateAsync(adminUser, Defaults.DEFAULT_PASSWORD);
            //adminUser = await userManager.FindByNameAsync(adminUserName);
            //await userManager.AddToRoleAsync(adminUser, Roles.ADMINISTRATOR);
        }
    }
}
