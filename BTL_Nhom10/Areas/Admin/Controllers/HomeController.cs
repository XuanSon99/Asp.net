using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BTL_Nhom10.Areas.Admin.Models;
namespace BTL_Nhom10.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        // GET: Admin/Home
        public ActionResult Index()
        {
            if(Session["TaiKhoan1"] !=null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

        public ActionResult Category()
        {
            return View();
        }

        public ActionResult Product()
        {
            return View();
        }

        public ActionResult EditCategory()
        {
            return View();
        }

        public ActionResult AddProduct()
        {
            return View();
        }

        public ActionResult EditProduct()
        {
            return View();
        }

        public ActionResult UserManage()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        Database db = new Database();
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(string TaiKhoan1, string MatKhau)
        {
            if(ModelState.IsValid)
            {
                var user = db.TaiKhoans.Where(u => u.TaiKhoan1.Equals(TaiKhoan1) && u.MatKhau.Equals(MatKhau)).ToList();
                if(user.Count() > 0)
                {
                    Session["TaiKhoan1"] = user.FirstOrDefault().TaiKhoan1;
                    Session["MatKhau"] = user.FirstOrDefault().MatKhau;
                    return RedirectToAction("Index");

                }
                else
                {
                    ViewBag.Error = "Sai tài khoản hoặc mật khẩu!";
                }
            }
            return View();
        }

        public ActionResult Logout()
        {
            Session.Clear();
            return RedirectToAction("Login");
        }
    }
}