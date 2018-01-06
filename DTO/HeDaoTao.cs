using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
  public  class HeDaoTao
    {
        string maHe;
        string tenHe;
        public HeDaoTao (string maHe, string tenHe)
        {
            this.MaHe = maHe;
            this.TenHe = tenHe;
        }
        public HeDaoTao(DataRow dataRow)
        {
            this.MaHe = dataRow["MaHe"].ToString();
            this.TenHe = dataRow["TenHe"].ToString();

        }

        public string MaHe { get => maHe; set => maHe = value; }
        public string TenHe { get => tenHe; set => tenHe = value; }
    }
}
