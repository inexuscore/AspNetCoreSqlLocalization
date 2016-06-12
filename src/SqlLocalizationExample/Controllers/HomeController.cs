using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;

namespace SqlLocalizationExample.Controllers
{
    public class HomeController : Controller
    {
        private readonly IStringLocalizer<HomeController> _homeLocalizer;

        public HomeController(IStringLocalizer<HomeController> homeLocalizer)
        {
            _homeLocalizer = homeLocalizer;
        }

        public IActionResult Index()
        {
            ViewData["PageTitle"] = _homeLocalizer["HomeTitle"];
            ViewData["WelcomeMessage"] = _homeLocalizer["WelcomeMessage"];

            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
