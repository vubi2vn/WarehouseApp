using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoBuoi7
{
  public  class Khoa
    {
        string _MaKhoa;
        string _STT;

        public string STT
        {
            get { return _STT; }
            set { _STT = value; }
        }
        string _TenKhoa;

        public string TenKhoa
        {
            get { return _TenKhoa; }
            set { _TenKhoa = value; }
        }
        public string MaKhoa
        {
            get { return _MaKhoa; }
            set { _MaKhoa = value; }
        }
    }
}
