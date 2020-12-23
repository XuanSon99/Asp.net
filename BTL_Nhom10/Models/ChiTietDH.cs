namespace BTL_Nhom10.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietDH")]
    public partial class ChiTietDH
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string MaDH { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string MaSP { get; set; }

        public int SoLuong { get; set; }
    }
}
