using Microsoft.EntityFrameworkCore;
using Patl.Domain;

namespace Patl.Data
{
    public class StrategyContext : DbContext
    {
        public DbSet<Strategy> Strategies { get; set; }
        public DbSet<Trade> Trades { get; set; }

        //_context.Strategies.ToList();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb; Database=FxData; Trusted_Connection=True;");
 
        }
    }
}
