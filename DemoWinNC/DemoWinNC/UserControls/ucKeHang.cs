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
    public partial class ucKeHang : UserControl
    {     

        public ucKeHang(string makv,string makeha)
        {
            InitializeComponent();
            label1.Text = makeha;
            label1.Name = makeha;            
        }

        private void pictureEdit1_MouseClick(object sender, MouseEventArgs e)
        {
            frmHangHoaInKeHang frm = new frmHangHoaInKeHang();
            frm.Makeha = label1.Name;
            frm.ShowDialog();
        }

        private void pictureEdit1_MouseHover(object sender, EventArgs e)
        {
            pictureEdit1.BackColor = Color.PapayaWhip;
            panel1.BackColor = Color.PapayaWhip;
            Cursor.Current = Cursors.Hand;
            
        }

        private void pictureEdit1_MouseLeave(object sender, EventArgs e)
        {
            pictureEdit1.BackColor = Color.White;
            panel1.BackColor = Color.White;
            Cursor.Current = Cursors.Default;
        }
    }
}
