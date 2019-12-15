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
    public partial class ucNhanVien : UserControl
    {
        DAL_Load l = new DAL_Load();
        public ucNhanVien()
        {
            InitializeComponent();
        }

        private void ucNhanVien_Load(object sender, EventArgs e)
        {
            //gridControl1.DataSource = l.LoadNV();
            this.nHAN_VIENTableAdapter.Fill(this.dataSetQLK.NHAN_VIEN);
        }
    }
}
