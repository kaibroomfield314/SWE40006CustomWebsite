using System.Diagnostics;
using CustomWebsite.Models;
using Microsoft.AspNetCore.Mvc;

namespace CustomWebsite.Controllers
{
    public class HomeController : Controller
    {
        private static int count = 0;

        public IActionResult Index()
        {
            ViewBag.Count = count;
            return View();
        }

        public IActionResult Increment()
        {
            count++;
            return RedirectToAction("Index");
        }

        public IActionResult Decrement()
        {
            count--;
            return RedirectToAction("Index");
        }

        public IActionResult Reset()
        {
            count = 0;
            return RedirectToAction("Index");
        }
    }
}
