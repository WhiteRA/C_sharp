using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

public class MessagingContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Message> Messages { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=messaging.db");
    }
}

