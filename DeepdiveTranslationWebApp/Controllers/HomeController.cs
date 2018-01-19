using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DeepdiveTranslationWebApp.Models;
using System.Globalization;
using Microsoft.Extensions.Localization;
using DeepdiveTranslationWebApp.Resources;

namespace DeepdiveTranslationWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IStringLocalizer localizer;
        public HomeController(IStringLocalizerFactory factory)
        {
            localizer = factory.Create(typeof(SharedResources));
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = CultureInfo.CurrentUICulture.ToString();

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = localizer["ContactUs"];

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
