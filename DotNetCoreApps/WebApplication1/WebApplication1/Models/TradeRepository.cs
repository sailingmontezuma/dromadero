using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Patl.WebApp.Models
{
    public class TradeRepository : ITradeRepository
    {
        private readonly AppDbContext _appDbContext;

        public TradeRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Trade> Trades
        {
            get { return _appDbContext.Trades.Include(c => c.Category); }
        }

        public IEnumerable<Trade> TradesOfTheMonth
        {
            get { return _appDbContext.Trades.Include(c => c.Category).Where(t => t.IsTradeOfTheMonth); }
        }

        public Trade GeTradeById(int id)
        {
            return _appDbContext.Trades.FirstOrDefault(t => t.Id == id);
        }
    }
}
