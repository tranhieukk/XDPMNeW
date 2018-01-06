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
   public class HocKyDAO
    {
        private HocKyDAO() { }
        private static HocKyDAO instance;

        public static HocKyDAO Instance {
            get { if(instance==null) instance= new HocKyDAO(); return instance; }
            private set => instance = value; }
        public DataTable loadAllHocky()
        {
           DataTable data = DataProvider.Instance.ExecuteQuery("exec USP_getAllHocKy");
           return data;

        }

        public int Insert(HocKy hocKy)
        {
            string query = "exec USP_addHocky @maHocky  , @tenHocky";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { hocKy.MaHocKy, hocKy.TenHocKy });

        }
        public int SoLuong(HocKy hocKy)
        {
            int sl = 0;
            string query = "exec  USP_CheckMaHocKy @maHocky  ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { hocKy.MaHocKy });
            foreach (DataRow row in data.Rows)
            {
                
                sl= int.Parse(row["soLuong"].ToString());
                
            }
            return sl;
        }
        public int Update(string maHockyold, HocKy hocKy )
        {
            string query = "exec USP_editHocky @maHockyold ,  @maHocky  , @tenHocky";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { maHockyold, hocKy.MaHocKy, hocKy.TenHocKy });

        }
        public int Remove(HocKy hocKy)
        {
            string query = "exec USP_deleteHocky  @maHocky ";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { hocKy.MaHocKy });

        }
    }
}
