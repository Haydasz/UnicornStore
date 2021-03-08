using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using UnicornStore.Models;
using System.Collections.Generic;

namespace UnicornStore.Data
{
    public class StoreDbContext : DbContext
    {
        public StoreDbContext(DbContextOptions<StoreDbContext> options)
        : base(options)
        { 

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=UnicornStore");
            //.LogTo(ConsoleLog.WriteLine);
            //.LogTo(ConsoleLog.WriteLine, new[] { DbLoggerCathegory.Database.Command.Name }, LogLevel.Information);
        }
    
        public DbSet<Unicorn> Unicorns { get; set; }
        public DbSet<Power> Powers { get; set; }
    }
}