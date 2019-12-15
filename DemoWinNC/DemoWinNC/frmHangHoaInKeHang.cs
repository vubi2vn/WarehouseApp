using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL_WareHouse;
namespace DemoWinNC
{
    public partial class frmHangHoaInKeHang : Form
    {
        HangHoa_DAL hh = new HangHoa_DAL();
        public frmHangHoaInKeHang()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        string makeha;

        public string Makeha { get => makeha; set => makeha = value; }
        private void frmHangHoaInKeHang_Load(object sender, EventArgs e)
        {
            lblKeHang.Text = makeha;
            gridControl1.DataSource = hh.LoadHHCB(makeha);
        }
    }
}
