using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class ChiTietQuyenHan
    {
        string maChitiet;
        string maQuyen;
        string tenHoatDong;
        string code_hoatDong;
        public ChiTietQuyenHan() { }
        public ChiTietQuyenHan(DataRow row)
        {
            this.MaChitiet = row["MaChiTiet"].ToString();
            this.MaQuyen = row["MaQuyen"].ToString();
            TenHoatDong= row["tenHoatDong"].ToString();
            Code_hoatDong = row["Code_hoatDong"].ToString();
            

        }

        public string MaChitiet { get => maChitiet; set => maChitiet = value; }
        public string MaQuyen { get => maQuyen; set => maQuyen = value; }
        public string TenHoatDong { get => tenHoatDong; set => tenHoatDong = value; }
        public string Code_hoatDong { get => code_hoatDong; set => code_hoatDong = value; }
    }
}
