using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DERSIX.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DERSIX.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            if(HttpContext.Session.GetString("thongbaoloi") != null)
            {
                ViewData["thongbao"] = "Dang nhap khong thanh cong";
            }
            if(HttpContext.Session.GetString("checktaikhoan") != null)
            {
                ViewData["checktaikhoan"] = "Tai khoan hoac Email da duoc dang ky";
            }
            return View();
        }
        public IActionResult txt_login(string Username, string Password)
        {
            StoreContext context = HttpContext.RequestServices.GetService(typeof(DERSIX.Models.StoreContext)) as StoreContext;
            if (context.GetKhachhang(Username, Password) != 0)
            {
                HttpContext.Session.SetString("user", Username);
                HttpContext.Session.SetString("thongbaothanhcong", "");
                return Redirect("/AdminHome/Index");
            }
            else
            {
                //ViewData["thongbao"] = "Tai khoang hoac mat khau khong dung";
                HttpContext.Session.SetString("thongbaoloi", "a");
                return Redirect("/Account/Index");
            }
           
        }

        public IActionResult txt_Register(string Username1, string Email1,string Password1)
        {
            StoreContext context = HttpContext.RequestServices.GetService(typeof(DERSIX.Models.StoreContext)) as StoreContext;
            if (context.Checkkhachhang(Username1, Email1) != 0)
            {
                HttpContext.Session.SetString("checktaikhoan", "a");
                return Redirect("/Account/Index");
            }
            else
            {
                khachhang k = new khachhang(Username1, Email1, Password1);
                if(context.Insert_khachhang(k) != 0)
                {
                    HttpContext.Session.SetString("thongbaodangkythanhcong", "");
                    return Redirect("/Home/Index");
                }
            }
            return View();
        }
    }
}
