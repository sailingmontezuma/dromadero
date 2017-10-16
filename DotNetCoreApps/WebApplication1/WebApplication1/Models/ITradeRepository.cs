using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Patl.WebApp.Models
{
    public interface ITradeRepository
    {
        IEnumerable<Trade> Trades { get; }
        IEnumerable<Trade> TradesOfTheMonth { get; }

        Trade GeTradeById(int id);
    }
}
