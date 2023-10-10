﻿using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Tur_agen_asp_net.Models;
using System.Collections;

namespace Tur_agen_asp_net.Controllers
{

  
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

      
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<Country> list_countris = new List<Country>()
                {
                 new Country()
                {
                      Id = 1,
                 Country_name = "Турция",
                  Picture =""
                 }
                    };

            return View(list_countris);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}