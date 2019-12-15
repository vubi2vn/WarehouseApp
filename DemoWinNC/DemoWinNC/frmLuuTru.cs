using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoWinNC
{
    public partial class frmLuuTru : Form
    {
        public frmLuuTru()
        {
            InitializeComponent();
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            MessageBox.Show("a");
        }

        private void frmLuuTru_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetQLK.KE_HANG' table. You can move, or remove it, as needed.
            this.kE_HANGTableAdapter.Fill(this.dataSetQLK.KE_HANG);
            //Them mã tự động

            //private string sinhtudong()
            //{
            //    List<BAN> a = new List<BAN>(bandal.LoadDS());

            //    for (int i = 0; i <= a.Count + 100; i++)
            //    {
            //        if (bandal.kttrungkhoa(i.ToString()) == null)
            //            return i.ToString();

            //    }
            //    return null;
            //}

            //public BAN kttrungkhoa(string p)
            //{
            //    return qlbd.BANs.Where(t => t.MaBan == p).FirstOrDefault();
            //}

            //binding gridcontrol
            //int index = gridView1.FocusedRowHandle;
            //string manv = gridView1.GetRowCellValue(index, "MANV").ToString();
            //string maph = gridView1.GetRowCellValue(index, "MAPHIEUDAT").ToString();
            //string mancc = gridView1.GetRowCellValue(index, "MANCC").ToString();
        }
    }
}
