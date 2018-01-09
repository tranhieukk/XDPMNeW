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

namespace QuanLyDiem.Reports
{
    public partial class ReportMonHoccs : Form
    {
        bool check=false;
        string tenLop, tenKhoa,malop;
        public ReportMonHoccs()
        {
            InitializeComponent();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (check)
            {
                using (frmPrint frm = new frmPrint())
                {
                    frm.printDSMonHoc(tenLop, tenKhoa, MonHocDAO.Instance.SelectByLop(malop));
                    frm.ShowDialog();
                }
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (LopDAO.Instance.IsExist(tedMaLop.Text))
            {
                tenLop = LopDAO.Instance.GetName(tedMaLop.Text);
                tenKhoa= KhoaDAO.Instance.SelectbyMaLop(tedMaLop.Text);
                malop = tedMaLop.Text;
                gridControl1.DataSource = MonHocDAO.Instance.SelectByLop(tedMaLop.Text);
                check = true;
            }
            else
            {
                check = false;
            }
        }
    }
}
