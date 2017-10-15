using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Patl.Domain;

namespace Patl.Data
{
    public class StrategyContext : DbContext
    {
        private IConfigurationRoot _config;

        public StrategyContext(IConfigurationRoot config, DbContextOptions options) : base(options)
        {
            _config = config;
        }

        public DbSet<Strategy> Strategies { get; set; }
        public DbSet<Trade> Trades { get; set; }
        //_context.Strategies.ToList();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(_config["ConnectionStrings:DefaultConnection"]);
            //optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb; Database=FxData2; Trusted_Connection=True;");
        }
    }
}
