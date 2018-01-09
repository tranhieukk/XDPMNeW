using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiem.Reports
{
    public class Student
    {


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
