using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.ViewModels
{
    public class TradesListViewModel
    {
        public IEnumerable<Trade> Trades { get; set; }
        public string CurrentCategory { get; set; }
    }
}
