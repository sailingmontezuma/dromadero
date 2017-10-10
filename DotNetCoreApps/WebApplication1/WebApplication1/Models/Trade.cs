using System;

namespace WebApplication1.Models
{
    public class Trade
    {
        public int Id  { get; set; }
        public string Symbol { get; set; }
        public string TransactionType { get; set; }
        public DateTime Open { get; set; }
        public DateTime Close { get; set; }
        public decimal PriceOpen { get; set; }
        public decimal PriceClose { get; set; }
        public bool IsTradeOfTheMonth { get; set; }
        public virtual Category Category { get; set; }
    }


}
