namespace BTL_Nhom10.Models
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
        public string TaiKhoan1 { get; set; }

        [Required]
        [StringLength(20)]
        public string MatKhau { get; set; }

        [Required]
        [StringLength(50)]
        public string Email { get; set; }

        public bool Level { get; set; }
    }
}
