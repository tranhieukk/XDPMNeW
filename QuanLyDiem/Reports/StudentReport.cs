using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
namespace QuanLyDiem.Reports
{
    public partial class StudentReport : Form
    {
        bool check = false;
        public StudentReport()
        {
            InitializeComponent();
        }
        static string Lop, MaLop, Khoa;
        List<Student> std;
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (LopDAO.Instance.IsExist(txEMaLop.Text))
            {
                MaLop = txEMaLop.Text;
                Khoa = KhoaDAO.Instance.SelectbyMaLop(MaLop);
                Lop = LopDAO.Instance.GetName(MaLop);
                lbTitle.Text = "Danh sách sinh viên lớp " +Lop;
                studentBindingSource1.DataSource = SinhVienDAO.Instance.SelectByLop(MaLop);
                check = true;
            }
            else
            {
                check = false;
                lbTitle.Text = "";
            }

        }

        private void btnXBC_Click(object sender, EventArgs e)
        {
            if (check)
            {
                using (frmPrint frm = new frmPrint())
                {
                    frm.printDSSVLop(Lop, Khoa, SinhVienDAO.Instance.GetListSV(MaLop));
                    frm.ShowDialog();
                }
            }

        }
    }
}
