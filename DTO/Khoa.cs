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
    public class Khoa
    {
        public Khoa(string maKhoa=null, string tenKhoa=null)
        {
            this.MaKhoa = maKhoa;
            this.TenKhoa = tenKhoa;
           
        }
       
        public Khoa(DataRow row)
        {
            
            this.MaKhoa = row["MaKhoa"].ToString();
            this.TenKhoa = row["tenkhoa"].ToString();
          
        }
        string maKhoa;
        string tenKhoa;
    

        public string MaKhoa { get => maKhoa; set => maKhoa = value; }
        public string TenKhoa { get => tenKhoa; set => tenKhoa = value; }
       
    }
}
