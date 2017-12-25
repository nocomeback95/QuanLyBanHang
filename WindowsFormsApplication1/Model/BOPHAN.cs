namespace WindowsFormsApplication1.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BOPHAN")]
    public partial class BOPHAN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BOPHAN()
        {
            NHANVIENs = new HashSet<NHANVIEN>();
        }

        [Key]
        public int MABP { get; set; }

        [Required]
        [StringLength(50)]
        public string TenBP { get; set; }

        [StringLength(50)]
        public string GHICHU { get; set; }

        public bool IsDelete { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NHANVIEN> NHANVIENs { get; set; }
    }
}
