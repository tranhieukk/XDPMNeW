using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
  public  class QuyenHan
    {
        string maQuyen;
        string noiDungQuyen;
        String trangThai;

        public QuyenHan() { }


        public string MaQuyen { get => maQuyen; set => maQuyen = value; }
        public string NoiDungQuyen { get => noiDungQuyen; set => noiDungQuyen = value; }
        public string TrangThai { get => trangThai; set => trangThai = value; }
    }
}
