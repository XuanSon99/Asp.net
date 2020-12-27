using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BTL_Nhom10.Models;
using System.Web.UI;

namespace BTL_Nhom10.Controllers
{
    public class DonHangsController : Controller
    {
        private Cima_DB db = new Cima_DB();

        // GET: DonHangs
        public async Task<ActionResult> Index()
        {
            return View(await db.DonHangs.ToListAsync());
        }

        // GET: DonHangs/Details/5
        public async Task<ActionResult> Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DonHang donHang = await db.DonHangs.FindAsync(id);
            if (donHang == null)
            {
                return HttpNotFound();
            }
            return View(donHang);
        }

        // GET: DonHangs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DonHangs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "MaDH,NgayDat,NguoiDat,Email,Phone,DiaChi,TongTien")] DonHang donHang)
        {
            db.DonHangs.Add(donHang);
            await db.SaveChangesAsync();
            ViewBag.Message = "Mua thành công!";
            return View(donHang);
        }

        // GET: DonHangs/Edit/5
  

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
