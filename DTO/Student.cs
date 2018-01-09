using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Student
    {
        public Student(DataRow row)
        {
            MaSinhVien = row[0].ToString();
            HoVaTen = row[1].ToString();
            NgaySinh = row[2].ToString();
            Gender = row[3].ToString();
            QueQuan = row[4].ToString();
           
            GhiChu = row[5].ToString();

        }
        [Display(Name = "Mã sinh viên")]
        public string MaSinhVien { get; set; }

        [Display(Name = "Họ và tên")]
        public string HoVaTen { get; set; }

        [Display(Name = "Ngày sinh")]
        public string NgaySinh { get; set; }

        [Display(Name = "Giới tính")]
        public string Gender { get; set; }

        [Display(Name = "Quê quán")]
        public string QueQuan { get; set; }

        [Display(Name = "Chỗ ở hiện tại")]
        public string DiaChi { get; set; }

        [Display(Name = "Ghi chú")]
        public string GhiChu { get; set; }

    }
}
