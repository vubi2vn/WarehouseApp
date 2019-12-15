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
    public partial class frmConfiguration : Form
    {
        QuanLyNguoiDung cauhinh = new QuanLyNguoiDung();
        public frmConfiguration()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboSeverName_DropDown(object sender, EventArgs e)
        {
            cboSeverName.DataSource = cauhinh.GetSeverName();
            cboSeverName.DisplayMember = "ServerName";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            cauhinh.SaveConfig(cboSeverName.Text, txtUserName.Text, txtPassword.Text, cboDatabase.Text);
            this.Close();
        }

        private void cboDatabase_DropDown(object sender, EventArgs e)
        {
            cboDatabase.DataSource = cauhinh.GetDBName(cboSeverName.Text, txtUserName.Text, txtPassword.Text);
            cboDatabase.DisplayMember = "name";
        }
    }
}
