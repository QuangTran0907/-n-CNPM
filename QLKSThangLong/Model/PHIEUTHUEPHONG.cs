namespace QLKSThangLong.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PHIEUTHUEPHONG")]
    public partial class PHIEUTHUEPHONG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PHIEUTHUEPHONG()
        {
            CHITIETPHIEUTHUE = new HashSet<CHITIETPHIEUTHUE>();
        }

        [Key]
        [StringLength(5)]
        public string MaPhieuThue { get; set; }

        public DateTime? NgayThuePhong { get; set; }

        [StringLength(5)]
        public string MaKH { get; set; }

        [StringLength(5)]
        public string MaNV { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETPHIEUTHUE> CHITIETPHIEUTHUE { get; set; }

        public virtual KHACHHANG KHACHHANG { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }
    }
}
