using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class rpDiemMonHoc
    {
        public rpDiemMonHoc(DataRow dataRow)
        {
            MaMonHoc= dataRow[0].ToString();
            TenMonHoc = dataRow[1].ToString();
            SoDonViHocPhan = dataRow[2].ToString();
            DiemTongKet = dataRow[3].ToString();
        }
        public string MaMonHoc { get; set; }
        public string TenMonHoc { get; set; }
        public string SoDonViHocPhan { get; set; }
        public string DiemTongKet { get; set; }

    }
}
