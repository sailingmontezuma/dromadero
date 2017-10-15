using Microsoft.AspNetCore.Mvc;
using System;
using Microsoft.Extensions.Configuration;
using WebApplication1.Services;
using WebApplication1.ViewModels;

namespace WebApplication1.Views
{
    public class ApplicationController : Controller
    {
        private IMailService _mailService;
        private IConfigurationRoot _config;

        public ApplicationController(IMailService mailService, IConfigurationRoot config)
        {
            _mailService = mailService;
            _config = config;
        }


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

        [HttpPost]
        public IActionResult Contact(ContactViewModel model)
        {
            if (model.Email.Contains("aol.com"))
            {
                ModelState.AddModelError("", "We don't support AOL addresses");
            }

            string emailaddress = _config["MailSettings:ToAddress"];

            if (ModelState.IsValid)
            {
                _mailService.SendMail(_config["MailSettings:ToAddress"], model.Email, "From TheWorld", model.Message);
                ModelState.Clear();
                ViewBag.UserMessage = "Message Sent";
            }
            return View();
        }

        public IActionResult Error()
        {
            throw new InvalidOperationException("raz dwa trzy babajaga patrzy");
        }
    }
}