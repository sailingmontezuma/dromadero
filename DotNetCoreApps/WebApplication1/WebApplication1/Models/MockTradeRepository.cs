using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class MockTradeRepository : ITradeRepository
    {
        private readonly ICategoryRepository _category = new MockCategoryRepository();

        public IEnumerable<Trade> Trades
        {
            get
            {
                return new List<Trade>
                {
                    new Trade{ IsTradeOfTheMonth = false, PriceOpen = 122.3M, Id = 1, 
                        Open = new DateTime(2017, 10, 10, 11, 34, 32, DateTimeKind.Utc)},
                    new Trade{ IsTradeOfTheMonth = false, PriceOpen = 124.35M, Id = 2,
                        Open = new DateTime(2017, 9, 10, 11, 23, 52, DateTimeKind.Utc)},
                    new Trade{ IsTradeOfTheMonth = false, PriceOpen = 34.3235M, Id = 3,
                    Open = new DateTime(2017, 8, 12, 11, 11, 23, DateTimeKind.Utc)}
                };
            }
        }

        public IEnumerable<Trade> TradesOfTheMonth { get; }
        public Trade GeTradeById(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
