using QuanLyXeMay.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyXeMay.DAO
{
    class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            set { instance = value; }
        }

        private AccountDAO() { }

        public bool Login(string userName, string passWord)
        {      
            string query = "USP_Login @userName , @passWord";

            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { userName, MaHoa(passWord) });

            return result.Rows.Count > 0;
        }

        public List<Account> GetListAccount()
        {
            List<Account> list = new List<Account>();

            string query = "SELECT * FROM dbo.DangNhap";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Account account = new Account(item);
                list.Add(account);
            }

            return list;
        }

        public string GetLoaiTaiKhoan(string userName)
        {
            string query = "SELECT LoaiTaiKhoan FROM dbo.DangNhap WHERE TenDN = '" + userName + "'";

            using (SqlConnection connection = new SqlConnection(@"Data Source=.;Initial Catalog=QuanLyXeMay;Integrated Security=True"))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    return String.Format("{0}", reader[0]);
                }
            }
            return "";
        }

        public bool InsertAccount(string tenDN, string matKhau, string loaiTaiKhoan)
        {
            string query = string.Format("INSERT INTO dbo.DangNhap(TenDN, MatKhau, LoaiTaiKhoan) VALUES(N'{0}', N'{1}', N'{2}')", tenDN, MaHoa(matKhau), loaiTaiKhoan);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateAccount(string tenDN, string matKhau, string loaiTaiKhoan)
        {
            string query = string.Format("UPDATE dbo.DangNhap SET MatKhau = '{1}', LoaiTaiKhoan = N'{2}' WHERE TenDN = '{0}'", tenDN, MaHoa(matKhau), loaiTaiKhoan);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteAccount(string tenDN)
        {
            string query = string.Format("DELETE dbo.DangNhap WHERE TenDN = '{0}'", tenDN);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        private string MaHoa(string matKhau)
        {
            byte[] temp = ASCIIEncoding.ASCII.GetBytes(matKhau);
            byte[] hasData = new MD5CryptoServiceProvider().ComputeHash(temp);

            string hasPass = "";

            foreach (byte item in hasData)
            {
                hasPass += item;
            }

            return hasPass;
        }
    }
}
