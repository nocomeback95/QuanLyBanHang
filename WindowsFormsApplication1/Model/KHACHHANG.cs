namespace WindowsFormsApplication1.Model
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
            HOADONs = new HashSet<HOADON>();
        }

        [Key]
        public int MAKH { get; set; }

        [Required]
        [StringLength(50)]
        public string TenKH { get; set; }

        [Required]
        [StringLength(50)]
        public string SDT { get; set; }

        [StringLength(50)]
        public string STK { get; set; }

        [StringLength(50)]
        public string NGANHANG { get; set; }

        public int MAKV { get; set; }

        [StringLength(50)]
        public string DIACHI { get; set; }

        public bool GIOITINH { get; set; }

        [StringLength(50)]
        public string GHICHU { get; set; }

        public bool IsDelete { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOADON> HOADONs { get; set; }

        public virtual KHUVUC KHUVUC { get; set; }
    }
}
