using System;
using System.Collections.Generic;

namespace Patl.WebApp.Models
{
    public class Category
    {
        public Guid CategoryId { get; set; }
        public string Name { get; set; }
        public List<Trade> Trades { get; set; }
    }
}
