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
    public class DiemRenLuyenDAO
    {


        private static DiemRenLuyenDAO instance;

        public static DiemRenLuyenDAO Instance
        {
            get
            {
                if (instance == null) instance = new DiemRenLuyenDAO(); return instance;
            }
            private set => instance = value;
        }


      
        public DataTable SelectAllData(int thamSo,string mahocky, string keyword)
        {
            string query = "Exec USP_GetAllDiemRenLuyen @thamso , @maHocKy  , @keyword";
            return DataProvider.Instance.ExecuteQuery(query, new object[] {thamSo,mahocky,keyword });

        }
        public int Insert(DiemRenLuyen diemRenLuyen)
        {
            string query = " Exec USP_addDiemRenLuyen @maSinhVien , @maHocKy , @maTieuChi , @diemTuCham , @diemLTCham , @diemGVCNCham , @diemKhoaCham  ";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { diemRenLuyen.MaSinhVien,
                diemRenLuyen.MaHocKy, diemRenLuyen.MaTieuChi,diemRenLuyen.Tucham,diemRenLuyen.Loptruong,diemRenLuyen.Gvcn,diemRenLuyen.Khoa });
        }
        public int Remove(DiemRenLuyen diemRenLuyen)
        {
            string query = " Exec USP_deleteDiemRenLuyen  @maSinhVien , @maHocKy , @maTieuChi ";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { diemRenLuyen.MaSinhVien, diemRenLuyen.MaHocKy,diemRenLuyen.MaTieuChi });
        }
        public bool IsExist(string mahocky)
        {
            string query = "Exec USP_KiemTraBangDiemRenLuyen @maHocKy ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { mahocky });
            foreach(DataRow row in data.Rows)
            {
                if (row["row"].ToString() != "0") return true;
            }
            return false;
        }public int KhoiTao(string mahocky)
        {
            string query = " Exec USP_KhoiTaoDiemRenLuyen @maHocKy ";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { mahocky });

        }

        public int KhoiTaoForSV(string masv, string maHocKy)
        {
            string query = " Exec USP_KhoiTaoDiemRenLuyenSV @maSinhVien , @maHocKy  ";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { masv, maHocKy });

        }

        public int DemSoLuongTieuChiSV(string masv, string maHocKy)
        {
            string query = " Exec USP_DemSoLuongTieuChiSV @maSinhVien , @maHocKy  ";
            DataTable data= DataProvider.Instance.ExecuteQuery(query, new object[] { masv, maHocKy });
            foreach(DataRow kq in data.Rows)
            {
                int a = int.Parse(kq["SoLuong"].ToString()); return a;
            }
           
            return 0;
        }


    }
}
