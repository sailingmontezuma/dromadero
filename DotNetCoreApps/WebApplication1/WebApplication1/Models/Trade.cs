using System;

namespace Patl.WebApp.Models
{
    public class Trade
    {
        public int Id  { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Symbol { get; set; }
        public string TransactionType { get; set; }
        public DateTime Open { get; set; }
        public DateTime Close { get; set; }
        public decimal PriceOpen { get; set; }
        public decimal PriceClose { get; set; }
        public bool IsTradeOfTheMonth { get; set; }
        public string ImageThumbnailUrl { get; set; }
        public int CategoryId { get; set; }
        //virtual - is for EF lazy loading only
        public virtual Category Category { get; set; }
    }


}
