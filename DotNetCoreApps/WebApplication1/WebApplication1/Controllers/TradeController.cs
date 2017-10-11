using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.ViewModels;

namespace WebApplication1.Controllers
{
    public class TradeController : Microsoft.AspNetCore.Mvc.Controller
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly ITradeRepository _tradeRepository;

        public TradeController(ITradeRepository tradeRepository, ICategoryRepository categoryRepository)
        {
            _tradeRepository = tradeRepository;
            _categoryRepository = categoryRepository;
        }

        public ViewResult List()
        {
            throw new AccessViolationException("defwef");
            TradesListViewModel tradesListViewModel = new TradesListViewModel();
            tradesListViewModel.Trades = _tradeRepository.Trades;
            ViewBag.CurrentCategory = "cheese";
            return View(tradesListViewModel);
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}