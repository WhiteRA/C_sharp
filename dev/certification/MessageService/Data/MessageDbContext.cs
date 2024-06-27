using Microsoft.EntityFrameworkCore;
using MessageService.Models;
using System.Collections.Generic;

namespace MessageService.Data
{
    public class MessageDbContext : DbContext
    {
        public MessageDbContext(DbContextOptions<MessageDbContext> options)
            : base(options)
        {
        }

        public DbSet<Message> Messages { get; set; }
    }
}
