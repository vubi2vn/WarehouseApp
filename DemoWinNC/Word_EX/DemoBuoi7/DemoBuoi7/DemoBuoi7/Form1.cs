using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoBuoi7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void khoaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.khoaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLSINHVIENDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLSINHVIENDataSet.Khoa' table. You can move, or remove it, as needed.
            this.khoaTableAdapter.Fill(this.qLSINHVIENDataSet.Khoa);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ExcelExport excel = new ExcelExport();
          

            if ( khoaDataGridView.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất");
                return;
            }

            List<Khoa> pListKhoa = new List<Khoa>();

            // Đổ dữ liệu vào danh sách
            foreach (DataGridViewRow item in khoaDataGridView.Rows)
            {
                Khoa i = new Khoa();
                i.MaKhoa = item.Cells[0].Value.ToString();
                i.TenKhoa = item.Cells[1].Value.ToString();
                pListKhoa.Add(i);
            }
            string path = string.Empty;
           
            excel.ExportKhoa(pListKhoa,  ref path, false);
            // Confirm for open file was exported
            if (!string.IsNullOrEmpty(path) && MessageBox.Show("Bạn có muốn mở file không?","Thông tin", MessageBoxButtons.YesNo,MessageBoxIcon.Information,MessageBoxDefaultButton.Button1)==System.Windows.Forms.DialogResult.Yes)
            {
                System.Diagnostics.Process.Start(path);
            }

        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            WordExport word = new WordExport();

            string ngay = DateTime.Now.Day.ToString();
            string thang = DateTime.Now.Month.ToString();
            string nam = DateTime.Now.Year.ToString();

// ngaythangQD = ngay + "/ghfhg" + thang + "/hghg" + nam;

            word.QuyetDinhKhenThuong(ngay, thang, nam, "Nguyễn Văn V", "89988");
        }
    }
}
