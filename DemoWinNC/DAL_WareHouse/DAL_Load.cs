using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_WareHouse
{
    public class DAL_Load : QuanLyKho
    {
        public List<NHAN_VIEN> LoadNV()
        {
            return ql.NHAN_VIENs.Select(t => t).ToList<NHAN_VIEN>();
        }

        public List<HANG_HOA> LoadHH()
        {
            return ql.HANG_HOAs.Select(t => t).ToList<HANG_HOA>();
        }

        public List<PHIEU_DAT_HANG> LoadPDH()
        {
            return ql.PHIEU_DAT_HANGs.Select(t => t).ToList<PHIEU_DAT_HANG>();
        }

        public List<PHIEU_XUAT_KHO> LoadPXK()
        {
            return ql.PHIEU_XUAT_KHOs.Select(t => t).ToList<PHIEU_XUAT_KHO>();
        }

        public List<NHA_CUNG_CAP> LoadNCC()
        {
            return ql.NHA_CUNG_CAPs.Select(t => t).ToList<NHA_CUNG_CAP>();
        }

        public List<KHU_VUC> LoadKV()
        {
            return ql.KHU_VUCs.Select(t => t).ToList<KHU_VUC>();
        }
        public List<KE_HANG> LoadKeHa()
        {
            return ql.KE_HANGs.Select(t => t).ToList<KE_HANG>();
        }

        public List<KE_HANG> LoadKeHa(string makv)
        {
            return ql.KE_HANGs.Where(t => t.MAKV == makv).ToList<KE_HANG>();
        }

        public List<CHI_TIET_PHIEU_DAT> loadCTPD()
        {
            return ql.CHI_TIET_PHIEU_DATs.Select(t => t).ToList<CHI_TIET_PHIEU_DAT>();
        }
        public List<CHI_TIET_PHIEU_XUAT> loadCTPX()
        {
            return ql.CHI_TIET_PHIEU_XUATs.Select(t => t).ToList<CHI_TIET_PHIEU_XUAT>();
        } 
    }
}
