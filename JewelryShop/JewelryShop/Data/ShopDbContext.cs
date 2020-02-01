using JewelryShop.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JewelryShop.Data
{
    public class ShopDbContext : DbContext
    {
        public ShopDbContext(DbContextOptions<ShopDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<JewelryItem>().HasData(
                new JewelryItem
                {
                    ID = 1,
                    Name = "Blue Earring Set",
                    Description = "Expertly hand crafted earrings perfect for a night out",
                    InStock = "Yes - Limited",
                    Picture1 = "~/Assets/Set1.1.jpg",
                    Picture2 = "~/Assets/Set1.2.jpg",
                    Picture3 = "~/Assets/Set1.3.jpg",
                    Price = "50$"


                }
            );
        }
        public DbSet<JewelryItem> JewelryItem { get; set; }
    }
}
