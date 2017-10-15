using System;
using System.Collections.Generic;

namespace Patl.Domain
{
    public class Category
    {
        public Category()
        {
            Trades = new List<Trade>();
        }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<Trade> Trades { get; set; }
    }
}
