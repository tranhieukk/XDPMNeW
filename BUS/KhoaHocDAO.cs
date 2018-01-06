using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{
    public class KhoaHocDAO
    {
        private KhoaHocDAO() { }
        private static KhoaHocDAO instance = new KhoaHocDAO();

        public static KhoaHocDAO Instance
        {
            get { if (instance == null) instance = new KhoaHocDAO(); return instance; }
            private set => instance = value;
        }
        public DataTable getAllData()
        {
            string query = "Exec USP_getAllKhoaHoc";
            return DAL.DataProvider.Instance.ExecuteQuery(query);
        }


        public int Insert(KhoaHoc kh)
        {
            string query = "Exec USP_addKhoaHoc @maKhoaHoc , @ngayBatDau , @ngayKetthuc";
            return DAL.DataProvider.Instance.ExecuteNonQuery(query, new object[] { kh.MaKhoaHoc, kh.NgayBatDau, kh.NgayKetThuc });
        }
        public int Update(KhoaHoc kh,string maKhoaHocOld)
        {
            string query = "Exec USP_addKhoaHoc @maKhoaHocOld , @maKhoaHoc , @ngayBatDau , @ngayKetthuc";
            return DAL.DataProvider.Instance.ExecuteNonQuery(query, new object[] { maKhoaHocOld, kh.MaKhoaHoc, kh.NgayBatDau, kh.NgayKetThuc });
        }
        public int Remove(KhoaHoc kh)
        {
            string query = "Exec USP_addKhoaHoc @maKhoaHoc ";
            return DAL.DataProvider.Instance.ExecuteNonQuery(query, new object[] { kh.MaKhoaHoc });
        }
    }
}
