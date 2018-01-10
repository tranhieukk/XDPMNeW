using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class QuanLyAccountDAO
    {


        private static QuanLyAccountDAO instance;

        public static QuanLyAccountDAO Instance
        {
            get
            {
                if (instance == null) instance = new QuanLyAccountDAO(); return instance;
            }
            private set => instance = value;
        }


        public DataTable SelectAll()
        {
            string query = "Exec USP_GetAllAccount";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
        public int Update(string quyenold, string quyennew, string username) {
            string query = "Exec USP_UpdateQuyen @maQuyenold , @maQuyennew , @username";
            int data = DataProvider.Instance.ExecuteNonQuery(query,new object[] {quyenold,quyennew,username });
            return data;
        }
        public int Insert(string username, string displayname, string pass, string maquyen)
        {
            string query = "Exec USP_addTaiKhoan @username , @displayname , @pass , @maQuyen";
            int data = DataProvider.Instance.ExecuteNonQuery(query, new object[] { username, displayname, pass, maquyen });
            return data;
        }
        public int Remove(string username, string maquyen)
        {
            string query = "Exec USP_XoaQuyenTaiKhoan @username , @maQuyen";
            int data = DataProvider.Instance.ExecuteNonQuery(query, new object[] { username, maquyen });
            return data;
        }

        public int Update( string username, string skin)
        {
            string query = "Exec USP_SaveSkin @username  , @Skin ";
            int data = DataProvider.Instance.ExecuteNonQuery(query, new object[] {  username,skin });
            return data;
        }
        public string GetSkin(string username)
        {
            string result = "";
            DataTable data = DataProvider.Instance.ExecuteQuery("exec USP_GetSkin @username", new object[] { username });

            foreach (DataRow row in data.Rows)
            {
                result = row[0].ToString();
            }
            return result;
        }
    }
}
