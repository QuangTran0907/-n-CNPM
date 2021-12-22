namespace QLKSThangLong.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HOADON")]
    public partial class HOADON
    {
        [Key]
        [StringLength(5)]
        public string MaHD { get; set; }

        [Column(TypeName = "money")]
        public decimal? DichVuSuDung { get; set; }

        [Column(TypeName = "money")]
        public decimal? TienPhong { get; set; }

        [Column(TypeName = "money")]
        public decimal? TongTien { get; set; }

        [Required]
        [StringLength(5)]
        public string SoPhong { get; set; }

        public virtual PHONG PHONG { get; set; }
    }
}
