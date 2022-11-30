using Microsoft.EntityFrameworkCore;
using ZHgyakorlas4.Models;

namespace ZHgyakorlas4.Context
{
    public class EFContext : DbContext
    {
        public DbSet<Hero> Heroes;
        public DbSet<Item> Items;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=.//DB//heroes.db");
        }
        
        public DbSet<ZHgyakorlas4.Models.Hero> Hero { get; set; }
        public DbSet<ZHgyakorlas4.Models.Item> Item { get; set; }
    }
}
