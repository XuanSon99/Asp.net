namespace BTL_Nhom10.Areas.Admin.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DonHang")]
    public partial class DonHang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DonHang()
        {
            ChiTietDHs = new HashSet<ChiTietDH>();
        }

        [Key]
        [StringLength(10)]
        [Required(ErrorMessage ="Mã đơn hàng không được bỏ trống")]
        [Display(Name ="Mã đơn hàng")]
        public string MaDH { get; set; }

        [Required(ErrorMessage ="Ngày nhập không được bỏ trống")]
        [Display(Name ="Ngày đặt")]
        public DateTime NgayDat { get; set; }

        [Required(ErrorMessage ="Người đặt không được bỏ trống")]
        [StringLength(50)]
        [Display(Name ="Người đặt")]        
        public string NguoiDat { get; set; }

        [Required(ErrorMessage ="Địa chỉ không được bỏ trống")]
        [StringLength(50)]
        [Display(Name ="Địa chỉ")]
        public string DiaChi { get; set; }

        [Required(ErrorMessage ="Hình thức thanh toán không được bỏ trống")]
        [StringLength(50)]
        [Display(Name ="Hình thức thanh toán")]
        public string HinhThucTT { get; set; }


        [Required(ErrorMessage ="Tổng tiền không được bỏ trống")]
        [Display(Name ="Tổng tiền")]
        public int TongTien { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietDH> ChiTietDHs { get; set; }
    }
}
