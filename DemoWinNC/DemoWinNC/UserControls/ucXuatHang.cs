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
    public partial class ucXuatHang : UserControl
    {
        DAL_Load dal = new DAL_Load();
        Phieuxuat_DAL px = new Phieuxuat_DAL();
        public ucXuatHang()
        {
            InitializeComponent();
        }

        private void ucXuatHang_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = dal.LoadPXK();


            cboMANV.DataSource = dal.LoadNV();
            cboMANV.DisplayMember = "MANV";
            cboMANV.ValueMember = "MANV";
            //this.pHIEU_XUAT_KHOTableAdapter.Fill(this.dataSetQLK.PHIEU_XUAT_KHO);
        }

        private void btnTaoPhieuDat_Click(object sender, EventArgs e)
        {
            px.insertItem(cboMANV.SelectedValue.ToString());
            gridControl1.DataSource = dal.LoadPXK();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                px.deleteItem(mAHDTextEdit.Text);
                gridControl1.DataSource = dal.LoadPXK();
            }
            catch { }
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            int index = gridView1.FocusedRowHandle;
            string manv = gridView1.GetRowCellValue(index, "MANV").ToString();
            string maHh = gridView1.GetRowCellValue(index, "MAHD").ToString();

            mAHDTextEdit.Text = maHh;
            

            cboMANV.SelectedValue = manv;
        }

        private void s(object sender, DevExpress.XtraGrid.Views.Printing.PrintRowEventArgs e)
        {

        }
    }
}
