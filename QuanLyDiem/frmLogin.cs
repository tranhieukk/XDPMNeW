using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BUS;
using DTO;
namespace QuanLyDiem
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void hLDangky_Click(object sender, EventArgs e)
        {
            frmRegister frm = new frmRegister();
            frm.Show();

        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txbUserName.Text;
            string passWord = txbPassword.Text;
            if (Login(userName, passWord))
            {
                 Account account = AccountDAO.Instance.GetAccountByUserName(userName);
                Program.Username = account.UserName;
                DataTable tablePermision = QuyenHanDAO.Instance.SelectAllPermisionForAccount(account);
                foreach(DataRow permision in tablePermision.Rows)
                {
                    ChiTietQuyenHan item = new ChiTietQuyenHan(permision);
                    Program.ListPermision.Add(item);
                }

                frmMenu f = new frmMenu();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                DialogResult dlr;
                dlr = XtraMessageBox.Show("Tài khoản hoặc mật khẩu không đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                
            }
        }

        bool Login(string userName, string passWord)
        {
            return AccountDAO.Instance.Login(userName, passWord);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            try { Application.Exit(); }
            catch (Exception ex)
            {
                throw ex;
            }

        }

      
    }
}