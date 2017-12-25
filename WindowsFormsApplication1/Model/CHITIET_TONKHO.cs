namespace WindowsFormsApplication1.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CHITIET_TONKHO
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MABCTK { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MASP { get; set; }

        public int SOLUONG { get; set; }

        [StringLength(50)]
        public string GHICHU { get; set; }

        public bool IsDelete { get; set; }

        public virtual SANPHAM SANPHAM { get; set; }

        public virtual TONKHO TONKHO { get; set; }
    }
}
