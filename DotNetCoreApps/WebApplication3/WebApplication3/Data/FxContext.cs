using Microsoft.EntityFrameworkCore;
using WebApplication3.Models;

namespace WebApplication3.Data
{
    public class FxContext : DbContext
    {

        public FxContext(DbContextOptions<FxContext> options) : base(options)
        {
        }
        public DbSet<Strategy> Strategies { get; set; }
 

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Strategy>().ToTable("Strategy");
 
        }
    }
}
