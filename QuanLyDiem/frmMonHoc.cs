using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BUS;
using DTO;
using DevExpress.XtraGrid.Views.Grid;

namespace QuanLyDiem
{
    public partial class frmMonHoc : DevExpress.XtraEditors.XtraForm
    {
        string maMHHT=null;
        public frmMonHoc()
        {
            InitializeComponent();
            loadMonHoc();
            gridView1.CustomDrawRowIndicator += gridView1_CustomDrawRowIndicator;

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
        void loadMonHoc()
        {
            gridMonHoc.DataSource = MonHocDAO.Instance.SelectAll();

        }
        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMaMon.Text.Length < 1 || txtTenMon.Text.Length < 1 || txtSoDVHT.Text.Length < 1)
            {
                XtraMessageBox.Show("Bạn chưa nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MonHoc mH = new MonHoc();
                mH.MaMH = txtMaMon.Text;
                mH.TenMH = txtTenMon.Text;
                mH.SoHocPhan = int.Parse(txtSoDVHT.Text);
              if(MonHocDAO.Instance.Insert(mH) > 0) {
                lbThongBao.Text = "Thông báo: Đã thêm thành công môn học " + mH.TenMH;
                    clear();
                    loadMonHoc(); }
              else
                    lbThongBao.Text = "Thông báo: Thêm môn học không thành công. " + mH.TenMH;
            }
        }

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMaMon.Text.Length < 1 || txtTenMon.Text.Length < 1 || txtSoDVHT.Text.Length < 1)
            {
                XtraMessageBox.Show("Bạn chưa nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            else
            {
                MonHoc mH = new MonHoc();
                mH.MaMH = txtMaMon.Text;
                mH.TenMH = txtTenMon.Text;
                mH.SoHocPhan = int.Parse(txtSoDVHT.Text);
                if (MonHocDAO.Instance.Update(mH, maMHHT) > 0)
                {
                    lbThongBao.Text = "Thông báo: Đã cập nhật thành công môn học " + mH.TenMH;
                    clear();
                    loadMonHoc();
                }
                else
                    lbThongBao.Text = "Thông báo: Đã cập nhật  môn học không thành công. " + mH.TenMH;
            }
        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMaMon.Text.Length < 1 || txtTenMon.Text.Length < 1 || txtSoDVHT.Text.Length < 1 || maMHHT.Length<1)
            {
                XtraMessageBox.Show("Bạn chưa chọn môn học cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MonHoc mH = new MonHoc();
                mH.MaMH = txtMaMon.Text;
                mH.TenMH = txtTenMon.Text;
                if (MonHocDAO.Instance.Remove(mH) > 0)
                {
                    lbThongBao.Text = "Thông báo: Đã xóa thành công môn học " + mH.TenMH;
                    clear();
                    loadMonHoc();
                }
                else
                    lbThongBao.Text = "Thông báo: Không thể xóa môn học " + mH.TenMH;
            }
        }

        private void gridMonHoc_Click(object sender, EventArgs e)
        {
            foreach (int i in gridView1.GetSelectedRows())
            {
                DataRow row = gridView1.GetDataRow(i);
                txtMaMon.Text = Convert.ToString(row[0]);
                txtTenMon.Text = Convert.ToString(row[1]);
                txtSoDVHT.Text = Convert.ToString(row[2]);

            }


            maMHHT = txtMaMon.Text;
        }

        private void Search(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                gridMonHoc.DataSource = MonHocDAO.Instance.Find(txtMaMon.Text, txtTenMon.Text, txtSoDVHT.Text);
            }
        }
        void clear()
        {
txtMaMon.Text = "";
            txtSoDVHT.Text = "";
            txtTenMon.Text = "";
        }

        private void btnReset_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            clear();
        }
    }
}