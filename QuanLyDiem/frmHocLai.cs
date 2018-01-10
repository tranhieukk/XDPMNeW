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
    public partial class frmHocLai : Form
    {
        public frmHocLai()
        {
            InitializeComponent();
        }
        void loadDSHocLai()
        {
            gridControl1.DataSource = DiemMonHocDAO.Instance.GetTableSVHocLai();
        }
        private void TimkiemKhiEnter(object sender, KeyEventArgs e)
        {
            int type=0;
            if (rdTuongDoi.Checked) type=1;
            if (e.KeyCode == Keys.Enter)
            {
               gridControl1.DataSource= DiemMonHocDAO.Instance.GetTableSVHocLaiTheoKhoa(txeMaKhoa.Text, type);
            }
        }

        private void TimKiemByMaLop(object sender, KeyEventArgs e)
        {
            int type=0;
            if (rdTuongDoi.Checked) type=1;
            if (e.KeyCode == Keys.Enter)
            {
                gridControl1.DataSource = DiemMonHocDAO.Instance.GetTableSVHocLaiTheoLop(txeMaLop.Text, type);
            }
        }

        private void TimkiemtheoSV(object sender, KeyEventArgs e)
        {
            int type=0;
            if (rdTuongDoi.Checked) type=1;
            if (e.KeyCode == Keys.Enter)
            {
                gridControl1.DataSource = DiemMonHocDAO.Instance.GetTableSVHocLaiTheoMaSV(txeMaSV.Text, type);
            }
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
