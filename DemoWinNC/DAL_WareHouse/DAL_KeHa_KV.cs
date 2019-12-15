using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_WareHouse
{
    public class DAL_KeHa_KV: QuanLyKho
    {
        public void insertItem(string MAKEHANG, string MAKV)
        {

            KE_HANG pd = new KE_HANG();
            pd.MAKV = MAKV;
            pd.MAKEHANG = MAKEHANG;      
            ql.KE_HANGs.InsertOnSubmit(pd);
            ql.SubmitChanges();
        }
    }
}
