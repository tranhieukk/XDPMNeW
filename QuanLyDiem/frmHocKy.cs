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
    public partial class frmHocKy : Form
    {
        private static string  maHocKyOld;
        public frmHocKy()
        {
            InitializeComponent();
            loadHocKy();
        }
        void loadHocKy()
        {
            gvHocKy.DataSource = HocKyDAO.Instance.loadAllHocky();
        }
        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HocKy hocKy = new HocKy(txtMaHocKy.Text, txtTenHocKy.Text);
            HocKyDAO.Instance.Insert(hocKy);
            loadHocKy();
        }

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HocKy hocKy = new HocKy(txtMaHocKy.Text, txtTenHocKy.Text);
            HocKyDAO.Instance.Update(maHocKyOld,hocKy);
            loadHocKy();
        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HocKy hocKy = new HocKy(txtMaHocKy.Text, txtTenHocKy.Text);
            HocKyDAO.Instance.Remove(hocKy);
            loadHocKy();
        }
        void clear()
        {
            txtMaHocKy.Text = "";
            txtTenHocKy.Text = "";
        }

        private void btnReset_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            clear();
        }

        private void gvHocKy_Click(object sender, EventArgs e)
        {
            foreach (int i in gridView1.GetSelectedRows())
            {
                DataRow row = gridView1.GetDataRow(i);
                txtMaHocKy.Text = Convert.ToString(row[0]);
                txtTenHocKy.Text = Convert.ToString(row[1]);
               
            }


            maHocKyOld = txtMaHocKy.Text;
        }
    }
}
