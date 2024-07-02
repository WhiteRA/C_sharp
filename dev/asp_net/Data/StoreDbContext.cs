using asp_net.Models;
using Microsoft.EntityFrameworkCore;
using StoreApp.Models;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace asp_net.Data
{

    namespace StoreApp.Data
    {
        public class StoreDbContext : DbContext
        {
            public StoreDbContext(DbContextOptions<StoreDbContext> options) : base(options)
            {
            }

            public DbSet<Group> Groups { get; set; }
            public DbSet<Product> Products { get; set; }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                base.OnModelCreating(modelBuilder);

                modelBuilder.Entity<Group>().HasData(
                    new Group { GroupId = 1, GroupName = "Electronics" },
                    new Group { GroupId = 2, GroupName = "Books" }
                );

                modelBuilder.Entity<Product>().HasData(
                    new Product { ProductId = 1, ProductName = "Laptop", Price = 1000.00M, GroupId = 1 },
                    new Product { ProductId = 2, ProductName = "Headphones", Price = 200.00M, GroupId = 1 },
                    new Product { ProductId = 3, ProductName = "Book A", Price = 20.00M, GroupId = 2 }
                );
            }
        }
    }

}
