using System;
using System.Security.Claims;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;

namespace SfPUT.Identity.Data
{
    public static class DatabaseInitializer
    {
        // public static void Init(IServiceProvider serviceProvider)
        // {
        //     var userManager = serviceProvider.GetService<UserManager<IdentityUser>>();
        //
        //     var user = new IdentityUser()
        //     {
        //         UserName = "User",
        //     };
        //
        //     var result = userManager.CreateAsync(user, "123qwe").GetAwaiter().GetResult();
        //     if (result.Succeeded)
        //     {
        //         userManager.AddClaimAsync(user, new Claim(ClaimTypes.Role, "Administrator")).GetAwaiter().GetResult();
        //     }
        //     //context.Users.Add(user);
        //     //context.SaveChanges();
        // }

        public static void Init(ApplicationDbContext dbContext)
        {
            dbContext.Database.EnsureCreated();
        }
    }
}
