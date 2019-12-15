using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace DemoWinNC
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        QuanLyNguoiDung cauhinh = new QuanLyNguoiDung();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtTen.Focus();
            txtMK.Properties.PasswordChar = '*';
            
        }

        private void btnDN_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTen.Text.Trim()))
            {
                MessageBox.Show("Không để trống " + label1.Text.ToLower(), "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTen.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtMK.Text.Trim()))
            {
                MessageBox.Show("Không để trống " + label2.Text.ToLower(), "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMK.Focus();
                return;
            }
               
            int kq = cauhinh.Check_Config();
            if (kq == 0)
            {
                ProcessLogin();
            }
            frmConfiguration frm = new frmConfiguration();
            if (kq == 1)
            {
                MessageBox.Show("Chuỗi cấu hình không tồn tại");
                frm.ShowDialog();
            }
            if (kq == 2)
            {
                MessageBox.Show("Chuỗi cấu hình không phù hợp");
                frm.ShowDialog();
            }
        }

        public void ProcessLogin()
        {
            LoginResult result;
            result = cauhinh.Check_User(txtTen.Text, txtMK.Text);

            if (result == LoginResult.Ivalid)
            {
                MessageBox.Show("Sai " + label1.Text + " hoặc " + label2.Text);
                return;
            }

            else if (result == LoginResult.Disabled)
            {
                MessageBox.Show("Tài khoản bị khóa");
                return;
            }
            MessageBox.Show("Đăng nhập thành công !");
            if(Program.mainForm == null)
            { 
                Program.mainForm = new FrmMain();
            }
            Properties.Settings.Default.taikhoandn = txtTen.Text;
            //txtMK.Text = "";
            //txtTen.Text = "";
            this.Visible = false;
            Program.mainForm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}