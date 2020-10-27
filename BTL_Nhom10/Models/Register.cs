using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BTL_Nhom10.Models
{
    public class Register
    {
        [DisplayName("Địa chỉ Email"), DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "{0} không được để trống")]
        public string Email { get; set; }

        [DisplayName("Mật khẩu"), DataType(DataType.Password)]
        [Required(ErrorMessage = "{0} không được để trống")]
        [MinLength(6, ErrorMessage ="{0} phải có ít nhất {1} ký tự")]
        public string Password { get; set; }

        [DisplayName("Xác nhận MK"), DataType(DataType.Password)]
        [Required(ErrorMessage = "{0} không được để trống")]
        [MinLength(6, ErrorMessage = "{0} phải có ít nhất {1} ký tự")]
        public string RePassword { get; set; }

        [DisplayName("Số điện thoại")]
        [Required(ErrorMessage = "{0} không được để trống")]
        public decimal Phone { get; set; }
    }
}