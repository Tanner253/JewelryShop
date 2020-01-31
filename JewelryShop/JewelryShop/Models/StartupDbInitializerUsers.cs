using JewelryShop.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JewelryShop.Models
{
    public class StartupDbInitializerUsers
    {
        private static List<IdentityRole> Roles = new List<IdentityRole>()
        {
            new IdentityRole{Name = ApplicationRoles.Admin, NormalizedName = ApplicationRoles.Admin.ToUpper()},
             new IdentityRole{Name = ApplicationRoles.Member, NormalizedName = ApplicationRoles.Member.ToUpper()}
        };

        private static void AddRoles(UserDbContext context)
        {
            if (context.Roles.Any())
            {
                return;
            }
            foreach (var role in Roles)
            {
                context.Roles.Add(role);
                context.SaveChanges();
            }
        }

        public static void SeedData(IServiceProvider servicesProvider, UserManager<ApplicationUser> userManager)
        {
            using (var dbContext = new UserDbContext(servicesProvider.GetRequiredService<DbContextOptions<UserDbContext>>()))
            {


                dbContext.Database.EnsureCreated();
                AddRoles(dbContext);
                //SeedUsers(userManager);
            }
        }
    }
}
