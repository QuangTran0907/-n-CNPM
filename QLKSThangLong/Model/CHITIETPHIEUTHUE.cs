namespace QLKSThangLong.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CHITIETPHIEUTHUE")]
    public partial class CHITIETPHIEUTHUE
    {
        public DateTime? NgayTraDuKien { get; set; }

        public DateTime? NgayTraThatSu { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(5)]
        public string MaPhieuThue { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(5)]
        public string SoPhong { get; set; }

        public virtual PHIEUTHUEPHONG PHIEUTHUEPHONG { get; set; }

        public virtual PHONG PHONG { get; set; }
    }
}
