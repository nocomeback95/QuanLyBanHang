using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.DAL;
using FastMember;

namespace WindowsFormsApplication1.Presentation
{
    public partial class UCKhachHang : UserControl
    {
        KhachHangDAL customerDAL = new KhachHangDAL();
        int MAKH { get; set; }
        public UCKhachHang()
        {
            InitializeComponent();

        }
        private void UCKhachHang_Load(object sender, EventArgs e)
        {
            LoadCustomer();          
        }

        public void LoadCustomer()
        {
            var listCustomer = customerDAL.GetAll();
            DataTable table = new DataTable();

            //convert form list to datatable 
            using (var reader = ObjectReader.Create(listCustomer))
            {
                table.Load(reader);
            }

            gridControlKhachHang.DataSource = table;
        }

        private void btnThemKhachHang_Click(object sender, EventArgs e)
        {
            ThemKhachHangForm themKhachHangForm = new ThemKhachHangForm();
            themKhachHangForm.Show();
        }

        private void btnXoaKhachHang_Click(object sender, EventArgs e)
        {
            var currentCustomer = customerDAL.GetAll().Where(c => c.MAKH == MAKH).FirstOrDefault();
            customerDAL.Delete(currentCustomer);
            LoadCustomer();
        }

        private void gridControlKhachHang_Click(object sender, EventArgs e)
        {
           MAKH = Convert.ToInt32(gridViewKhachHang.GetFocusedRowCellValue(gridColumn1));
            this.btnSuaKhachHang.Enabled = true;
            this.btnXoaKhachHang.Enabled = true; 
        }

        private void btnSuaKhachHang_Click(object sender, EventArgs e)
        {
            ThemKhachHangForm themKhachHangForm = new ThemKhachHangForm(MAKH);
            themKhachHangForm.Show();
        }
    }
}
