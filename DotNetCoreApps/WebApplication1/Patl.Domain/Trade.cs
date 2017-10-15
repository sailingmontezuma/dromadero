using System;
using System.Collections.Generic;

namespace Patl.Domain
{
    public class Trade
    {
        public Trade()
        {
            Comments = new List<Comment>();
        }
        public int Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public int OrderNumber { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string TransactionType { get; set; }
        public DateTime DateOpen { get; set; }
        public DateTime DateClose { get; set; }
        public decimal PriceOpen { get; set; }
        public decimal PriceClose { get; set; }
        public bool IsTradeOfTheMonth { get; set; }
        public string ImageThumbnailUrl { get; set; }
        public decimal Profit { get; set; }
        public int Size { get; set; }
        public SymbolEnum Symbol { get; set; }
        public TradeTypeEnum TradeType { get; set; }

        public int StrategyId { get; set; }
        public virtual Strategy Strategy { get; set; }
        public List<Comment> Comments { get; set; }
        public int CategoryId { get; set; }
        //virtual - is for EF lazy loading only
        public virtual Category Category { get; set; }
    }
}
