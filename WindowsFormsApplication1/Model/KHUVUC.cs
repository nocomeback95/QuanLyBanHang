namespace WindowsFormsApplication1.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KHUVUC")]
    public partial class KHUVUC
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KHUVUC()
        {
            KHACHHANGs = new HashSet<KHACHHANG>();
        }

        [Key]
        public int MAKV { get; set; }

        [Required]
        [StringLength(50)]
        public string TenKV { get; set; }

        [StringLength(50)]
        public string GHICHU { get; set; }

        public bool IsDelete { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KHACHHANG> KHACHHANGs { get; set; }
    }
}
