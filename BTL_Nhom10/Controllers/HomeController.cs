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
    }
}