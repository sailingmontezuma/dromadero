using System;
using Microsoft.AspNetCore.Mvc;
using Patl.WebApp.Models;
using Patl.WebApp.ViewModels;

namespace Patl.WebApp.Controllers
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

        public IActionResult Trap()
        {
            throw new InvalidOperationException("zlo w czystej postaci sie stalo");
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}