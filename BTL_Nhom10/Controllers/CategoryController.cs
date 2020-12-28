using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BTL_Nhom10.Areas.Admin.Models;

namespace BTL_Nhom10.Controllers
{
    public class CategoryController : Controller
    {
        Database db = new Database();
        // GET: Category
        public ActionResult Index(string id)
        {
            var danhmucs = from dm in db.DanhMucs select dm;
            foreach(var item in danhmucs)
            {
                if(item.MaDM.Trim() == id)
                {
                    ViewBag.TenDM = item.TenDM;
                }
            }
            List<SanPham> sanphams = new List<SanPham>();
            if (id == null)
            {
                sanphams = db.SanPhams.Select(h => h).ToList();
            }
            else
            {
                sanphams = db.SanPhams.Where(h => h.MaDM.Equals(id)).Select(h => h).ToList();
            }
            return View(sanphams);
        }
        public ActionResult Logout()
        {
            return RedirectToAction("Login", "Home");
        }
    }
}