using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.DAL;

namespace WindowsFormsApplication1.Presentation
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (CanLogin())
            {
                MainForm mainForm = new MainForm();
                this.Hide();
                mainForm.Show();
            }
        }

        protected bool CanLogin()
        {
            var accountDAL = new AccountDAL();
            if (txtUserName.Text == string.Empty || txtPassWord.Text == string.Empty)
            {
                MessageBox.Show("UserName or PassWord is invalid");
                return false;
            }

            var isLogin = accountDAL.IsGetAccountByUserNameAndPassWord(txtUserName.Text, txtPassWord.Text);

            if (!isLogin)
            {
                MessageBox.Show("UserName or PassWord is wrong");
                return false;
            }
            else
            {
                return true;
            }
        }

        protected void RememberAccoutn()
        {
            if (ckbRemember.Checked)
            {
                Properties.Settings.Default.UserName = txtUserName.Text;
                Properties.Settings.Default.PassWord = txtPassWord.Text;
                Properties.Settings.Default.Save();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.UserName != string.Empty)
            {
                txtUserName.Text = Properties.Settings.Default.UserName;
                txtPassWord.Text = Properties.Settings.Default.PassWord;
            }
        }
    }
}
