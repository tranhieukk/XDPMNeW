using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
  public  class SinhVien
    {
        string maSinhVien;
        string hoSinhVien;
        string tenSinhVien;
        DateTime ngaySinh;
        string gioiTinh;
        byte[] hinhAnh;
        string lop;
        string diachi;
        string chinhSachUutien;
        public SinhVien() { }
        public SinhVien(string maSinhVien, string hoSinhVien, string tenSinhVien, DateTime ngaySinh, string gioiTinh, byte[] hinhAnh, string lop,  string diachi,  string chinhSachUutien)
        {
            MaSinhVien = maSinhVien;
            HoSinhVien = hoSinhVien;
            TenSinhVien = tenSinhVien;
            NgaySinh = ngaySinh;
            GioiTinh = gioiTinh;
            HinhAnh = hinhAnh;
            Lop = lop;
            Diachi = diachi;
            ChinhSachUutien = chinhSachUutien;
        }
        public string MaSinhVien { get => maSinhVien; set => maSinhVien = value; }
        public string TenSinhVien { get => tenSinhVien; set => tenSinhVien = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public byte[] HinhAnh { get => hinhAnh; set => hinhAnh = value; }
        public string Lop { get => lop; set => lop = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string ChinhSachUutien { get => chinhSachUutien; set => chinhSachUutien = value; }
        public string HoSinhVien { get => hoSinhVien; set => hoSinhVien = value; }
    }
}
