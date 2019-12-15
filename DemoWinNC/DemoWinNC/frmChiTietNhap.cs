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
using DAL_WareHouse;
namespace DemoWinNC
{
    public partial class frmChiTietNhap : DevExpress.XtraEditors.XtraForm
    {
        ChiTietPhieuNhap_DAL dal = new ChiTietPhieuNhap_DAL();
        DAL_Load load = new DAL_Load();
        string mapd = Properties.Settings.Default.MaPhieuDat;
        public frmChiTietNhap()
        {
            InitializeComponent();
        }

        private void frmChiTietNhap_Load(object sender, EventArgs e)
        {
            cboMAMH.DataSource = load.LoadHH();
            cboMAMH.DisplayMember = "MAMATHANG";
            cboMAMH.ValueMember = "MAMATHANG";
            loaddl();
        }

        public void loaddl()
        {
           gridControl1.DataSource = dal.LoadTheoMAPD(mapd);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                dal.insertAutoItem( mapd, cboMAMH.SelectedValue.ToString(), Convert.ToInt32(txtSoluong.Text.ToString()));
                loaddl();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            dal.deleteItem(txtMaCTPD.Text);
            loaddl();
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            int index = gridView1.FocusedRowHandle;
            string mactpd = gridView1.GetRowCellValue(index, "MA_CTPD").ToString();
            string maph = gridView1.GetRowCellValue(index, "MAMATHANG").ToString();
            string soluong = gridView1.GetRowCellValue(index, "SOLUONG").ToString();

            txtMaCTPD.Text = mactpd;
            cboMAMH.SelectedValue = maph;
            txtSoluong.Text = soluong;
        }
    }
}