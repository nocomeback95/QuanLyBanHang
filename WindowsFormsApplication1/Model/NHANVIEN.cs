namespace WindowsFormsApplication1.Model
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
            HOADONs = new HashSet<HOADON>();
            TONKHOes = new HashSet<TONKHO>();
        }

        [Key]
        public int MANV { get; set; }

        [Required]
        [StringLength(50)]
        public string TenNV { get; set; }

        [Required]
        [StringLength(50)]
        public string UserName { get; set; }

        public int MaBP { get; set; }

        [Required]
        [StringLength(50)]
        public string SDT { get; set; }

        [StringLength(50)]
        public string DIACHI { get; set; }

        public bool GIOITINH { get; set; }

        [StringLength(50)]
        public string GHICHU { get; set; }

        public bool IsDelete { get; set; }

        public virtual ACCOUNT ACCOUNT { get; set; }

        public virtual BOPHAN BOPHAN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOADON> HOADONs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TONKHO> TONKHOes { get; set; }
    }
}
