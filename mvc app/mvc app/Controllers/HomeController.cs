using database;
using Microsoft.AspNetCore.Mvc;
using mvc_app.Models;
using System.Collections.Generic;
using System.Diagnostics;

namespace mvc_app.Controllers
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
            List<Tworcy> tworcy = new List<Tworcy>();
            Tworcy tworca1 = new Tworcy();
            tworca1.Name = "Olusus";
            tworca1.Email = "aleksander.bojdys@gmail.com";
            tworca1.ImageLink = "https://avatars.githubusercontent.com/u/114064603?s=96&v=4";
            tworcy.Add(tworca1);
            Tworcy tworca2 = new Tworcy("markom@gmail.com", "MarKom", "data:image/png;base64,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");
            tworcy.Add(tworca2);
            tworcy.Add(new Tworcy { Email = "darek@o2.pl", Name = "Darek",ImageLink= "https://avatars.githubusercontent.com/u/39002523?v=4" });

            return View(tworcy);

        }
        public IActionResult Description()
        {
            return View();
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