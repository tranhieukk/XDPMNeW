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
    public class LopDAO
    {
        private LopDAO() { }
        private static LopDAO instance = new LopDAO();

        public static LopDAO Instance {
            get { if (instance == null) instance = new LopDAO(); return instance; }
            private set => instance = value; }
        public DataTable getAllData()
        {
            string query = "Exec USP_getAllLop";
            return DAL.DataProvider.Instance.ExecuteQuery(query);
        }

        public int addLop(Lop lop )
        {
            string query = "Exec USP_addLop @maLop , @tenLop , @maKhoaHoc , @heDaoTao  , @nganhHoc";
            return DAL.DataProvider.Instance.ExecuteNonQuery(query,new object[] { lop.MaLop, lop.TenLop, lop.MaKhoaHoc, lop.MaHeDaoTao, lop.MaNganh });
        }
        public int editLop(Lop lop,string malopOld)
        {
            string query = "Exec USP_editLop @malopOld , @maLop , @tenLop , @maKhoaHoc , @heDaoTao  , @nganhHoc";
            return DAL.DataProvider.Instance.ExecuteNonQuery(query, new object[] {malopOld, lop.MaLop, lop.TenLop, lop.MaKhoaHoc, lop.MaHeDaoTao, lop.MaNganh });
        }
        public int removeLop(string malopOld)
        {
            string query = "Exec USP_deletetLop @malopOld ";
            return DAL.DataProvider.Instance.ExecuteNonQuery(query, new object[] { malopOld});
        }
    }
}
