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
    public class ThamSoDAO
    {


        private static ThamSoDAO instance;

        public static ThamSoDAO Instance
        {
            get
            {
                if (instance == null) instance = new ThamSoDAO(); return instance;
            }
            private set => instance = value;
        }


        public DataTable SelectAll()
        {
            string query = "Exec USP_GetAllThamSo";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
        public int Insert(ThamSo ThamSo)
        {
            string query = " Exec USP_addThamSo @maThamSo ,@giaTri , @ghiChu ";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { ThamSo.MaThamSo, ThamSo.GiaTri, ThamSo.GhiChu });
        }
        public int Remove(ThamSo ThamSo)
        {
            string query = " Exec USP_deleteThamSo @maThamSo ";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { ThamSo.MaThamSo });
        }
        public int Update(ThamSo ThamSo, string maThamSoOld)
        {
            string query = " Exec USP_editThamSo @maThamSoHientai , @maThamSo ,@giaTri , @ghiChu ";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { maThamSoOld, ThamSo.MaThamSo, ThamSo.GiaTri, ThamSo.GhiChu });
        }
    }
}
