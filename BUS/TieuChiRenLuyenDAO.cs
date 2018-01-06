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
   public class TieuChiRenLuyenDAO
    {
        
        private TieuChiRenLuyenDAO() { }
        private static TieuChiRenLuyenDAO instance;

        public static TieuChiRenLuyenDAO Instance {
            get { if (instance == null) instance = new TieuChiRenLuyenDAO(); return instance; }
            private set => instance = value;
        }


        public DataTable SelectAll()
        {
            string query = "Exec USP_getAllTieuChiRenLuyen";
           return   DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable SelectChuaCham(string maSV, string maHocky,int thamSo)
        {
            string query = "Exec USP_getTieuChiRenLuyenChuaChambyMaSinhVien @maSinhVien , @maHocKy , @thamso ";
            return DataProvider.Instance.ExecuteQuery(query,new object[] { maSV, maHocky, thamSo });
        }
       
        public int Insert(TieuChiRenLuyen TieuChiRenLuyen)
        {
            string query = "Exec USP_addTieuChiRenLuyen @maTC , @noiDung , @diem";
            return DataProvider.Instance.ExecuteNonQuery(query,new object[] { TieuChiRenLuyen.MaTieuChi, TieuChiRenLuyen.TenTieuChi, TieuChiRenLuyen.MucDiem });
        }
        public int Remove(TieuChiRenLuyen TieuChiRenLuyen)
        {
            string query = " Exec USP_deleteTieuChiRenLuyen @maTieuChiRenLuyen ";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { TieuChiRenLuyen.MaTieuChi });
        }
        public int Update(string maTieuchi,TieuChiRenLuyen TieuChiRenLuyen)
        {
            string query = " Exec USP_editTieuChiRenLuyen @MaTieuChiRenLuyenHientai , @MaTieuChiRenLuyen , @TenTieuChiRenLuyen , @soDVHP ";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { maTieuchi, TieuChiRenLuyen.MaTieuChi, TieuChiRenLuyen.TenTieuChi, TieuChiRenLuyen.MucDiem });
        }
        public bool IsExist(string matc)
        {
            int sl = 0;
            string query = "exec  USP_CheckMaTieuChi @mtc  ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { matc });
            foreach (DataRow row in data.Rows)
            {

                sl = int.Parse(row["soLuong"].ToString());

            }
            return sl >= 1;
        }
    }
}
