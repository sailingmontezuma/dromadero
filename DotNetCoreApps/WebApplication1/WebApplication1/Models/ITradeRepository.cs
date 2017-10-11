using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public interface ITradeRepository
    {
        IEnumerable<Trade> Trades { get; }
        IEnumerable<Trade> TradesOfTheMonth { get; }

        Trade GeTradeById(int id);
    }
}
