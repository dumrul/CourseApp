using System;
using Microsoft.AspNetCore.Mvc;

namespace courseapp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            int saat = DateTime.Now.Hour;

            ViewBag.Greeting = saat > 12 ? "İyi günler" : "Günaydın";
            ViewBag.UserName = "Sadık";

            return View();
        }
    }
}