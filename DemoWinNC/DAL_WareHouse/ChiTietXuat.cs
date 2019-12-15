using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_WareHouse
{
    public class ChiTietXuat: QuanLyKho
    {
        public void deleteTheoMP(string HD)
        {
            var ctpd = ql.CHI_TIET_PHIEU_XUATs.Where(t => t.MAHD == HD);
            if (ctpd == null)
                return;
            ql.CHI_TIET_PHIEU_XUATs.DeleteAllOnSubmit(ctpd);
            ql.SubmitChanges();
        }
    }
}
