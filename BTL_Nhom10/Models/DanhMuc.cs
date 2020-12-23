namespace BTL_Nhom10.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DanhMuc")]
    public partial class DanhMuc
    {
        [Key]
        [StringLength(10)]
        public string MaDM { get; set; }

        [StringLength(50)]
        public string TenDM { get; set; }
    }
}
