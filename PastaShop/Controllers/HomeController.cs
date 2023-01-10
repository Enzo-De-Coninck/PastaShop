using Microsoft.AspNetCore.Mvc;
using PastaShop.Models;
using PastaShop.Services;
using System.Diagnostics;

namespace PastaShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly PastaService _pastaService;

        public HomeController(PastaService pastaService)
        {
            _pastaService = pastaService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Nieuwsbrief()
        {
            return View();
        }
       

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        [HttpGet]
        public IActionResult Toevoegen()
        {
            var bestelling = new Bestelling();
            return View(bestelling);
        }

        [HttpPost]
        public IActionResult Toevoegen(Bestelling b)
        {
            if (this.ModelState.IsValid)
            {
                _pastaService.Add(b);
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(b);
            }
        }

        public IActionResult Mandje()
        {
            return View(_pastaService.FindAll());
        }
    }
}