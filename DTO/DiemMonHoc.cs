using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
  public  class DiemMonHoc
    {
        string maSinhVien;
        string maMonHoc;
        string maHocKy;
        string diemTX, diem15p, diemGK, diemCK1, diemCK2;
        private bool isGood;
        public DiemMonHoc(){}

        public string DiemTX { get => diemTX; set => diemTX = value; }
        public string Diem15p { get => diem15p; set => diem15p = value; }
        public string DiemGK { get => diemGK; set => diemGK = value; }
        public string DiemCK1 { get => diemCK1; set => diemCK1 = value; }
        public string DiemCK2 { get => diemCK2; set => diemCK2 = value; }
        public string MaSinhVien { get => maSinhVien; set => maSinhVien = value; }
        public string MaMonHoc { get => maMonHoc; set => maMonHoc = value; }
        public string MaHocKy { get => maHocKy; set => maHocKy = value; }

        public bool IsGood() {
            if (MaSinhVien == null || MaMonHoc == null || MaHocKy == null)
                return false;

            return (MaSinhVien.Length > 0) && (MaMonHoc.Length > 0)&&(MaHocKy.Length >0);

        }
    }
}
