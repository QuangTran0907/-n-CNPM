namespace QLKSThangLong.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PHONG")]
    public partial class PHONG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PHONG()
        {
            CHITIETPHIEUTHUE = new HashSet<CHITIETPHIEUTHUE>();
            HOADON = new HashSet<HOADON>();
            PHIEUDANGKIDV = new HashSet<PHIEUDANGKIDV>();
            SUDUNGVT = new HashSet<SUDUNGVT>();
        }

        [Key]
        [StringLength(5)]
        public string SoPhong { get; set; }

        [StringLength(10)]
        public string LoaiPhong { get; set; }

        [StringLength(30)]
        public string ThongTinPhong { get; set; }

        public byte? SoNguoiToiDa { get; set; }

        [Column(TypeName = "money")]
        public decimal? GiaPhong { get; set; }

        [Column(TypeName = "money")]
        public decimal? TienDV { get; set; }

        public bool? TrangThai { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETPHIEUTHUE> CHITIETPHIEUTHUE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOADON> HOADON { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUDANGKIDV> PHIEUDANGKIDV { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SUDUNGVT> SUDUNGVT { get; set; }
    }
}
