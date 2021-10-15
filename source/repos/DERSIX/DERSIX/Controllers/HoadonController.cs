using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DERSIX.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace DERSIX.Controllers
{
    public class HoadonController : Controller
    {
        public IActionResult Index()
        {
            if(HttpContext.Session.GetInt32("tongtien") != null)
            {
                ViewData["tongtien"] = HttpContext.Session.GetInt32("tongtien");
            }
            return View();
        }
        public IActionResult checkGiohang(int tongtien)
        {
            StoreContext context = HttpContext.RequestServices.GetService(typeof(DERSIX.Models.StoreContext)) as StoreContext;
            var cart = HttpContext.Session.GetString("GioHang");
            if(cart != null)
            {
                HttpContext.Session.SetInt32("tongtien", tongtien);
                return Redirect("/Hoadon/Index");
            }
            else
            {
                HttpContext.Session.SetString("thongbaoloigiohang", "a");
                return Redirect("/Giohang/Index");
            }
        }
        public IActionResult Add_hoadon(Hoadon h)
        {
            StoreContext context = HttpContext.RequestServices.GetService(typeof(DERSIX.Models.StoreContext)) as StoreContext;
            var cart = HttpContext.Session.GetString("GioHang");
            List<Cart> dataCart = JsonConvert.DeserializeObject<List<Cart>>(cart);
            if (context.Insert(dataCart,h) != 0)
            {
                HttpContext.Session.SetString("thongbaodangkythanhcong", "");
                HttpContext.Session.Remove("GioHang");
                return Redirect("/Giohang/Index");
            }
            
            return View();
        }
       
    }
}
