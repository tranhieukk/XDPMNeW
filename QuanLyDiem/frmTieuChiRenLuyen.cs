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
    public partial class frmTieuChiRenLuyen : Form
    {
        private static string maTieuChiOLD = "";
        public frmTieuChiRenLuyen()
        {
            InitializeComponent();
            loadTieuChirenLuyen();
        }
       void loadTieuChirenLuyen()
        {
            gvTieuChiRenLuyen.DataSource = TieuChiRenLuyenDAO.Instance.SelectAll();
        }
        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            TieuChiRenLuyen tieuchi = new TieuChiRenLuyen(txtMaTieuChi.Text,txtTenTieuChi.Text,txtMucDiem.Text);

            if (TieuChiRenLuyenDAO.Instance.Insert(tieuchi) > 0)
            {
                loadTieuChirenLuyen(); 

            }
        }

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            TieuChiRenLuyen tieuchi = new TieuChiRenLuyen(txtMaTieuChi.Text, txtTenTieuChi.Text, txtMucDiem.Text);

            if (TieuChiRenLuyenDAO.Instance.Update(maTieuChiOLD,tieuchi) > 0)
            {
                loadTieuChirenLuyen();
            }
        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            TieuChiRenLuyen tieuchi = new TieuChiRenLuyen(txtMaTieuChi.Text, txtTenTieuChi.Text, txtMucDiem.Text);

            if (TieuChiRenLuyenDAO.Instance.Remove(tieuchi) > 0)
            {
                loadTieuChirenLuyen();
            }
        }
        void clear()
        {
            txtMaTieuChi.Text = "";
            txtTenTieuChi.Text = "";
            txtMucDiem.Text = "";
        }

        private void btnReset_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            clear();
        }

        private void gvTieuChiRenLuyen_Click(object sender, EventArgs e)
        {
            foreach (int i in gridView1.GetSelectedRows())
            {
                DataRow row = gridView1.GetDataRow(i);
                txtMaTieuChi.Text = Convert.ToString(row[0]);
                txtTenTieuChi.Text = Convert.ToString(row[1]);
                txtMucDiem.Text = Convert.ToString(row[2]);

            }


            maTieuChiOLD = txtMaTieuChi.Text;
        }
    }
}
