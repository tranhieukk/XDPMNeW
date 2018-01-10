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

namespace QuanLyDiem
{
    public partial class frmThiLai : Form
    {
        public frmThiLai()
        {
            InitializeComponent();
            loadDSThiLai();
        }
        void loadDSThiLai()
        {
            gridControl1.DataSource = DiemMonHocDAO.Instance.GetTableSVThiLai();
        }
        private void TimkiemKhiEnter(object sender, KeyEventArgs e)
        {
            int type = 0;
            if (rdTuongDoi.Checked) type = 1;
            if (e.KeyCode == Keys.Enter)
            {
                gridControl1.DataSource = DiemMonHocDAO.Instance.GetTableSVThiLaiTheoKhoa(txtMaKhoa.Text, type);
            }
        }

        private void TimKiemByMaLop(object sender, KeyEventArgs e)
        {
            int type = 0;
            if (rdTuongDoi.Checked) type = 1;
            if (e.KeyCode == Keys.Enter)
            {
                gridControl1.DataSource = DiemMonHocDAO.Instance.GetTableSVThiLaiTheoLop(txtMaLop.Text, type);
            }
        }

        private void TimkiemtheoSV(object sender, KeyEventArgs e)
        {
            int type = 0;
            if (rdTuongDoi.Checked) type = 1;
            if (e.KeyCode == Keys.Enter)
            {
                gridControl1.DataSource = DiemMonHocDAO.Instance.GetTableSVThiLaiTheoMaSV(txtMasv.Text, type);
            }
        }
        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
