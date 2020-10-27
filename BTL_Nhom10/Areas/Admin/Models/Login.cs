using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace BTL_Nhom10.Areas.Admin.Models
{
    public class Login
    {
        [DisplayName ("Tài khoản")]
        public string username { get; set; }

        [DisplayName("Mật khẩu")]
        public string password { get; set; }
    }
}