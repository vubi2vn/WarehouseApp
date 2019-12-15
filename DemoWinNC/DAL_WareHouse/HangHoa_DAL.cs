using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_WareHouse
{
    public class HangHoa_DAL:QuanLyKho
    {
        public List<HANG_HOA> LoadHHTheoKeHa(string makeha)
        {
            return ql.HANG_HOAs.Select(t=>t).Where(t => t.MAKEHANG == makeha).ToList<HANG_HOA>();
        }

        public List<HANG_HOA_TTCB> LoadHHCB(string makeha)
        {
            
            List<HANG_HOA_TTCB> lst = ql.HANG_HOAs.Where(t => t.MAKEHANG == makeha).
                Select(i => new HANG_HOA_TTCB() { TENMATHANG = i.TENMATHANG, MAMATHANG = i.MAMATHANG, SOLUONG = i.SOLUONG ?? default(int) }).ToList();
            return lst;
        }


    }
}
