using BTL_Nhom10.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BTL_Nhom10.Controllers
{
    public class RegisterController : Controller
    {

        // GET: Register/Details/5
        public ActionResult Details(Register mem)
        {
            return View(mem);
        }

        // GET: Register/Create
        public ActionResult Index()
        {
            return View();
        }

        // POST: Register/Create
        [HttpPost]
        public ActionResult Index(Register mem)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Details", mem);
            }
            catch
            {
                return View();
            }
        }

        // GET: Register/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Register/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Register/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Register/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
