using System.Linq;
using Microsoft.EntityFrameworkCore;
using WebApplication3.Models;

namespace WebApplication3.Data
{
    public class FxContext : DbContext
    {
        public FxContext(DbContextOptions<FxContext> options) : base(options)
        { }

        public DbSet<Strategy> Strategies { get; set; }

        public DbSet<Symbol> Symbols { get; set; }

        public DbSet<TradeType> TradeTypes { get; set; }
 

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Strategy>().ToTable("Strategy");
            modelBuilder.Entity<Symbol>().ToTable("Symbol");
            modelBuilder.Entity<TradeType>().ToTable("TradeType");

            //set precision for all column of type decimal
            foreach (var property in modelBuilder.Model.GetEntityTypes()
                .SelectMany(t => t.GetProperties())
                .Where(p => p.ClrType == typeof(decimal)))
            {
                property.Relational().ColumnType = "decimal(18, 5)";
            }
        }
    }
}
