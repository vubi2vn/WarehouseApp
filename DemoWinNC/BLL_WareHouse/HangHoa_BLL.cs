using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_WareHouse;
namespace BLL_WareHouse
{
    public class HangHoa_BLL
    {
        HangHoa_DAL dal = new HangHoa_DAL();
        public List<HANG_HOA> LoadHHTheoKeHa(string makeha)
        {
            return dal.LoadHHTheoKeHa(makeha);
        }

        public List<HANG_HOA_TTCB> LoadHHCB(string makeha)
        {
           return dal.LoadHHCB(makeha);
        }
    }
}
