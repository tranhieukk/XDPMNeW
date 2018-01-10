using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class rpHocBong
    {
        public rpHocBong(DataRow row )
        {
            maSV = row[0].ToString();
          hoVaten = row[1].ToString();
            Lop = row[2].ToString();
            DTB = row[3].ToString();
            

        }
        public string maSV { get; set; }
        public string hoVaten { get; set; }
        public string Lop { get; set; }
        public string DTB { get; set; }
        public string GhiChu { get; set; }

    }
}
