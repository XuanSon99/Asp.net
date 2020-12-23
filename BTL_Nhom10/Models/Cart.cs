using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using System.Globalization;

namespace BTL_Nhom10.Models
{
    public class CartItem
    {
        public SanPham shopping_product { get; set; }
        public int shopping_quantity { get; set; }
    }
    public class Cart
    {
        List<CartItem> items = new List<CartItem>();
        public IEnumerable<CartItem> Items
        {
            get { return items; }
        }
        public void Add(SanPham _pro, int _quantity = 1)
        {
            var item = items.FirstOrDefault(s => s.shopping_product.MaSP == _pro.MaSP);
            if (item == null)
            {
                items.Add(new CartItem
                {
                    shopping_product = _pro,
                    shopping_quantity = _quantity
                });
            }
            else
            {
                item.shopping_quantity += _quantity;

            }
        }
        public void Update(string id, int quantity)
        {
            var item = items.Find(s => s.shopping_product.MaSP == id);
            if (item != null)
            {
                item.shopping_quantity = quantity;
            }
        }
        public string Total_Money()
        {
            CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
            string total = items.Sum(s => s.shopping_product.DonGia * s.shopping_quantity).ToString("#,###", cul.NumberFormat);
            return total;
        }
        public int total_quantity()
        {
            var total = items.Sum(s => s.shopping_quantity);
            return total;

        }
        public void delete_product_cart(string id)
        {
            items.RemoveAll(s => s.shopping_product.MaSP.Trim() == id);
        }
    }
}