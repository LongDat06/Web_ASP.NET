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
    public class GiohangController : Controller
    {
        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("thongbaoloigiohang") != null)
            {
                ViewData["thongbaoloigiohang"] = "Gio hang khong co san pham";
            }
            HttpContext.Session.Remove("thongbaoloigiohang");
            StoreContext context = HttpContext.RequestServices.GetService(typeof(DERSIX.Models.StoreContext)) as StoreContext;
            if (HttpContext.Session.GetString("GioHang") != null)
            {
                var cart = HttpContext.Session.GetString("GioHang");
                List<Cart> dataCart = JsonConvert.DeserializeObject<List<Cart>>(cart);
                if (dataCart.Count > 0)
                {
                    ViewBag.carts = dataCart;
                    return View();
                }
            }

            return View();
        }
        public IActionResult Add_cart(string product_id )
        {
            StoreContext context = HttpContext.RequestServices.GetService(typeof(DERSIX.Models.StoreContext)) as StoreContext;

            if (HttpContext.Session.GetString("GioHang") == null)
            {
                var product = context.Product_id(product_id);
                List<Cart> listCart = new List<Cart>()
               {
                   new Cart
                   {
                       Product = product,
                       Quantity = 1
                   }
               };
                HttpContext.Session.SetString("GioHang", JsonConvert.SerializeObject(listCart));

            }
            else
            {
                var cart = HttpContext.Session.GetString("GioHang");
                List<Cart> dataCart = JsonConvert.DeserializeObject<List<Cart>>(cart);
                bool check = true;
                for (int i = 0; i < dataCart.Count; i++)
                {
                    if (dataCart[i].Product.Id == product_id)
                    {
                        dataCart[i].Quantity++;
                        check = false;
                    }
                }
                if (check)
                {
                    var product = context.Product_id(product_id);
                    dataCart.Add(new Cart
                    {
                        Product = product,
                        Quantity = 1
                    });
                }
                HttpContext.Session.SetString("GioHang", JsonConvert.SerializeObject(dataCart));

            }

            return Redirect("/Giohang/Index");
        }
        public IActionResult Delete_cart(string product_id)
        {
            StoreContext context = HttpContext.RequestServices.GetService(typeof(DERSIX.Models.StoreContext)) as StoreContext;
            var cart = HttpContext.Session.GetString("GioHang");
            if (cart != null)
            {
                List<Cart> dataCart = JsonConvert.DeserializeObject<List<Cart>>(cart);
                for (int i = 0; i < dataCart.Count; i++)
                {
                    if (dataCart[i].Product.Id == product_id)
                    {
                        dataCart.RemoveAt(i);
                    }
                }
                HttpContext.Session.SetString("GioHang", JsonConvert.SerializeObject(dataCart));


            }
            return Redirect("/Giohang/Index");
        }
    }
}
