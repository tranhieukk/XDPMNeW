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
        public DataTable SelectByLop(string malop)
        {
            string query = "EXEC USP_getSinhVienByLop @maLop ";
            return DataProvider.Instance.ExecuteQuery(query,new object[] { malop });
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
        public List<Student> GetListSV(string maLop)
        {
            List<Student> list = new List<Student>();
            string query = "EXEC USP_getSinhVienByLop @maLop ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { maLop });
            foreach(DataRow row in data.Rows)
            {
                Student sv = new Student(row);
                list.Add(sv);
            }
            return list;
        }
        public StudentDetail GetStudentDetail(string maSV)
        {
            StudentDetail sv = new StudentDetail();
            string query = "EXEC USP_getSinhVienDetail @masv ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { maSV });
            foreach (DataRow row in data.Rows)
            {
                sv.FullName = row[0].ToString();
                sv.DateOfBirth = row[1].ToString();
                sv.Gender = row[2].ToString();
                sv.Root = row[3].ToString();
                sv.Class = row[4].ToString();
                sv.Course = row[5].ToString();
                sv.Specialized = row[6].ToString();
                sv.TrainingSystem = row[7].ToString();

            }
            return sv;
        }
    }
}
