using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DERSIX.Models;
using Microsoft.AspNetCore.Mvc;

namespace DERSIX.Controllers
{
    public class AdminHomeController : Controller
    {
        public IActionResult Index()
        {
            StoreContext context = HttpContext.RequestServices.GetService(typeof(DERSIX.Models.StoreContext)) as StoreContext;
            return View(context.Gethoadon());
        }
        public IActionResult Indexchitietdonhang(int id)
        {
            StoreContext context = HttpContext.RequestServices.GetService(typeof(DERSIX.Models.StoreContext)) as StoreContext;
            return View(context.chitiethoadon(id));
        }

        public IActionResult delete_hoadon(int id)
        {
            StoreContext context = HttpContext.RequestServices.GetService(typeof(DERSIX.Models.StoreContext)) as StoreContext;
            if (context.xoa_hoadon(id) != null)
            {
                return Redirect("/AdminHome/Index");
            }
            return Redirect("/AdminHome/Index");
        }
        public IActionResult delete_cthoadon(int id)
        {
            StoreContext context = HttpContext.RequestServices.GetService(typeof(DERSIX.Models.StoreContext)) as StoreContext;
            if (context.xoa_cthoadon(id) != null)
            {
                return Redirect("/AdminHome/Index");
            }
            return Redirect("/AdminHome/Index");
        }
        public IActionResult sanpham()
        {
            StoreContext context = HttpContext.RequestServices.GetService(typeof(DERSIX.Models.StoreContext)) as StoreContext;
            return View(context.GetProduct());
        }
        public IActionResult delete_sanpham(int id)
        {
            StoreContext context = HttpContext.RequestServices.GetService(typeof(DERSIX.Models.StoreContext)) as StoreContext;
            if (context.xoa_sanpham(id) != null)
            {
                return Redirect("/AdminHome/sanpham");
            }
            return Redirect("/AdminHome/sanpham");
        }
        public IActionResult Them_sp(Product h)
        {
            StoreContext context = HttpContext.RequestServices.GetService(typeof(DERSIX.Models.StoreContext)) as StoreContext;
            if (context.Them_sanpham(h) != null)
            {
                return Redirect("/AdminHome/sanpham");
            }
            return Redirect("/AdminHome/sanpham");
        }
        public IActionResult Themsp()
        {
            return View();
        }
    }
}
