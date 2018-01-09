using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
  public  class RpMonHoc
    {
      

        public RpMonHoc(DataRow mh)
        {
            maMH = mh[0].ToString();
            tenMH = mh[1].ToString();
            soHocPhan = mh[2].ToString();
            hocky = mh[3].ToString();
        }

        public string maMH { get; set; }
        public string tenMH { get; set; }
        public string soHocPhan { get; set; }
        public string hocky { get; set; }
    }
}
