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
using DevExpress.XtraNavBar;
namespace DemoWinNC
{
    public partial class FrmMain : DevExpress.XtraEditors.XtraForm
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("hh:mm:ss | dd/MM/yyyy");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn chắc chắn muốn thoát chứ ?", "Hệ thống", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void addUCtoPanelMain(Control c)
        {
            PanelMain.Controls.Clear();
            c.Dock = System.Windows.Forms.DockStyle.Fill;
            PanelMain.Controls.Add(c);
        }
        public DataTable GetNhomNguoiDung(string str)
        {
            DataTable dt = dataSetQLK.NGUOIDUNG_NHOMNGUOIDUNG;
            DataTable dtR = dt.Clone();
            foreach (DataRow dr in dt.Rows)
            {
                if (dr[0].ToString().Trim() == str.Trim())
                {
                    dtR.ImportRow(dr);
                }
            }
            return dtR;
        }
        public DataTable GetMaManHinh(string str)
        {
            DataTable dt = dataSetQLK.QL_PHANQUYEN;
            DataTable dtR = dt.Clone();
            foreach (DataRow dr in dt.Rows)
            {
                if (dr[0].ToString().Trim() == str)
                {
                    dtR.ImportRow(dr);
                }
            }
            return dtR;
        }

            private void FrmMain_Load(object sender, EventArgs e)
            {
            // TODO: This line of code loads data into the 'dataSetQLK.TAIKHOAN' table. You can move, or remove it, as needed.
            this.tAIKHOANTableAdapter.Fill(this.dataSetQLK.TAIKHOAN);
            // TODO: This line of code loads data into the 'dataSetQLK.QL_PHANQUYEN' table. You can move, or remove it, as needed.
            this.qL_PHANQUYENTableAdapter.Fill(this.dataSetQLK.QL_PHANQUYEN);
            // TODO: This line of code loads data into the 'dataSetQLK.DM_MANHINH' table. You can move, or remove it, as needed.
            this.dM_MANHINHTableAdapter.Fill(this.dataSetQLK.DM_MANHINH);
            // TODO: This line of code loads data into the 'dataSetQLK.NGUOIDUNG_NHOMNGUOIDUNG' table. You can move, or remove it, as needed.
            this.nGUOIDUNG_NHOMNGUOIDUNGTableAdapter.Fill(this.dataSetQLK.NGUOIDUNG_NHOMNGUOIDUNG);
            // TODO: This line of code loads data into the 'dataSetQLK.QL_NHOMNGUOIDUNG' table. You can move, or remove it, as needed.
            this.qL_NHOMNGUOIDUNGTableAdapter.Fill(this.dataSetQLK.QL_NHOMNGUOIDUNG);
         
            UserControls.ucNhanVien uc = new UserControls.ucNhanVien();
            addUCtoPanelMain(uc);

            string str = Properties.Settings.Default.taikhoandn.ToString().Trim();
            DataTable dt = GetNhomNguoiDung(str);

            foreach (DataRow item in dt.Rows)
            {
                DataTable dsQuyen = GetMaManHinh(item[1].ToString().Trim());
                foreach (DataRow mh in dsQuyen.Rows)
                {
                    FindMenuPhanQuyen(navBarControl1.Groups, mh[1].ToString(), Convert.ToBoolean(mh[2].ToString()));
                }
            }
        }
        private void FindMenuPhanQuyen(NavGroupCollection mnuItems, string pScreenName, bool pEnable)
        {
            foreach (NavBarGroup menu in mnuItems)
            {
                if (string.Equals(pScreenName.Trim(), menu.Tag))
                {
                    menu.Visible = pEnable;
                }
            }
        }
        //visiable controls
        private bool VisiableNavbarGroup(NavBarViewCollection Items)
        {
            foreach (NavBarGroup item in Items)
            {
                return true;             
            }
            return false;
        }
     
        //hottracked: hover mouse
        //pressed: press, click
        private void navBarItem1_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            UserControls.ucNhanVien uc = new UserControls.ucNhanVien();
            addUCtoPanelMain(uc);
        }

  
        private void navBarItem5_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            UserControls.ucThemNguoiDungVaoNhom uc = new UserControls.ucThemNguoiDungVaoNhom();
            addUCtoPanelMain(uc);
        }

        private void navBarItem7_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            UserControls.ucPhanQuyen uc = new UserControls.ucPhanQuyen();
            addUCtoPanelMain(uc);
        }

        private void navBarItem3_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            UserControls.ucPhieuDatHang uc = new UserControls.ucPhieuDatHang();
            addUCtoPanelMain(uc);
        }

        private void navBarItem8_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            UserControls.ucQLTaiKhoan uc = new UserControls.ucQLTaiKhoan();
            addUCtoPanelMain(uc);
        }

        private void navBarItem2_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            UserControls.ucKhuVuc uc = new UserControls.ucKhuVuc();
            addUCtoPanelMain(uc);
        }

        private void navBarItem9_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            UserControls.ucNCC uc = new UserControls.ucNCC();
            addUCtoPanelMain(uc);
        }

        private void navBarItem4_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmLuuTru frm = new frmLuuTru();
            frm.Show();
        }

        private void navBarItem10_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            UserControls.ucDoiMatKhau uc = new UserControls.ucDoiMatKhau();
            addUCtoPanelMain(uc);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {        
            DialogResult dialogResult = MessageBox.Show("Đăng xuất ?", "Hệ thống", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
                Program.loginForm.Show();
            }
        }

        private void navBarItem11_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            UserControls.ucXuatHang uc = new UserControls.ucXuatHang();
            addUCtoPanelMain(uc);
        }

        private void qL_NHOMNGUOIDUNGBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.qL_NHOMNGUOIDUNGBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSetQLK);

        }
    }
}