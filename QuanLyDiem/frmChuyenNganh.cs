using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BUS;
using DTO;

namespace QuanLyDiem
{
    public partial class frmChuyenNganh : Form
    {
        private static string maNganhHientai;
        public frmChuyenNganh()
        {
            InitializeComponent();
            loadKhoa();
            loadChuyenNganh();
        }
        void loadKhoa()
        {
            cbKhoa.DataSource =  KhoaDAO.Instance.SelectAll();
            cbKhoa.DisplayMember = "TenKhoa";
            cbKhoa.ValueMember = "MaKhoa";
        }
        void loadChuyenNganh()
        {
            gvChuyenNganh.DataSource = ChuyenNganhDAO.Instance.SelectAllData();
        }
        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ChuyenNganhDAO.Instance.Insert(new DTO.ChuyenNganh(txtMaNganh.Text, txtTenNganh.Text, cbKhoa.SelectedValue.ToString()));
            loadChuyenNganh();
            clear();

        }

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ChuyenNganhDAO.Instance.Update(new ChuyenNganh(txtMaNganh.Text, txtTenNganh.Text, cbKhoa.SelectedValue.ToString()), maNganhHientai);
            loadChuyenNganh();
            clear();

        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ChuyenNganhDAO.Instance.Remove(new DTO.ChuyenNganh(txtMaNganh.Text, txtTenNganh.Text, cbKhoa.SelectedValue.ToString()));
            loadChuyenNganh();
            clear();

        }
        void clear()
        {
            txtMaNganh.Text = "";
            txtTenNganh.Text = "";
            cbKhoa.SelectedIndex = -1;
          
        }

        private void btnReset_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            clear();
        }

        private void gvChuyenNganh_Click(object sender, EventArgs e)
        {

            foreach (int i in gridView1.GetSelectedRows())
            {
                DataRow row = gridView1.GetDataRow(i);
                txtMaNganh.Text = Convert.ToString(row[0]);
                txtTenNganh.Text = Convert.ToString(row[1]);
                cbKhoa.SelectedIndex =cbKhoa.FindString( Convert.ToString(row[2]));

            }


            maNganhHientai = txtMaNganh.Text;
        }
    }
}
