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
    public partial class ucKhuVuc : UserControl
    {

        DAL_Load load = new DAL_Load();
        DAL_KeHa_KV keha = new DAL_KeHa_KV();
        
        public ucKhuVuc()
        {
            InitializeComponent();
        }

        private void ucKhuVuc_Load(object sender, EventArgs e)
        {
            panelControl1.AutoScroll = true;
            loadCbo();
            LoadKV();          
        }

        private void loadCbo()
        {
            List<KHU_VUC> kv = new List<KHU_VUC>(load.LoadKV());
                 }
        private void LoadKV()
        {
            int tmpx = 7;
            int x = tmpx, y = 70;
            int md = 5;
            List<KHU_VUC> kv = new List<KHU_VUC>(load.LoadKV());
            for (int j = 0; j < kv.Count; j++)
            {
                List<KE_HANG> lst = new List<KE_HANG>(load.LoadKeHa(kv[j].MAKV));
                Label lbl = new Label();
                lbl.Font = new Font("Verdana", 10);
                lbl.Location = new Point(x, y);
                lbl.Text = kv[j].TENKV;
                lbl.ForeColor = Color.White;
                lbl.BackColor = Color.Blue;
                panelControl1.Controls.Add(lbl);
                x += 110;
                for (int i = 1; i <= lst.Count; i++)
                {
                    ucKeHang uc = new ucKeHang(lst[i - 1].MAKV, lst[i - 1].MAKEHANG);
                    uc.Location = new Point(x, y);
                    panelControl1.Controls.Add(uc);
                    x += 100;
                    if (i % md == 0)
                    {
                        x = tmpx+110;
                        y += 130;
                    }                
                }
                x = tmpx;
                y += 130;
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            //keha.insertItem(txtKeHa.Text, cboKhuvuc.SelectedValue.ToString());
            LoadKV();
        }
    }
}
