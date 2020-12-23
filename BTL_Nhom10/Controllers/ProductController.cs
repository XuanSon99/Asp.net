using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BTL_Nhom10.Areas.Admin.Models;

namespace BTL_Nhom10.Controllers
{
    public class ProductController : Controller
    {
        Database db = new Database();
        // GET: Product
        public ActionResult Index(string id)
        {
            List<SanPham> sanphams = new List<SanPham>();
            if (id == null)
            {
                sanphams = db.SanPhams.Select(h => h).ToList();
            }
            else
            {
                sanphams = db.SanPhams.Where(h => h.MaSP.Equals(id)).Select(h => h).ToList();
            }
            return View(sanphams);
        }
    }
}