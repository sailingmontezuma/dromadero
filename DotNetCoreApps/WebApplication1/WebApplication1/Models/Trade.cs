using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Trade
    {
        public int Id  { get; set; }
        public DateTime Open { get; set; }
        public DateTime Close { get; set; }
        public decimal PriceOpen { get; set; }
        public decimal PriceClose { get; set; }

        public bool IsTradeOfTheMonth { get; set; }
        public virtual Category Category { get; set; }
    }


}
