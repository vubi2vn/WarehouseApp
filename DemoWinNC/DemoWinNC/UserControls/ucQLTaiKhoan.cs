using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoWinNC.UserControls
{
    public partial class ucQLTaiKhoan : UserControl
    {
        public ucQLTaiKhoan()
        {
            InitializeComponent();
        }

     

        private void ucQLTaiKhoan_Load(object sender, EventArgs e)
        {
            this.tAIKHOANTableAdapter.Fill(this.dataSetQLK.TAIKHOAN);
        }

        private void tAIKHOANBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tAIKHOANBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSetQLK);

        }
    }
}
