using System;
using System.Security.Claims;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;

namespace SfPUT.Identity.Data
{
    public static class DbInitializer
    {
        public static void Init(AppDbContext dbContext)
        {
            dbContext.Database.EnsureCreated();
        }
    }
}
