namespace WindowsFormsApplication1.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KHOHANG")]
    public partial class KHOHANG
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MASP { get; set; }

        [Column(TypeName = "date")]
        public DateTime NGAYNHAP { get; set; }

        public double THUE { get; set; }

        public int SOLUONG { get; set; }

        [StringLength(50)]
        public string GHICHU { get; set; }

        public bool IsDelete { get; set; }

        public virtual SANPHAM SANPHAM { get; set; }
    }
}
