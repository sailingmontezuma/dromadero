using System;
using System.Collections.Generic;

namespace Patl.Domain
{
    public class Strategy
    {
        public Strategy()
        {
            Trades= new List<Trade>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public List<Trade> Trades { get; set; }
        public decimal PriceStart { get; set; }
        public decimal PriceEnd { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
    }
}
