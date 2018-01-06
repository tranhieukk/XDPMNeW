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
  public  class ChuyenNganhDAO
    {


        private static ChuyenNganhDAO instance;

        public static ChuyenNganhDAO Instance
        {
            get { if (instance == null) instance = new ChuyenNganhDAO(); return instance; 
        }
        private    set => instance = value;
        }


        public List<ChuyenNganh> GetAllData()
        {

            List<ChuyenNganh> dsChuyenNganh = new List<ChuyenNganh>();
            string query = "Exec USP_GetAllData";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow row in data.Rows)
            {
                ChuyenNganh chuyenNganh = new ChuyenNganh(row);
                dsChuyenNganh.Add(chuyenNganh);
            }
            return dsChuyenNganh;
        }
        public DataTable SelectAllData()
        {


            string query = "Exec USP_GetAllNganhDaoTao";
            return DataProvider.Instance.ExecuteQuery(query);

        }
        public int Insert(ChuyenNganh chuyenNganh)
        {
            string query = " Exec USP_addChuyenNganh @MaNganh , @TenNganh , @MaKhoa ";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { chuyenNganh.MaNganh, chuyenNganh.TenNganh, chuyenNganh.MaKhoa });
        }
        public int Remove(ChuyenNganh chuyenNganh)
        {
            string query = " Exec USP_deleteChuyenNganh @MaNganh ";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { chuyenNganh.MaNganh });
        }
        public int Update(ChuyenNganh chuyenNganh,string maNganhHientai)
        {
            string query = " Exec USP_editChuyenNganh @maNganhHientai , @MaNganh , @TenNganh , @MaKhoa ";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] {maNganhHientai, chuyenNganh.MaNganh, chuyenNganh.TenNganh, chuyenNganh.MaKhoa });
        }
    }
}
