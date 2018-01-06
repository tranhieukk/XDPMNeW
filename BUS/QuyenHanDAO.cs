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
    public class QuyenHanDAO
    {

        private QuyenHanDAO() { }
        private static QuyenHanDAO instance;

        public static QuyenHanDAO Instance
        {
            get { if (instance == null) instance = new QuyenHanDAO(); return instance; }
            private set => instance = value;
        }

        public int Insert(QuyenHan qh)
        {
            string query = "Exec USP_addQuyenHan @maQH , @noiDungQH , @trangThai ";
         return   DataProvider.Instance.ExecuteNonQuery(query, new object[] { qh.MaQuyen, qh.NoiDungQuyen, qh.TrangThai });
        }
        public int Remove(QuyenHan qh)
        {
            string query = "Exec USP_deleteQuyenHan @maQH  ";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { qh.MaQuyen });
        }
        public int Update(QuyenHan qh,string maQHOld)
        {
            string query = "Exec USP_editQuyenHan @maQHOld , @maQH , @noiDungQH , @trangThai ";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] {maQHOld, qh.MaQuyen, qh.NoiDungQuyen, qh.TrangThai });
        }

        public DataTable SelectAll()
        {
            string query = "Exec USP_getAllQuyenHan";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable SelectAllPermisionForAccount(Account account)
        {
            string query = "Exec USP_getCTQuyenHanByUsername @Username";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { account.UserName });
        }
        
        public int Grant(QuyenHan qh,Account ac)
        {
            string query = "Exec USP_grantQuyenHan @maQuyen , @taiKhoan , @choPhep";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] {qh.MaQuyen, ac.UserName ,1});
        }
        public int Revoke(QuyenHan qh, Account ac)
        {
            string query = "Exec USP_grantQuyenHan @maQuyen , @taiKhoan , @choPhep";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { qh.MaQuyen, ac.UserName, 0 });
        }

    }
}
