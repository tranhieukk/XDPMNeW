using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
  public  class MonHoc
    {
        string maMH;
        string tenMH;
        int soHocPhan;
        public MonHoc() { }
        public MonHoc(DataRow row)
        {
            maMH = row["Mã môn học"].ToString();
            tenMH = row["Tên môn học"].ToString();
            soHocPhan = int.Parse( row["Số đơn vị học trình"].ToString());
        }
        public string MaMH { get => maMH; set => maMH = value; }
        public string TenMH { get => tenMH; set => tenMH = value; }
        public int SoHocPhan { get => soHocPhan; set => soHocPhan = value; }
    }
}
