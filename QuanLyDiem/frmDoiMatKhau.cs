using BUS;
using DevExpress.XtraEditors;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDiem
{
    public partial class frmDoiMatKhau : Form
    {
        Account account =AccountDAO.Instance.GetAccountByUserName(Program.Username);

        public frmDoiMatKhau()
        {
            InitializeComponent();
            showData();
        }
        void showData()
        {
            txtUsername.Text = account.UserName;
            txtDisplayname.Text = account.DisplayName;
            
        }
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            txtconfirm.Text = "";
            txtcurrentpass.Text = "";
            txtnewpass.Text = "";
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if(txtnewpass.Text.Length > 0)
            {
                if (txtnewpass.Text.Equals(txtconfirm.Text))
                {
                    if (txtcurrentpass.Text.Length == 0)
                    {
                        XtraMessageBox.Show("Vui lòng nhập mật khẩu hiện tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (AccountDAO.Instance.UpdateAccount(txtUsername.Text, txtDisplayname.Text, txtcurrentpass.Text, txtnewpass.Text))
                        {
                            XtraMessageBox.Show("Cập nhật thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            XtraMessageBox.Show("Cập nhật không thành công! vui lòng nhập đúng mật khẩu hiện tại ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                } else
            {
                XtraMessageBox.Show("Mật khẩu mới không trùng khớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            }
           
        }
    }
}
