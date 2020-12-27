namespace BTL_Nhom10.Models
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
        public int? MaDH { get; set; }
       

        [Required(ErrorMessage = "Họ và tên không được bỏ trống")]
        [StringLength(50)]
        [Display(Name = "Họ và tên")]
        public string NguoiDat { get; set; }

        [Required(ErrorMessage = "Email không được bỏ trống")]
        [StringLength(50)]
        [Display(Name = "Email")]
        public string Email { get; set; }
        
        [StringLength(20)]
        [Display(Name = "Số điện thoại")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Địa chỉ không được bỏ trống")]
        [StringLength(50)]
        [Display(Name = "Địa chỉ")]
        public string DiaChi { get; set; }
        [Display(Name ="Tổng tiền")]
        public float? TongTien { get; set; }
        [Display(Name = "Ngày đặt")]
        public DateTime? NgayDat { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietDH> ChiTietDHs { get; set; }
    }
}
