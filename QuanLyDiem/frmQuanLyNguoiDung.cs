using BUS;
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
    public partial class frmQuanLyNguoiDung : Form
    {
        QuanLyAccount quanLy = new QuanLyAccount();
        string maquyenOld,maquyenNew, username;
        public frmQuanLyNguoiDung()
        {
            InitializeComponent();
            loadAccount();
        }
        void loadAccount()
        {
            gridControl1.DataSource = QuanLyAccountDAO.Instance.SelectAll();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (rDaoTao.Checked)
                maquyenNew = "1";
            if (rdBanKhaoThi.Checked)
                maquyenNew = "3";
            if (rquantri.Checked)
                maquyenNew = "4";
            if (rdQlSV.Checked)
                maquyenNew = "2";
            QuanLyAccountDAO.Instance.Update(maquyenOld, maquyenNew, quanLy.username);
            loadAccount();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (rDaoTao.Checked)
                maquyenNew = "1";
            if (rdBanKhaoThi.Checked)
                maquyenNew = "3";
            if (rquantri.Checked)
                maquyenNew = "4";
            if (rdQlSV.Checked)
                maquyenNew = "2";
            QuanLyAccountDAO.Instance.Insert(txtname.Text, texdisplayname.Text, txtpass.Text, maquyenNew);
            loadAccount();
            txtname.Text = "";
            txtpass.Text = "";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (rDaoTao.Checked)
                maquyenNew = "1";
            if (rdBanKhaoThi.Checked)
                maquyenNew = "3";
            if (rquantri.Checked)
                maquyenNew = "4";
            if (rdQlSV.Checked)
                maquyenNew = "2";
            QuanLyAccountDAO.Instance.Remove(quanLy.username, maquyenNew);
            loadAccount();
            txtname.Text = "";
            txtpass.Text = "";
            texdisplayname.Text = "";
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            foreach (int i in gridView1.GetSelectedRows())
            {
                DataRow row = gridView1.GetDataRow(i);
                quanLy.username = Convert.ToString(row[0]);                
                quanLy.displayname = Convert.ToString(row[1]);
                quanLy.quyen = Convert.ToString(row[2]);
               
            }
            txtname.Text = quanLy.username;
            texdisplayname.Text = quanLy.displayname;
            if (quanLy.quyen.Equals("Khảo thí"))
            {
                rdBanKhaoThi.Checked = true;
                maquyenOld = "3";
            }
            if (quanLy.quyen.Equals("Quản lý sinh viên"))
            {
                rdQlSV.Checked = true;
                maquyenOld = "2";

            }
            if (quanLy.quyen.Equals("Quản lý đào tạo"))
            {
                rDaoTao.Checked = true;
                maquyenOld = "1";

            }
            if (quanLy.quyen.Equals("Quản trị"))
            {
                rquantri.Checked = true;
                maquyenOld = "4";

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {  
        }
    }
}
