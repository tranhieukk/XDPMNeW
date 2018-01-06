using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class ThamSo
    {
        string maThamSo;
        float giaTri;
        string ghiChu;
        public ThamSo() { }

        public string MaThamSo { get => maThamSo; set => maThamSo = value; }
        public float GiaTri { get => giaTri; set => giaTri = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }
    }
}
