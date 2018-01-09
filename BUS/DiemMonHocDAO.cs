using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace BUS
{
   public class DiemMonHocDAO
    {

        private static DiemMonHocDAO instance;

        public static DiemMonHocDAO Instance
        {
            get
            {
                if (instance == null) instance = new DiemMonHocDAO(); return instance;
            }
            private set => instance = value;
        }
        public int  ChamDiem(DiemMonHoc diemMonHoc)
        {
            string query = "Exec USP_addDiem @maSinhVien , @maMonHoc , @maHocKy , @diemTX , @diem15p , @diemGK , @diemCK1 , @diemCK2 ";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { diemMonHoc.MaSinhVien, diemMonHoc.MaMonHoc, diemMonHoc.MaHocKy, diemMonHoc.DiemTX, diemMonHoc.Diem15p, diemMonHoc.DiemGK, diemMonHoc.DiemCK1, diemMonHoc.DiemCK2 });
        }
        public DataTable SelectDiemByLop(string mahocky, string maMH,string maLop)
        {
            string query = "Exec USP_getBangDiem @maHKy , @maMon , @maLop";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { mahocky,maMH,maLop});

        }
        public bool IsCreate(string mahk,string malop,string mamon)
        {
            bool result=false;
            string query = "Exec USP_KiemTraDiem @malop , @maMonHoc , @maHocKy ";
            DataTable data =DataProvider.Instance.ExecuteQuery(query, new object[] { malop, mamon, mahk });

            foreach(DataRow row in data.Rows)
            {
                result=(int.Parse(row["SL"].ToString()) > 0);
               
            }
            return result;
        }
        public int Create(string mahk, string malop, string mamon)
        {
            string query = "Exec USP_EstablishDiemByLop @maHKy , @maLop , @maMon ";
          return   DataProvider.Instance.ExecuteNonQuery(query, new object[] {mahk ,malop, mamon  });

        }
        public List<rpDiemMonHoc> GetListDiemSV(string maSinhVien)
        {
            List<rpDiemMonHoc> list = new List<rpDiemMonHoc>();
            string query = "EXEC USP_getDiemBySV @masv ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { maSinhVien });
            foreach (DataRow row in data.Rows)
            {
                rpDiemMonHoc diem  = new rpDiemMonHoc(row);
                list.Add(diem);
            }
            return list;
        }
        public DataTable GetTableDiemSV(string maSinhVien)
        {
            string query = "EXEC USP_getDiemBySV @masv ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { maSinhVien });
            return data;
        }
    }
}
