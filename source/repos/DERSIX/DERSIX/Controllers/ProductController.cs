using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DERSIX.Models;
using Microsoft.AspNetCore.Mvc;

namespace DERSIX.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            
            StoreContext context = HttpContext.RequestServices.GetService(typeof(DERSIX.Models.StoreContext)) as StoreContext;
            
            return View(context.GetProduct());

        }

        public IActionResult deltail(string id)
        {
            StoreContext context = HttpContext.RequestServices.GetService(typeof(DERSIX.Models.StoreContext)) as StoreContext;

            return View(context.detail_product(id));
        }

        public IActionResult Lipsick(string abc)
        {
            StoreContext context = HttpContext.RequestServices.GetService(typeof(DERSIX.Models.StoreContext)) as StoreContext;
           
            return View(context.lipsick_product(abc));
        }
        public IActionResult sreachproduct(string sreach)
        {

            StoreContext context = HttpContext.RequestServices.GetService(typeof(DERSIX.Models.StoreContext)) as StoreContext;

            return View(context.sreachProduct( sreach));

        }

    }
}
