using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class TradeController : Microsoft.AspNetCore.Mvc.Controller
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly ITradeRepository _tradeRepository;

        public TradeController(ITradeRepository tradeRepository, ICategoryRepository categoryRepository)
        {
            _tradeRepository = tradeRepository;
        }

        public ViewResult List()
        {
            return View(_tradeRepository.Trades);
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}