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
using DTO;
using BUS;
using DevExpress.XtraGrid.Views.Grid;

namespace QuanLyDiem
{
    public partial class frmLop : DevExpress.XtraEditors.XtraForm
    {
        private static Lop lop;
        private static string malopOld;
        public frmLop()
        {
            InitializeComponent();
            gridView1.CustomDrawRowIndicator += gridView1_CustomDrawRowIndicator;
            loadKhoa();
            loadLop();
            loadhedaotao();
            loadNganhDaoTao();
            loadKhoaHoc();


            clear();

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
        void loadKhoa()
        {
            List<Khoa> data = KhoaDAO.Instance.loadAllKhoa();
            cbbkhoa.DataSource = data;
            cbbkhoa.DisplayMember = "TenKhoa";
            cbbkhoa.ValueMember = "MaKhoa";
        }
        void loadhedaotao()
        {
            List<HeDaoTao> data = HeDaoTaoDAO.Instance.GetListHeDaoTao();
            cbbHeDaoTao.DataSource = data;
            cbbHeDaoTao.DisplayMember = "TenHe";
            cbbHeDaoTao.ValueMember = "MaHe";
        }
        void loadNganhDaoTao()
        {
            List<ChuyenNganh> data = ChuyenNganhDAO.Instance.GetAllData();
            cbbnganhhoc.DataSource = data;
            cbbnganhhoc.DisplayMember = "TenNganh";
            cbbnganhhoc.ValueMember = "MaNganh";
        }
        void loadKhoaHoc()
        {
            cbbKhoaHoc.DataSource = KhoaHocDAO.Instance.getAllData();
            cbbKhoaHoc.DisplayMember = "TenKhoaHoc";
            cbbKhoaHoc.ValueMember = "MaKhoaHoc";

        }
        void loadLop()
        {
             grvLop.DataSource = LopDAO.Instance.getAllData();
            

        }
        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {if (txEMaLop.Text.Length < 1 || txeTenLop.Text.Length < 1) {
                XtraMessageBox.Show("Bạn chưa nhập thông tin để thêm lớp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                lop = new Lop();
                lop.MaLop = txEMaLop.Text;
                lop.TenLop = txeTenLop.Text;
                lop.MaNganh = cbbnganhhoc.SelectedValue.ToString();
                lop.MaHeDaoTao = cbbHeDaoTao.SelectedValue.ToString();
                lop.MaKhoaHoc = cbbKhoaHoc.SelectedValue.ToString();
                try
                {
                    if (LopDAO.Instance.addLop(lop) > 0)
                    {
                        loadLop();
                        clear();
                        lbThongBao.Text = "Thông báo: Thêm thành công lớp: " + lop.TenLop;
                    }
                    else
                    {
                        lbThongBao.Text = "Thông báo: Lỗi khi thêm  lớp: " + lop.TenLop;
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }

            }

        }

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txEMaLop.Text.Length < 1 || txeTenLop.Text.Length < 1)
            {
                XtraMessageBox.Show("Bạn chưa nhập đủ thông tin để chỉnh sửa lớp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                lop = new Lop();
                lop.MaLop = txEMaLop.Text;
                lop.TenLop = txeTenLop.Text;
                lop.MaNganh = cbbnganhhoc.SelectedValue.ToString();
                lop.MaHeDaoTao = cbbHeDaoTao.SelectedValue.ToString();
                lop.MaKhoaHoc = cbbKhoaHoc.SelectedValue.ToString();
                try
                {
                    if (LopDAO.Instance.editLop(lop, malopOld) > 0)
                    {
                        loadLop();
                        clear();
                        lbThongBao.Text = "Thông báo: Cập nhật thành công lớp: " + lop.TenLop;
                    }
                    else
                    {
                        lbThongBao.Text = "Thông báo: Lỗi khi cập nhật lớp: " + lop.TenLop;
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txEMaLop.Text.Length < 1)
            {
                XtraMessageBox.Show("Bạn chưa chọn lớp để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult dlr;
                dlr = XtraMessageBox.Show("Bạn có muốn xóa lớp " + txeTenLop.Text + "?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlr == DialogResult.Yes)
                {
                    LopDAO.Instance.removeLop(txEMaLop.Text);
                    lbThongBao.Text = "Thông báo: Đã xóa lớp: " + lop.TenLop;
                    loadLop();
                    // unbinding();
                    //  binding();


                }
            }
        }
        void clear()
        {
            txEMaLop.Text = "";
            txeTenLop.Text = "";
            cbbHeDaoTao.SelectedIndex = -1;
            cbbkhoa.SelectedIndex = -1;
            cbbKhoaHoc.SelectedIndex = -1;
            cbbnganhhoc.SelectedIndex = -1;
        }
        private void btnReset_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            clear();
            
        }



        private void grvLop_Click(object sender, EventArgs e)
        {
            
                        foreach (int i in gridView1.GetSelectedRows())
                        {
                            DataRow row = gridView1.GetDataRow(i);
                            txEMaLop.Text = Convert.ToString(row[0]);
                            txeTenLop.Text = Convert.ToString(row[1]);
                            cbbkhoa.SelectedIndex = cbbkhoa.FindString(Convert.ToString(row[2]));
                            cbbnganhhoc.SelectedIndex = cbbnganhhoc.FindString(Convert.ToString(row[3]));
                            cbbHeDaoTao.SelectedIndex = cbbHeDaoTao.FindString(Convert.ToString(row[4]));
                            cbbKhoaHoc.SelectedIndex = cbbKhoaHoc.FindString(Convert.ToString(row[5]));
                        }
            
         
            malopOld = txEMaLop.Text;
        }
      /*  void unbinding()
        {
            txEMaLop.DataBindings.Clear();
            txeTenLop.DataBindings.Clear();
            cbbkhoa.DataBindings.Clear();
            cbbnganhhoc.DataBindings.Clear();
            cbbHeDaoTao.DataBindings.Clear();
            cbbKhoaHoc.DataBindings.Clear();

        }
        void binding()
        {

            txEMaLop.DataBindings.Add("Text", gridView1.DataSource, "Mã lớp");
            txeTenLop.DataBindings.Add("Text", gridView1.DataSource, "Tên lớp");
            cbbkhoa.DataBindings.Add("Text", gridView1.DataSource, "Khoa");
            cbbnganhhoc.DataBindings.Add("Text", gridView1.DataSource, "Chuyên ngành");
            cbbHeDaoTao.DataBindings.Add("Text", gridView1.DataSource, "Hệ đào tạo");
            cbbKhoaHoc.DataBindings.Add("Text", gridView1.DataSource, "Khóa học");


        }*/

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

        }
    }
}
