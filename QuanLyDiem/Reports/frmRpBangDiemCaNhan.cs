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
    public partial class frmRpBangDiemCaNhan : Form
    {
        bool check = false;
        string masv = "";
        public frmRpBangDiemCaNhan()
        {
            InitializeComponent();
        }

        private void onEnter(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (SinhVienDAO.Instance.IsExist(txtMsv.Text)){
                    masv = txtMsv.Text;
                    gridControl1.DataSource = DiemMonHocDAO.Instance.GetTableDiemSV(masv);
                    check = true;
                }
                else
                {
                    check = false;
                    masv = "";
                }
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (check)
            {
                using (frmPrint frm = new frmPrint())
                {
                    frm.printDSDiemCaNhan(SinhVienDAO.Instance.GetStudentDetail(masv),DiemMonHocDAO.Instance.GetListDiemSV(masv));
                    frm.ShowDialog();
                }
            }
        }
    }
}
