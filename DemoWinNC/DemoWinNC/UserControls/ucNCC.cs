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
    public partial class ucNCC : UserControl
    {
        DAL_Load dal = new DAL_Load();
        public ucNCC()
        {
            InitializeComponent();
        }

        private void ucNCC_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = dal.LoadNCC();
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            //mh.update(dataGridView1.SelectedCells[0].Value.ToString(), txtTenMH.Text);
            //dataGridView1.DataSource = mh.LoadDL();
            MessageBox.Show("2");
        }

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            MessageBox.Show("1");
            
        }
    }
}
