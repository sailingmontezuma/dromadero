using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Patl.WebApp.Models
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
                    new Trade{ IsTradeOfTheMonth = false, PriceOpen = 122.3M, TradeId = 1, ImageThumbnailUrl = "/Images/carousel1.jpg", Description = "trade 1",
                        Open = new DateTime(2017, 10, 10, 11, 34, 32, DateTimeKind.Utc), Name = "trade number one"},
                    new Trade{ IsTradeOfTheMonth = false, PriceOpen = 124.35M, TradeId = 2, ImageThumbnailUrl = "/Images/carousel2.jpg", Description = "trade 2",
                        Open = new DateTime(2017, 9, 10, 11, 23, 52, DateTimeKind.Utc), Name = "trade number two"},
                    new Trade{ IsTradeOfTheMonth = false, PriceOpen = 34.3235M, TradeId = 3, ImageThumbnailUrl = "/Images/carousel3.jpg", Description = "trade 3",
                    Open = new DateTime(2017, 8, 12, 11, 11, 23, DateTimeKind.Utc), Name = "trade three"}
                };
            }
        }

        public IEnumerable<Trade> TradesOfTheMonth { get; }
        public Trade GeTradeById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
