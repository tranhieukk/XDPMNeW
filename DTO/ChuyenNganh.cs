using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
  public  class ChuyenNganh
    {
        string maNganh;
        string tenNganh;
        string maKhoa;
        public ChuyenNganh(string maNganh,string tenNganh,string maKhoa ){

            MaNganh = maNganh;
            MaKhoa = maKhoa;
            TenNganh = tenNganh;
            }
        public ChuyenNganh(DataRow row)
        {
            MaNganh = row["MaNganh"].ToString();
            MaKhoa = row["MaKhoa"].ToString();
            TenNganh = row["TenNganh"].ToString();
        }
        public string MaNganh { get => maNganh; set => maNganh = value; }
        public string TenNganh { get => tenNganh; set => tenNganh = value; }
        public string MaKhoa { get => maKhoa; set => maKhoa = value; }
    }
}
