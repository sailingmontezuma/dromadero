using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Patl.WebApp.Models;

namespace Patl.WebApp.ViewModels
{
    public class TradesListViewModel
    {
        public IEnumerable<Trade> Trades { get; set; }
        public string CurrentCategory { get; set; }
    }
}
