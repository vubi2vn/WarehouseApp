using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL_WareHouse;
namespace DemoWinNC.UserControls
{
    public partial class ucPhieuDatHang : UserControl
    {
        DAL_Load l = new DAL_Load();
        PhieuDat_DAL phieuDAL = new PhieuDat_DAL();
        public ucPhieuDatHang()
        {
            InitializeComponent();
        }

        private void ucPhieuDatHang_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = l.LoadPDH();

            cboNCC.DataSource = l.LoadNCC();
            cboNCC.DisplayMember = "TENNCC";
            cboNCC.ValueMember = "MANCC";

            cboMANV.DataSource = l.LoadNV();
            cboMANV.DisplayMember = "MANV";
            cboMANV.ValueMember = "MANV";

            //realTimeSource1.DataSource = l.LoadPDH();
        }

        private void btnTaoPhieuDat_Click(object sender, EventArgs e)
        {
            try
            {
                phieuDAL.insertItem(cboNCC.SelectedValue.ToString(), cboMANV.SelectedValue.ToString());
                gridControl1.DataSource = l.LoadPDH();
            }
            catch { }
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {

            int index = gridView1.FocusedRowHandle;
            string manv = gridView1.GetRowCellValue(index, "MANV").ToString();
            string maph = gridView1.GetRowCellValue(index, "MAPHIEUDAT").ToString();
            string mancc = gridView1.GetRowCellValue(index, "MANCC").ToString();

            txtMaPD.Text = maph;
            cboMANV.SelectedValue = manv;
            cboNCC.SelectedValue = mancc;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                phieuDAL.deleteItem(txtMaPD.Text);
                gridControl1.DataSource = l.LoadPDH();
            }
            catch { }
          
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                phieuDAL.updateItem(txtMaPD.Text, cboNCC.SelectedValue.ToString(), cboMANV.SelectedValue.ToString());
                gridControl1.DataSource = l.LoadPDH();
            }
            catch { }
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            int index = gridView1.FocusedRowHandle;
            string mapd = gridView1.GetRowCellValue(index, "MAPHIEUDAT").ToString();
            Properties.Settings.Default.MaPhieuDat = mapd;
            frmChiTietNhap frm = new frmChiTietNhap();
            frm.ShowDialog();
        }
    }
}
