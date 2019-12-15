using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_WareHouse
{
    public class ChiTietPhieuNhap_DAL: QuanLyKho
    {
        DAL_Load load = new DAL_Load();
        public List<CHI_TIET_PHIEU_DAT> LoadTheoMAPD(string mapd)
        {
            return ql.CHI_TIET_PHIEU_DATs.Where(t => t.MAPHIEUDAT == mapd).ToList<CHI_TIET_PHIEU_DAT>();
        }

        public void deleteItem(string maCtpd)
        {
            CHI_TIET_PHIEU_DAT ctpd = ql.CHI_TIET_PHIEU_DATs.Where(t => t.MA_CTPD == maCtpd).FirstOrDefault();
            ql.CHI_TIET_PHIEU_DATs.DeleteOnSubmit(ctpd);
            ql.SubmitChanges();
        }       

        public void insertItem(string maCtpd, string MAPHIEUDAT, string MAMATHANG, int SOLUONG)
        {

            CHI_TIET_PHIEU_DAT ctpd = new CHI_TIET_PHIEU_DAT();

            ctpd.MA_CTPD = maCtpd;
            ctpd.MAPHIEUDAT = MAPHIEUDAT;
            ctpd.MAMATHANG = MAMATHANG;
            ctpd.SOLUONG = SOLUONG;

            ql.CHI_TIET_PHIEU_DATs.InsertOnSubmit(ctpd);
            ql.SubmitChanges();
        }


        public void insertAutoItem(string MAPHIEUDAT,string MAMATHANG, int SOLUONG)
        {
            CHI_TIET_PHIEU_DAT ctpd = new CHI_TIET_PHIEU_DAT();

            ctpd.MA_CTPD = autoMaCTPD();
            ctpd.MAPHIEUDAT = MAPHIEUDAT;
            ctpd.MAMATHANG = MAMATHANG;
            ctpd.SOLUONG = SOLUONG;

            ql.CHI_TIET_PHIEU_DATs.InsertOnSubmit(ctpd);
            ql.SubmitChanges();
        }

        //them ma tu dong
        private string autoMaCTPD()
        {
            List<CHI_TIET_PHIEU_DAT> a = new List<CHI_TIET_PHIEU_DAT>(load.loadCTPD());
            int tmp = a.Count;
            for (int i = 0; i <= tmp; i++)
            {
                if (!ktra("CTPD" + i.ToString()))
                    return "CTPD" + i.ToString();
            }
            return null;
        }

        public bool ktra(string ma)
        {
            if (ql.CHI_TIET_PHIEU_DATs.Where(t => t.MA_CTPD == ma).FirstOrDefault() != null)
                return true;//trùng
            return false;//không trùng
        }

        public void update(string maCtpd, string MAPHIEUDAT, string MAMATHANG, int SOLUONG)
        {
            CHI_TIET_PHIEU_DAT ctpd = ql.CHI_TIET_PHIEU_DATs.Where(t => t.MA_CTPD == maCtpd).FirstOrDefault();
            ctpd.MAPHIEUDAT = MAPHIEUDAT;
            ctpd.MAMATHANG = MAMATHANG;
            ctpd.SOLUONG = SOLUONG;

            ql.SubmitChanges();

        }

        //xoa theo ma phieu dat
        public void deleteTheoMPD(string MAPHIEUDAT)
        {
            var ctpd = ql.CHI_TIET_PHIEU_DATs.Where(t => t.MAPHIEUDAT == MAPHIEUDAT);
            if (ctpd == null)
                return;
            ql.CHI_TIET_PHIEU_DATs.DeleteAllOnSubmit(ctpd);
            ql.SubmitChanges();
        }
    }
}
