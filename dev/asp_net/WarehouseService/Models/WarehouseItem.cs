using System.Collections.Generic;

namespace WarehouseService.Models
{
    public class WarehouseItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }

    public class WarehouseDbContext : DbContext
    {
        public WarehouseDbContext(DbContextOptions<WarehouseDbContext> options) : base(options)
        {
        }

        public DbSet<WarehouseItem> WarehouseProducts { get; set; }
    }

}
