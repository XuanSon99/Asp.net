using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BTL_Nhom10.Areas.Admin.Models;

namespace BTL_Nhom10.Controllers
{
    public class SearchController : Controller
    {
        Database db = new Database();
        // GET: Search
        public ActionResult Index(string search_query)
        {
            ViewBag.searchText = search_query;
            var sanphams = from sp in db.SanPhams select sp;
            if (!String.IsNullOrEmpty(search_query))
            {
                sanphams = sanphams.Where(s => s.TenSP.Contains(search_query));
            }
            return View(sanphams);
        }
    }
}