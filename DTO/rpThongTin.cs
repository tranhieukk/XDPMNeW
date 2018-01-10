using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class rpThongTin
    {
       public rpThongTin(string namHoc, string hocky, string hedaotao, string chuyenNganh)
        {
            this.namHoc = namHoc;
            this.hocky = hocky;
            this.hedaotao = hedaotao;
            this.chuyenNganh = chuyenNganh;
           
        }
        public string namHoc { get; set; }
        public string khoa { get; set; }
        public string hocky { get; set; }
        public string hedaotao { get; set; }
        public string chuyenNganh { get; set; }
    }
}
