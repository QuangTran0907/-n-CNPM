namespace QLKSThangLong.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PHIEUDANGKIDV")]
    public partial class PHIEUDANGKIDV
    {
        [Key]
        [StringLength(5)]
        public string MaPhieuDV { get; set; }

        public DateTime? NgaySuDung { get; set; }

        [Column(TypeName = "money")]
        public decimal? Tongtien { get; set; }

        [StringLength(5)]
        public string SoPhong { get; set; }

        [StringLength(5)]
        public string MaDV { get; set; }

        public byte? SoLuong { get; set; }

        public virtual DICHVU DICHVU { get; set; }

        public virtual PHONG PHONG { get; set; }
    }
}
