using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BTL_Nhom10.Models;
namespace BTL_Nhom10.Controllers
{
    public class CartController : Controller
    {
        private Cima_DB db = new Cima_DB();
        public Cart GetCart()
        {
            Cart cart = Session["Cart"] as Cart;
            if(cart == null || Session["Cart"] == null)
            {
                cart = new Cart();
                Session["Cart"] = cart;
            }
            return cart;
        }
        // GET: Cart
        // them item vao gio hang
        public ActionResult AddToCart(string id)
        {
            var pro = db.SanPhams.SingleOrDefault(s => s.MaSP == id);
            if(pro != null)
            {
                GetCart().Add(pro);
            }
            return RedirectToAction("Index", "Cart");
        }

        //trang gio hang
        public ActionResult Index()
        {
            if(Session["Cart"] == null)
            {
                return RedirectToAction("Index", "Cart");
            }
            Cart cart = Session["Cart"] as Cart;
            return View(cart);
        }
        public ActionResult UpdateCart(FormCollection form)
        {
            Cart cart = Session["Cart"] as Cart;
            string id = form["ID_SP"];
            int quantity = Int32.Parse(form["quantity"]);
            cart.Update(id, quantity);
            return RedirectToAction("Index", "Cart");
        }
        public ActionResult Remove_Cart(string id)
        {
            
            Cart cart = Session["Cart"] as Cart;
            cart.delete_product_cart(id);
            return RedirectToAction("Index", "Cart");
        }
        public int amount()
        {
            if (Session["Cart"] == null)
            {
                return 0;
            }
            Cart cart = Session["Cart"] as Cart;
            
            return cart.total_quantity(); ;
        }

        public ActionResult Logout()
        {
            return RedirectToAction("Login", "Home");
        }
    }
}