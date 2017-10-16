using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patl.Domain
{
    public class Transaction
    {
        public int Id { get; set; }
        public decimal Commision { get; set; }
        public decimal Swap { get; set; }
        public decimal Profit { get; set; }
        public int TradeId { get; set; }
        public Trade Trade { get; set; }
    }
}
