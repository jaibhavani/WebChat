using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebBot.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
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

        public IActionResult Chat()
        {
            ViewData["Message"] = "Your chat page.";

            return View();
        }

        public IActionResult SpeechChat()
        {
            ViewData["Message"] = "Your Speechchat page.";

            return View();
        }


        public IActionResult Error()
        {
            return View();
        }
    }
}
