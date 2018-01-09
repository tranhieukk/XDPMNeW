using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
  public  class DiemRenLuyen
    {
        string maSinhVien;
        string maHocKy;
        string maTieuChi;
        int tucham;
        int loptruong;
        int gvcn;
        int khoa;
       

        public DiemRenLuyen()
        {
                
        }
        public string MaSinhVien { get => maSinhVien; set => maSinhVien = value; }
        public string MaHocKy { get => maHocKy; set => maHocKy = value; }
        public string MaTieuChi { get => maTieuChi; set => maTieuChi = value; }
        public int Tucham { get => tucham; set => tucham = value; }
        public int Loptruong { get => loptruong; set => loptruong = value; }
        public int Gvcn { get => gvcn; set => gvcn = value; }
        public int Khoa { get => khoa; set => khoa = value; }
        public void Good(int m) {
            if (m < Gvcn) Gvcn = m;
            if (m < Khoa) Khoa = m;
            if (m < Loptruong) Loptruong = m;
            if (m < Tucham) Tucham = m;
            
        }
    }
}
