using System;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace lab2
{
    public class ConversationContext : DbContext
    {
        public DbSet<Abonent> Abonents { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Conversation> Conversations { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
        }
    }
}
