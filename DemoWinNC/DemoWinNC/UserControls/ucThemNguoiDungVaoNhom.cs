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
    public partial class ucThemNguoiDungVaoNhom : UserControl
    {
        public ucThemNguoiDungVaoNhom()
        {
            InitializeComponent();
        }

        private void tAIKHOANBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tAIKHOANBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSetQLK);

        }

        private void ucThemNguoiDungVaoNhom_Load(object sender, EventArgs e)
        {
            this.tAIKHOANTableAdapter.Fill(this.dataSetQLK.TAIKHOAN);
            this.qL_NHOMNGUOIDUNGTableAdapter.Fill(this.dataSetQLK.QL_NHOMNGUOIDUNG);      
            mANHOMNGUOIDUNGComboBox.DisplayMember = "MANHOMNGUOIDUNG";
            mANHOMNGUOIDUNGComboBox.ValueMember = "MANHOMNGUOIDUNG";
            loaddl();
        }

       

        public void loaddl() {
            try
            {
                this.nGUOIDUNG_NHOMNGUOIDUNGDKTableAdapter.Fill_DK(this.dataSetQLK.NGUOIDUNG_NHOMNGUOIDUNGDK, mANHOMNGUOIDUNGComboBox.SelectedValue.ToString());
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void mANHOMNGUOIDUNGComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            loaddl();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                int index = gridView1.FocusedRowHandle;
                string tendn = gridView1.GetRowCellValue(index, "TENDN").ToString();
                string manhom = mANHOMNGUOIDUNGComboBox.SelectedValue.ToString();
                nGUOIDUNG_NHOMNGUOIDUNGTableAdapter.Insert(tendn, manhom);
                loaddl();
                MessageBox.Show("Thêm thành công", "Thông báo");
            }
            catch
            {
                MessageBox.Show("Thất bại");
            }
        }
    }
}
