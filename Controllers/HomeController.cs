﻿using DatabaseFirstCore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Linq;

namespace DatabaseFirstCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        DatabaseFirstContext _context;

        public HomeController(ILogger<HomeController> logger, DatabaseFirstContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            var list = _context.Oyuncus.Include(a => a.MevkiNavigation).ThenInclude(a => a.Oyuncus).ThenInclude(a => a.Takim).ThenInclude(a => a.Oyuncus).ThenInclude(a => a.UlkeNavigation);
            return View(list);
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
