using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Data;
using UserService.Models;

namespace UserService.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
    }
}
