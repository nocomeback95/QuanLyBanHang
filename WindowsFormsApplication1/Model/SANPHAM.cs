namespace WindowsFormsApplication1.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SANPHAM")]
    public partial class SANPHAM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SANPHAM()
        {
            CHITIET_HOADON = new HashSet<CHITIET_HOADON>();
            CHITIET_TONKHO = new HashSet<CHITIET_TONKHO>();
        }

        [Key]
        public int MASP { get; set; }

        [Required]
        [StringLength(50)]
        public string TenSP { get; set; }

        public int MaNCC { get; set; }

        public int MaDVT { get; set; }

        public int MANSP { get; set; }

        [Column(TypeName = "money")]
        public decimal GIABANSI { get; set; }

        [Column(TypeName = "money")]
        public decimal GIABANLE { get; set; }

        [StringLength(50)]
        public string GHICHU { get; set; }

        public bool IsDelete { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIET_HOADON> CHITIET_HOADON { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIET_TONKHO> CHITIET_TONKHO { get; set; }

        public virtual DONVITINH DONVITINH { get; set; }

        public virtual KHOHANG KHOHANG { get; set; }

        public virtual NHACUNGCAP NHACUNGCAP { get; set; }

        public virtual NHOMSANPHAM NHOMSANPHAM { get; set; }
    }
}
