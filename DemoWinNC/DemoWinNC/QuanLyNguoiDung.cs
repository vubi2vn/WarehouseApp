using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoWinNC
{
    public class QuanLyNguoiDung
    {
        public int Check_Config()
        {
            if (Properties.Settings.Default.QLKhoBenBaiConnectionString == string.Empty)
                return 1; // ko tồn tại
            SqlConnection _Sqlconn = new SqlConnection(Properties.Settings.Default.QLKhoBenBaiConnectionString);
            try
            {
                if (_Sqlconn.State == System.Data.ConnectionState.Closed)
                    _Sqlconn.Open();
                return 0; // thành công
            }
            catch
            {
                return 2; //cấu hình ko hợp lệ
            }
        }
        public LoginResult Check_User(string pUser, string pPass)
        {
            SqlDataAdapter daUser = new SqlDataAdapter("Select * from TAIKHOAN where TENDN='" + pUser + "'and MATKHAU='" + pPass + "'", Properties.Settings.Default.QLKhoBenBaiConnectionString);
            DataTable dt = new DataTable();
            daUser.Fill(dt);
            if (dt.Rows.Count == 0)
            {
                return LoginResult.Ivalid;//khong ton tai
            }
            else if (dt.Rows[0][2] == null || dt.Rows[0][2].ToString() == "false")
            {
                return LoginResult.Disabled;//khong hoat dong
            }
            return LoginResult.Success;//thanh cong
        }
        public DataTable GetSeverName()
        {
            DataTable dt = new DataTable();
            dt = SqlDataSourceEnumerator.Instance.GetDataSources();
            return dt;
        }

        public DataTable GetDBName(string pServer, string pUser, string pPass)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select name from sys.Databases", "Data Source=" + pServer + ";Initial Catalog=master;User ID=" + pUser + ";pwd = " + pPass + "");
            da.Fill(dt);
            return dt;
        }

        public void SaveConfig(string pServer, string pUser, string pPass, string pDBName)
        {
            Properties.Settings.Default["QLKhoBenBaiConnectionString"] = "Data Source=" + pServer + ";Initial Datalog=" + pDBName + ";User ID=" + pUser + ";pwd = " + pPass + "";
            Properties.Settings.Default.Save();
        }
    }
}
