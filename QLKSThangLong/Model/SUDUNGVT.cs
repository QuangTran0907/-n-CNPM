namespace QLKSThangLong.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SUDUNGVT")]
    public partial class SUDUNGVT
    {
        public DateTime? NgaySuDung { get; set; }

        public short? SoLuongVT { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(5)]
        public string SoPhong { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(5)]
        public string MaVT { get; set; }

        public virtual PHONG PHONG { get; set; }

        public virtual VATTU VATTU { get; set; }
    }
}
