namespace BTL_Nhom10.Areas.Admin.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TaiKhoan")]
    public partial class TaiKhoan
    {
        [Key]
        [Column("TaiKhoan")]
        [StringLength(20)]
        [Required(ErrorMessage ="Tên tài khoản không được để trống!")]
        [Display(Name ="Tên tài khoản")]
        public string TaiKhoan1 { get; set; }

        [Required(ErrorMessage ="Mật khẩu không được để trống!")]
        [Display(Name ="Mật khẩu")]
        [StringLength(20)]
        public string MatKhau { get; set; }

        [Required(ErrorMessage = "Email không được để trống!")]
        [Display(Name = "Email")]
        [StringLength(50)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Level không được để trống!")]
        [Display(Name ="Admin")]
        public Boolean Level { get; set; }
    }
}
