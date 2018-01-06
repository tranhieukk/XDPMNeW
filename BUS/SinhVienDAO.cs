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
 public   class SinhVienDAO
    {
        private SinhVienDAO() { }
        private static SinhVienDAO instance;

        public static SinhVienDAO Instance
        {
            get { if (instance == null) instance = new SinhVienDAO(); return instance; }
            private set => instance = value;
        }

        public int Insert(SinhVien sv)
        {
            string query = "Exec USP_addSinhVien @MaSinhVien , @Ho , @Ten , @NgaySinh , @GioiTinh , @anh , @malop , @diaChi , @chinhSach";
          return  DataProvider.Instance.ExecuteNonQuery(query, new object[] { sv.MaSinhVien,sv.HoSinhVien,sv.TenSinhVien,sv.NgaySinh,sv.GioiTinh,sv.HinhAnh,sv.Lop,sv.Diachi,sv.ChinhSachUutien });
        }
        public int Remove(SinhVien sv)
        {
            string query = "Exec USP_deleteSinhVien @MaSinhVien ";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { sv.MaSinhVien});
        }
        public int Update(SinhVien sv,string MasvOLD)
        {
            string query = "Exec USP_editSinhVien @MaSinhVienOld , @MaSinhVien , @Ho , @Ten , @NgaySinh , @GioiTinh , @anh , @malop , @diaChi , @chinhSach";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { MasvOLD,sv.MaSinhVien, sv.HoSinhVien, sv.TenSinhVien, sv.NgaySinh, sv.GioiTinh, sv.HinhAnh, sv.Lop, sv.Diachi, sv.ChinhSachUutien });
        }
        public DataTable SelectAll()
        {
            string query = "EXEC USP_getAllSinhVien";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public bool IsExist(string masv)
        {
            int sl = 0;
            string query = "exec  USP_CheckMaSinhVien @msv  ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { masv });
            foreach (DataRow row in data.Rows)
            {

                sl = int.Parse(row["soLuong"].ToString());

            }
            return sl>=1;
        }
    }
}
