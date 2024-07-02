using System.Collections.Generic;
using WarehouseService.Models;

namespace WarehouseService.Data
{
    public class WarehouseDbContext : DbContext
    {
        public WarehouseDbContext(DbContextOptions<WarehouseDbContext> options) : base(options)
        {
        }

        public DbSet<WarehouseItem> WarehouseItems { get; set; }
    }
}
