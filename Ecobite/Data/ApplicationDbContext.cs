
using Ecobite.Models;
using Microsoft.EntityFrameworkCore;

namespace Ecobite.Data
{

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { 

        }
        public DbSet<UserModel> Users { get; set; }


        public DbSet<FoodItem> FoodItems { get; set; }

        public DbSet<InventoryModel> Inventories { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<FoodItem>().HasData(
        //        new FoodItem { FoodItemId = 1, FoodItemName = "Black Beans", Category = "Beans", Quantity = 10, MFDate = DateOnly.FromDateTime(DateTime.Now).AddMonths(-1), ExpirationDate = DateOnly.FromDateTime(DateTime.Now).AddMonths(24) },
        //        new FoodItem { FoodItemId = 2, FoodItemName = "Rice", Category = "Grains", Quantity = 20, MFDate = DateOnly.FromDateTime(DateTime.Now).AddMonths(-2), ExpirationDate = DateOnly.FromDateTime(DateTime.Now).AddMonths(24) }

        //        );

        //}





    }
            
    
    
}


