using DatabaseFirstCore.Models;
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
            return View(from Oyuncu in _context.Oyuncus
                        join Mevki in _context.Mevkis on Oyuncu.Mevki equals Mevki.Id
                        join Takim in _context.Takims on Oyuncu.TakimId equals Takim.Id
                        join Ulke in _context.Ulkes on Oyuncu.Ulke equals Ulke.Id
                        select new ListeViewModel
                        {
                            Adi = Oyuncu.Adi,
                            Maas = Oyuncu.Maas,
                            MevkiAdi = Mevki.MevkiAdi,
                            Soyadi = Oyuncu.Soyadi,
                            SozlesmeSuresi = Oyuncu.SozlesmeSuresi,
                            TakimAdi = Takim.TakimAdi,
                            UlkeAdi = Ulke.UlkeAdi,
                            Yasi = Oyuncu.Yasi,
                        });
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
