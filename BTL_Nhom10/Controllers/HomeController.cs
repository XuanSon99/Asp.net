using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BTL_Nhom10.Areas.Admin.Models;

namespace BTL_Nhom10.Controllers
{
    public class HomeController : Controller
    {
        Database db = new Database();
        // GET: Home
        public ActionResult Index()
        {
           
                List<SanPham> sanphams = new List<SanPham>();
                sanphams = db.SanPhams.Select(h => h).ToList();
                return View(sanphams);
           
           
        }
        public PartialViewResult _Nav()
        {
            var danhmucs = db.DanhMucs.Select(h => h);
            return PartialView(danhmucs);
        }
        public PartialViewResult _Category()
        {
            var danhmucs = db.DanhMucs.Select(h => h);
            return PartialView(danhmucs);
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(string TaiKhoan1, string MatKhau)
        {
            if (ModelState.IsValid)
            {
                var user = db.TaiKhoans.Where(u => u.TaiKhoan1.Equals(TaiKhoan1) && u.MatKhau.Equals(MatKhau)).ToList();
                if (user.Count() > 0)
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
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(TaiKhoan taiKhoan)
        {
            var name = taiKhoan.TaiKhoan1;
            var pass = taiKhoan.MatKhau;
            var email = taiKhoan.Email;
            taiKhoan.Level = false;
            if(ModelState.IsValid)
            {
                db.TaiKhoans.Add(taiKhoan);
                db.SaveChanges();
                return RedirectToAction("Login");
            }
            return View();
        }
    }
}