using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Presentation
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnKhachHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelKhachHang.Controls.Clear();
            UCKhachHang ucKhachHang = new UCKhachHang();
            ucKhachHang.Dock = DockStyle.Fill;
            panelKhachHang.Controls.Add(ucKhachHang);
        }
    }
}
