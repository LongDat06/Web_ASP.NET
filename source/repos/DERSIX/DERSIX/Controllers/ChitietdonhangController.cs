using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DERSIX.Models;
using Microsoft.AspNetCore.Mvc;

namespace DERSIX.Controllers
{
    public class ChitietdonhangController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult chitiet(string Email)
        {
            StoreContext context = HttpContext.RequestServices.GetService(typeof(DERSIX.Models.StoreContext)) as StoreContext;
            return View(context.CheckDonhang(Email));
        }
        public IActionResult chitiethoadon(int id)
        {
            StoreContext context = HttpContext.RequestServices.GetService(typeof(DERSIX.Models.StoreContext)) as StoreContext;
            return View(context.chitiethoadon(id));
        }

    }
}
