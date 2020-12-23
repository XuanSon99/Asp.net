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
        [Key]
        [StringLength(10)]
        public string MaDH { get; set; }

        public DateTime NgayDat { get; set; }

        [Required]
        [StringLength(50)]
        public string NguoiDat { get; set; }

        [Required]
        [StringLength(50)]
        public string DiaChi { get; set; }

        [Required]
        [StringLength(50)]
        public string HinhThucTT { get; set; }

        public int TongTien { get; set; }
    }
}
