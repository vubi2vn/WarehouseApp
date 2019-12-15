using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DAL_WareHouse
{
    public class PhieuDat_DAL : QuanLyKho
    {
        ChiTietPhieuNhap_DAL ctpd = new ChiTietPhieuNhap_DAL();
        DAL_Load load = new DAL_Load();

        public void deleteItem(string MAPHIEUDAT)
        {
            PHIEU_DAT_HANG pd = ql.PHIEU_DAT_HANGs.Where(t => t.MAPHIEUDAT == MAPHIEUDAT).FirstOrDefault();
            ctpd.deleteTheoMPD(MAPHIEUDAT);
            ql.PHIEU_DAT_HANGs.DeleteOnSubmit(pd);
            ql.SubmitChanges();
        }

        public void insertItem(string MANCC, string MANV)
        {

            PHIEU_DAT_HANG pd = new PHIEU_DAT_HANG();

            pd.MAPHIEUDAT = autoMAPHIEUDAT();
            pd.MANCC = MANCC;
            pd.NGAYLAP = DateTime.Today;
            pd.MANV = MANV;
            ql.PHIEU_DAT_HANGs.InsertOnSubmit(pd);
            ql.SubmitChanges();
        }
        //them ma tu dong
        private string autoMAPHIEUDAT()
        {
            List<PHIEU_DAT_HANG> a = new List<PHIEU_DAT_HANG>(load.LoadPDH());
            int tmp = a.Count;
            for (int i = 0; i <= tmp; i++)
            {
                if (!ktra("PD"+i.ToString()))
                    return "PD"+i.ToString();
            }
            return null;
        }

        public bool ktra(string ma)
        {
            if (ql.PHIEU_DAT_HANGs.Where(t => t.MAPHIEUDAT == ma).FirstOrDefault() != null)
                return true;//trùng
            return false;//không trùng
        }
        public void updateItem(string MAPHIEUDAT, string MANCC, string MANV)

        {

            PHIEU_DAT_HANG pd = ql.PHIEU_DAT_HANGs.Where(t => t.MAPHIEUDAT == MAPHIEUDAT).FirstOrDefault();
            pd.MANCC = MANCC;
            pd.MANV = MANV;
            ql.SubmitChanges();
        }
    }
}
