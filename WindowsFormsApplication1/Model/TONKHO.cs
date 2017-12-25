namespace WindowsFormsApplication1.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TONKHO")]
    public partial class TONKHO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TONKHO()
        {
            CHITIET_TONKHO = new HashSet<CHITIET_TONKHO>();
        }

        [Key]
        public int MABCTK { get; set; }

        [Column(TypeName = "date")]
        public DateTime NGAYBCTK { get; set; }

        public int MaNV { get; set; }

        [StringLength(50)]
        public string GHICHU { get; set; }

        public bool IsDelete { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIET_TONKHO> CHITIET_TONKHO { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }
    }
}
