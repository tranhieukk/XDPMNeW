using BUS;
using DevExpress.XtraGrid.Views.Grid;
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
            gridView1.CustomDrawRowIndicator += gridView1_CustomDrawRowIndicator;

            loadTieuChirenLuyen();
        }
        void gridView1_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator)
            {
                if (e.RowHandle < 0)
                {
                    e.Info.ImageIndex = 0;
                    e.Info.DisplayText = String.Empty;
                }
                else
                {
                    e.Info.ImageIndex = -1;
                    e.Info.DisplayText = (e.RowHandle + 1).ToString();
                }
                SizeF sizeF = e.Graphics.MeasureString(e.Info.DisplayText, e.Appearance.Font);
                Int32 width = Convert.ToInt32(sizeF.Width) + 10;
                BeginInvoke(new MethodInvoker(delegate { cal(width, gridView1); }));
            }

        }
        bool cal(Int32 width, GridView _View)
        {
            _View.IndicatorWidth = _View.IndicatorWidth < width ? width : _View.IndicatorWidth;
            return true;
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
