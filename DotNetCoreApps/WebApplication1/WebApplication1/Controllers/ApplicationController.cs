using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Views
{
    public class ApplicationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Info()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult Error()
        {
            throw new InvalidOperationException("raz dwa trzy babajaga patrzy");
        }
    }
}