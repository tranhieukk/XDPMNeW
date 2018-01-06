using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhoaHoc
    {
        public KhoaHoc(string MaKhoaHoc = null, string NgayBatDau = null, string NgayKetThuc = null)
        {
            this.MaKhoaHoc = MaKhoaHoc;
            this.NgayBatDau = NgayBatDau;
            this.NgayKetThuc = NgayKetThuc;

        }

        public KhoaHoc(DataRow row)
        {

            MaKhoaHoc   = row["MaKhoaHoc"].ToString();
            NgayBatDau  = row["NgayBatDau"].ToString();
            NgayKetThuc = row["NgayKetThuc"].ToString();

        }
        string maKhoaHoc;
        string ngayBatDau;
        string ngayKetThuc;

        public string MaKhoaHoc { get => maKhoaHoc; set => maKhoaHoc = value; }
        public string NgayBatDau { get => ngayBatDau; set => ngayBatDau = value; }
        public string NgayKetThuc { get => ngayKetThuc; set => ngayKetThuc = value; }
    }
}
