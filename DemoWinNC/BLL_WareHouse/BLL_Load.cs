using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_WareHouse;
namespace BLL_WareHouse
{
    public class BLL_Load
    {
        DAL_Load dal = new DAL_Load();
        public List<NHAN_VIEN> LoadNV()
        {
            return dal.LoadNV();
        }

        public List<HANG_HOA> LoadHH()
        {
            return dal.LoadHH();
        }

        public List<PHIEU_DAT_HANG> LoadPDH()
        {
            return dal.LoadPDH();
        }

        public List<PHIEU_XUAT_KHO> LoadPXK()
        {
            return dal.LoadPXK();

        }
        public List<NHA_CUNG_CAP> LoadNCC()
        {
            return dal.LoadNCC();
        }
    
        public List<KHU_VUC> LoadKV()
        {
            return dal.LoadKV();
        }
        public List<KE_HANG> LoadKeHa()
        {
            return dal.LoadKeHa();
        }

        public List<KE_HANG> LoadKeHa(string makv)
        {
            return dal.LoadKeHa(makv);
        }
    }
}
