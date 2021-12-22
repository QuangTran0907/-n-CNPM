namespace QLKSThangLong.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NHANVIEN")]
    public partial class NHANVIEN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NHANVIEN()
        {
            PHIEUTHUEPHONG = new HashSet<PHIEUTHUEPHONG>();
        }

        [Key]
        [StringLength(5)]
        public string MaNV { get; set; }

        [StringLength(35)]
        public string TenNV { get; set; }

        [StringLength(4)]
        public string GioiTinh { get; set; }

        [StringLength(10)]
        public string BoPhanLamViec { get; set; }

        [StringLength(10)]
        public string SDT { get; set; }

        [StringLength(80)]
        public string DiaChi { get; set; }

        public bool? TrangThai { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUTHUEPHONG> PHIEUTHUEPHONG { get; set; }
    }
}
