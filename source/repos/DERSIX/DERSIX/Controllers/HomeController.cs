using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DERSIX.Models;
using Microsoft.AspNetCore.Http;

namespace DERSIX.Controllers
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
            if(HttpContext.Session.GetString("thongbaothanhcong") != null)
            {
                ViewData["thongbaothanhcong"] = "Dang nhap thanh cong";
            }
            if (HttpContext.Session.GetString("thongbaodangkythanhcong") != null)
            {
                ViewData["thongbaodangkythanhcong"] = "Dang ky thanh cong";
            }
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
