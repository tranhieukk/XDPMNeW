using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
  public  class HocKy
    {
        string maHocKy, tenHocKy;
        public HocKy() { }
        public HocKy(string maHocKy, string tenHocKy)
        {
            MaHocKy = maHocKy;
            TenHocKy = tenHocKy;
        }

        public string MaHocKy { get => maHocKy; set => maHocKy = value; }
        public string TenHocKy { get => tenHocKy; set => tenHocKy = value; }
    }
}
