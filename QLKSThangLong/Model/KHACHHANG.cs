namespace QLKSThangLong.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KHACHHANG")]
    public partial class KHACHHANG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KHACHHANG()
        {
            PHIEUTHUEPHONG = new HashSet<PHIEUTHUEPHONG>();
        }

        [Key]
        [StringLength(5)]
        public string MaKH { get; set; }

        [StringLength(35)]
        public string TenKH { get; set; }

        [Column("CMND/CCCD")]
        [StringLength(12)]
        public string CMND_CCCD { get; set; }

        [StringLength(10)]
        public string SDT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUTHUEPHONG> PHIEUTHUEPHONG { get; set; }
    }
}
