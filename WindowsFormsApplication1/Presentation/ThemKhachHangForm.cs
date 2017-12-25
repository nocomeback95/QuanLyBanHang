using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.DAL;
using WindowsFormsApplication1.Model;

namespace WindowsFormsApplication1.Presentation
{
    public partial class ThemKhachHangForm : Form
    {
        KhachHangDAL customerDAL = new KhachHangDAL();
        int _key { get; set; }

        bool flag;          // handle add or update
        public ThemKhachHangForm()
        {
            InitializeComponent();
            flag = true;
        }
       
        public ThemKhachHangForm(int key)
        {
            InitializeComponent();
            _key = key;
            KHACHHANG khachHang = GetKhachHangByID(_key);
            txtMAKH.Text = khachHang.MAKH.ToString();
            txtTenKH.Text = khachHang.TenKH;
            txtDiaChi.Text = khachHang.DIACHI;
            txtSDT.Text = khachHang.SDT;
            txtSTK.Text = khachHang.STK;
            txtNganHang.Text = khachHang.NGANHANG;
            txtGhiChu.Text = khachHang.GHICHU;
            cbbMAKV.Text = khachHang.KHUVUC.ToString();
            if (khachHang.GIOITINH)
            {
                radBtnNam.Checked = true;
            }
            else
            {
                radBtnNu.Checked = true;
            }
            this.Text = "Cập Nhật Thông Tin Khách Hàng";
            flag = false;
        }

        public KHACHHANG GetKhachHangByID(int ID)
        {
           var currentCustomer = customerDAL.GetAll().Where(c => c.MAKH == ID).FirstOrDefault();
            return currentCustomer;
        }
        private void btnSaveKhachHang_Click(object sender, EventArgs e)
        {
            //var currentCustomer = GetKhachHang();
            if (ValidationData())
            {
                if (flag)
                {
                    customerDAL.Add(GetKhachHangToAdd());
                    this.Hide();
                }
                else
                {
                    customerDAL.Update(GetKhachHangToUpdate());
                    this.Hide();
                }
                
            }
        }
        public KHACHHANG GetKhachHangToUpdate()
        {
            var updatedKhachHang = GetKhachHangByID(_key);
            updatedKhachHang.TenKH = txtTenKH.Text;
            updatedKhachHang.MAKV = Convert.ToInt32(cbbMAKV.Text);
            updatedKhachHang.SDT = txtSDT.Text;
            updatedKhachHang.STK = txtSTK.Text;
            updatedKhachHang.NGANHANG = txtNganHang.Text;
            updatedKhachHang.GHICHU = txtGhiChu.Text;

            if (radBtnNam.Checked)
            {
                updatedKhachHang.GIOITINH = true;
            }
            else
            {
                updatedKhachHang.GIOITINH = false;
            }

            return updatedKhachHang;
        }

        public KHACHHANG GetKhachHangToAdd()
        {
            KHACHHANG khachHang = new KHACHHANG
            {
                TenKH = txtTenKH.Text,
                DIACHI = txtDiaChi.Text,
                MAKV = Convert.ToInt32(cbbMAKV.Text),
                SDT = txtSDT.Text,
                STK = txtSTK.Text,
                NGANHANG = txtNganHang.Text,
                GIOITINH = true,
                GHICHU = txtGhiChu.Text,
            };

            if (radBtnNu.Checked)
            {
                khachHang.GIOITINH = false;
            }

            return khachHang;
        }

        protected bool ValidationData()
        {
            if (String.IsNullOrEmpty(txtTenKH.Text) || String.IsNullOrEmpty(txtSDT.Text) || String.IsNullOrEmpty(cbbMAKV.Text))
            {
                lblValidate.Visible = true;
                return false;
            }

            return true;
        }
        private void ThemKhachHangForm_Load(object sender, EventArgs e)
        {
            BindingDropDownList();
        }

        protected void BindingDropDownList()
        {
            BaseDAL<KHUVUC> abc = new BaseDAL<KHUVUC>();
            var listMaKV = abc.GetAll().Select(c => c.MAKV).ToList();
            cbbMAKV.DataSource = listMaKV;
        }

        private void btnCancelKhachHang_Click(object sender, EventArgs e)
        { 
            this.Close();
        }
    }
}
