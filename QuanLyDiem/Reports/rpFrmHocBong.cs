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

namespace QuanLyDiem.Reports
{
    public partial class rpFrmHocBong : Form
    {
        private static string maHKy,maKhoa,tenKhoa;
        public rpFrmHocBong()
        {
            InitializeComponent();
            loadKhoa();
        }
        void loadKhoa()
        {
            cbbKhoa.DataSource = KhoaDAO.Instance.SelectAll();
            cbbKhoa.DisplayMember = "TenKhoa";
            cbbKhoa.ValueMember = "MaKhoa";
        }
        private void btnLoadData_Click(object sender, EventArgs e)
        {
            gridControl1.DataSource = DiemMonHocDAO.Instance.GetTableHBSV(txeMaHocKy.Text,cbbKhoa.SelectedValue.ToString());
            maHKy = txeMaHocKy.Text;
            maKhoa = cbbKhoa.SelectedValue.ToString();
            tenKhoa = KhoaDAO.Instance.GetName(maKhoa);
        }

        private void btnprinter_Click(object sender, EventArgs e)
        {
            if (gridControl1.DataSource != null)
            {
                using (frmPrint frm = new frmPrint())
                {
                    rpThongTin rp = ThongTinDAO.Instance.getThongTinNamHoc(maHKy);
                   
                    frm.printDHB(tenKhoa,rp , DiemMonHocDAO.Instance.GetListHBSV(maHKy, maKhoa));
                    frm.ShowDialog();
                }
            }
        }
    }
}
