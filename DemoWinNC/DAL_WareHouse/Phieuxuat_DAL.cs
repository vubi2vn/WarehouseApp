using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_WareHouse
{
    public class Phieuxuat_DAL: QuanLyKho
    {
        DAL_Load load = new DAL_Load();
        ChiTietXuat ctx = new ChiTietXuat();
        public void insertItem(string MANV)
        {

            PHIEU_XUAT_KHO pd = new PHIEU_XUAT_KHO();

            pd.MAHD = autoMAPHIEUDAT();
            pd.MANV = MANV;
            pd.NGAYLAP = DateTime.Today;
            ql.PHIEU_XUAT_KHOs.InsertOnSubmit(pd);
            ql.SubmitChanges();
        }
        //them ma tu dong
        private string autoMAPHIEUDAT()
        {
            List<PHIEU_XUAT_KHO> a = new List<PHIEU_XUAT_KHO>(load.LoadPXK());
            int tmp = a.Count;
            for (int i = 0; i <= tmp; i++)
            {
                if (!ktra("HD" + i.ToString()))
                    return "HD" + i.ToString();
            }
            return null;
        }

        public bool ktra(string ma)
        {
            if (ql.PHIEU_XUAT_KHOs.Where(t => t.MAHD == ma).FirstOrDefault() != null)
                return true;//trùng
            return false;//không trùng
        }

        public void deleteItem(string MAHD)
        {
            PHIEU_XUAT_KHO pd = ql.PHIEU_XUAT_KHOs.Where(t => t.MAHD == MAHD).FirstOrDefault();
            ctx.deleteTheoMP(MAHD);
            ql.PHIEU_XUAT_KHOs.DeleteOnSubmit(pd);
            ql.SubmitChanges();
        }
    }
}
