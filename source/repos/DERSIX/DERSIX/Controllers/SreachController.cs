using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DERSIX.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DERSIX.Controllers
{
    public class SreachController : Controller
    {
        public IActionResult Index(string sreach)
        {
            StoreContext context = HttpContext.RequestServices.GetService(typeof(DERSIX.Models.StoreContext)) as StoreContext;
            return View(context.Sreach(sreach));


        }
        public IActionResult Indexsanpham(string sreach)
        {
            StoreContext context = HttpContext.RequestServices.GetService(typeof(DERSIX.Models.StoreContext)) as StoreContext;
            return View(context.Sreach1(sreach));
        }
    }
}
