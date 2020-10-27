using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BTL_Nhom10.Models
{
    public class Login
    {
        [DisplayName ("Tài khoản")]
        [Required(ErrorMessage = "{0} không được để tróng")]
        public string Username { get; set; }

        [DisplayName("Mật khẩu"), DataType(DataType.Password)]
        [Required(ErrorMessage = "{0} không được để tróng")]
        public string Password { get; set; }
    }
}