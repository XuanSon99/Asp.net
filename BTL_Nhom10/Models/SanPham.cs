namespace BTL_Nhom10.Models
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
        public string MaSP { get; set; }

        [Required]
        [StringLength(50)]
        public string TenSP { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string AnhSP { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string ThongSo { get; set; }

        [Required]
        [StringLength(50)]
        public string TrangThai { get; set; }

        [DisplayFormat(DataFormatString = "{0:#,###}")]
        public int DonGia { get; set; }

        [Required]
        [StringLength(10)]
        public string MaDM { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietDH> ChiTietDHs { get; set; }

        public virtual DanhMuc DanhMuc { get; set; }
    }
}
