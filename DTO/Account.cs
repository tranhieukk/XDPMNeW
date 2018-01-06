using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Account
    {
        private string userName;
        private string displayName;
        private string password;
        private int type;        
        private bool trangThai;

        public Account(string userName, string displayName, int type, string password = null,bool trangThai=false)
        {
            this.UserName = userName;
            this.DisplayName = displayName;
            this.Type = type;
            this.Password = password;
            this.TrangThai = trangThai;
        }

        public Account(DataRow row)
        {
            this.UserName = row["userName"].ToString();
            this.DisplayName = row["displayName"].ToString();
            
        }

      
        public int Type
        {
            get { return type; }
            set { type = value; }
        }

        

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
      

        public string DisplayName
        {
            get { return displayName; }
            set { displayName = value; }
        }
      

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }
       
        public bool TrangThai { get => trangThai; set => trangThai = value; }


    }
}

