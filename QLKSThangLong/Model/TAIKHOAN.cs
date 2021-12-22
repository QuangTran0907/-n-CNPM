namespace QLKSThangLong.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TAIKHOAN")]
    public partial class TAIKHOAN
    {
        [Key]
        [StringLength(5)]
        public string MaTK { get; set; }

        [StringLength(20)]
        public string TenTK { get; set; }

        [StringLength(20)]
        public string MatKhau { get; set; }

        public byte? Quyen { get; set; }
    }
}
