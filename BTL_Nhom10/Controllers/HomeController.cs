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
        // GET: Home
        Database db = new Database();
        public ActionResult Index()
        {
            var sanphams = db.SanPhams.Select(h => h);
            return View(sanphams);
        }
        public PartialViewResult _Category()
        {
            var danhmucs = db.DanhMucs.Select(n => n);
            return PartialView(danhmucs);
        }
        public PartialViewResult _Nav()
        {
            var danhmucs = db.DanhMucs.Select(n => n);
            return PartialView(danhmucs);
        }
    }
}