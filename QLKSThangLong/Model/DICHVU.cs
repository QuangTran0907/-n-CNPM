namespace QLKSThangLong.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DICHVU")]
    public partial class DICHVU
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DICHVU()
        {
            PHIEUDANGKIDVs = new HashSet<PHIEUDANGKIDV>();
        }

        [Key]
        [StringLength(5)]
        public string MaDV { get; set; }

        [StringLength(15)]
        public string TenDV { get; set; }

        [Column(TypeName = "money")]
        public decimal? GiaDV { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUDANGKIDV> PHIEUDANGKIDVs { get; set; }
    }
}
