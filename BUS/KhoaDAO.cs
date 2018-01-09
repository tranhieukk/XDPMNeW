using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class KhoaDAO
    {
        private static KhoaDAO instance;
        private KhoaDAO() { }
        public static KhoaDAO Instance
        {
            get { if (instance == null) instance = new KhoaDAO(); return instance; }
            private set { instance = value; }
        }
        public static int width = 150;
        public static int height = 150;
        public List<Khoa> loadAllKhoa()
        {
            List<Khoa> listKhoa = new List<Khoa>();
            DataTable data = DataProvider.Instance.ExecuteQuery("exec USP_getAllKhoa");
            foreach (DataRow item in data.Rows)
            {
                Khoa khoa = new Khoa(item);
                listKhoa.Add(khoa);
            }

            return listKhoa;

        }
        public DataTable SelectAll()
        {
            
            return DataProvider.Instance.ExecuteQuery("exec USP_getAllKhoa");
          
        }
        public string SelectbyMaLop(string maLop)
        {
            string result="";
            DataTable data = DataProvider.Instance.ExecuteQuery("exec USP_getKhoabyLop @maLop",new object[] { maLop});

            foreach (DataRow row in data.Rows)
            {
                result = row["Tenkhoa"].ToString();
            }
            return result;
        }
        public int addKhoa(string makhoa, string tenKhoa)
        {
            string query = "exec USP_addKhoa @maKhoa  , @tenKhoa";
           return DataProvider.Instance.ExecuteNonQuery(query, new object[] {makhoa, tenKhoa });
            
        }
        public int editKhoa(string makhoaold,string makhoa, string tenKhoa)
        {
            string query = "exec USP_editKhoa @makhoaold ,  @maKhoa  , @tenKhoa";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { makhoaold, makhoa, tenKhoa });

        }
        public int removeKhoa(string makhoa)
        {
            string query = "exec USP_deleteKhoa  @maKhoa ";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] {makhoa });

        }
        public int addLogo(string makhoa,byte[] img)
        {
            string query = "exec USP_addLogo @maKhoa , @img ";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { makhoa, img });

        }

    }
}
