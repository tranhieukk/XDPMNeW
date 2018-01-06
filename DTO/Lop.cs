using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class Lop
    {
        private string maLop, tenLop, maKhoaHoc, maHeDaoTao, maNganh;
        public Lop(string maLop=null, string tenLop = null, string maKhoaHoc = null, string maHeDaoTao = null, string maNganh = null) { }
        public string MaLop { get => maLop; set => maLop = value; }
        public string TenLop { get => tenLop; set => tenLop = value; }
        public string MaKhoaHoc { get => maKhoaHoc; set => maKhoaHoc = value; }
        public string MaHeDaoTao { get => maHeDaoTao; set => maHeDaoTao = value; }
        public string MaNganh { get => maNganh; set => maNganh = value; }
    }
}
