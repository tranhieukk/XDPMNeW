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
   public class ThongTinDAO
    {
        private static ThongTinDAO instance;

        public static ThongTinDAO Instance
        {
            get { if (instance == null) instance = new ThongTinDAO(); return instance; }
            private set { instance = value; }
        }



        private ThongTinDAO() { }
        public rpThongTin getThongTinNamHoc(string maHKy)
        {
            rpThongTin rp=null;
            string query = "Exec USP_GetThongTinNamHoc @maHocKy";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { maHKy });
            foreach (DataRow row in data.Rows)
            {
                rp = new rpThongTin(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString());
            }
            return rp;
        }
    }
}
