namespace BTL_Nhom10.Areas.Admin.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SanPham")]
    public partial class SanPham
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SanPham()
        {
            ChiTietDHs = new HashSet<ChiTietDH>();
        }

        [Key]
        [StringLength(10)]
        [Required(ErrorMessage = "Mã sản phẩm không được để trống!")]
        [Display(Name = "Mã SP")]
        public string MaSP { get; set; }

        [Required(ErrorMessage = "Tên sản phẩm không được để trống!")]
        [StringLength(50)]
        [Display(Name = "Tên SP")]
        public string TenSP { get; set; }

        [StringLength(50)]
        [Display(Name = "Ảnh")]
        public string AnhSP { get; set; }

        [Required(ErrorMessage = "Thông số không được để trống!")]
        [StringLength(50)]
        [Display(Name = "Thông số")]
        public string ThongSo { get; set; }

        [Required(ErrorMessage = "Trạng thái không được để trống!")]
        [StringLength(50)]
        [Display(Name = "Trạng thái")]
        public string TrangThai { get; set; }

        [Required(ErrorMessage = "Đơn giá không được để trống!")]
        [Display(Name = "Đơn giá")]
        [DisplayFormat(DataFormatString = "{0:#,###}")]
        public int DonGia { get; set; }

        [Display(Name = "Danh mục")]
        [StringLength(10)]
        public string MaDM { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietDH> ChiTietDHs { get; set; }

        public virtual DanhMuc DanhMuc { get; set; }
    }
}
