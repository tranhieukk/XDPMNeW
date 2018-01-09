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
    public class MonHocDAO
    {


        private static MonHocDAO instance;

        public static MonHocDAO Instance
        {
            get
            {
                if (instance == null) instance = new MonHocDAO(); return instance;
            }
            private set => instance = value;
        }


        public DataTable SelectAll()
        {

          
            string query = "Exec USP_getAllMonHoc";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            return data;
        }
        public List<RpMonHoc> SelectByLop(string maLop)
        {
            List<RpMonHoc> rp = new List<RpMonHoc>();
            string query = "Exec USP_getMonHocBy @maLop";
            DataTable data = DataProvider.Instance.ExecuteQuery(query,new object[] { maLop });
            foreach(DataRow mh in data.Rows)
            {
                rp.Add(new RpMonHoc(mh));
            }
            return rp; ;
        }
        public DataTable Find(string key1, string key2, string key3   )
        {
            key1 = "%" + key1 + "%";
            key2 = "%" + key2 + "%";
            if (key3.Length == 0)
                key3 = "%%";
            string query = "Exec USP_FindInMonHoc @key1 , @key2 , @key3";
            DataTable data = DataProvider.Instance.ExecuteQuery(query,new object[] {key1,key2,key3 });

            return data;
        }
        public int Insert(MonHoc MonHoc)
        {
            string query = " Exec USP_addMonHoc @maMonHoc , @tenMonHoc , @soDVHT ";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { MonHoc.MaMH, MonHoc.TenMH, MonHoc.SoHocPhan });
        }
        public int Remove(MonHoc MonHoc)
        {
            string query = " Exec USP_deleteMonHoc @maMonHoc ";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { MonHoc.MaMH });
        }
        public int Update(MonHoc MonHoc, string maNganhHientai)
        {
            string query = " Exec USP_editMonHoc @MaMonHocHientai , @MaMonHoc , @TenMonHoc , @soDVHP ";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { maNganhHientai, MonHoc.MaMH, MonHoc.TenMH,MonHoc.SoHocPhan });
        }

        public bool IsExist(string mmh)
        {
            int sl = 0;
            string query = "exec  USP_checkMonHoc @maMonHoc  ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { mmh });
            foreach (DataRow row in data.Rows)
            {

                sl = int.Parse(row["LS"].ToString());

            }
            return sl >= 1;
        }
    }
}
