using System;
using System.Collections.Generic;

namespace Patl.Domain
{
    public class Strategy
    {
        public Strategy()
        {
            Trades = new List<Trade>();
            Comments = new List<Comment>();
        }
        public int Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public bool IsActive { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal PriceStart { get; set; }
        public int PriceStartTolerance { get; set; }
        public decimal PriceEnd { get; set; }
        public int PriceEndTolerance { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public SymbolEnum Symbol { get; set; }
        public TradeTypeEnum TradeType { get; set; }

        /// <summary>
        /// Strategy relelated to.
        /// As a follow up
        /// </summary>
        public int ParentStrategyId { get; set; }
        public virtual Strategy ParentStrategy { get; set; }

        public List<Trade> Trades { get; set; }
        public List<Comment> Comments { get; set; }
    }
}
