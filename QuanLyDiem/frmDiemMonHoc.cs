using BUS;
using DevExpress.XtraEditors;
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
    public partial class frmDiemMonHoc : Form
    {
        private static float MaxDiem = float.Parse(ThamSoDAO.Instance.GetGiaTriThamSo("THD"));
        private static DiemMonHoc diemMonHoc = new DiemMonHoc();
        public frmDiemMonHoc()
        {
            InitializeComponent();
            loadDataToCombobox();
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

        private void loadDataToCombobox()
        {

            cbHocKy.DataSource = HocKyDAO.Instance.loadAllHocky();
            cbHocKy.DisplayMember = "Tên học kỳ";
            cbHocKy.ValueMember = "Mã học kỳ";


        }
        void clear()
        {

            txbTX.Enabled = false;
            txb15.Enabled = false;
            txbGK.Enabled = false;
            txbCK.Enabled = false;
            txbTL.Enabled = false;
            txEMsv.Text = "";
            txbTX.Text = "";
            txb15.Text = "";
            txbGK.Text = "";
            txbCK.Text = "";
            txbTL.Text = "";
        }
        private void btnChamDiem_Click(object sender, EventArgs e)
        {
            if (diemMonHoc.IsGood())
            {
                DiemMonHocDAO.Instance.ChamDiem(diemMonHoc);
                clear();
                LoadView();
            }


        }
        private void LoadView()
        {
            gvDSLop.DataSource = DiemMonHocDAO.Instance.SelectDiemByLop(cbHocKy.SelectedValue.ToString(), txbMaMon.Text, txbmaLop.Text);
        }


        private void FinishTyping(object sender, KeyEventArgs e)
        {
            TextBox tb = (TextBox)sender;

            if (e.KeyCode == Keys.Tab || e.KeyCode == Keys.Enter)
            {
                float n;
                bool isNumeric = float.TryParse(tb.Text, out n);
                if (isNumeric)
                {

                    if (tb.Name == "tbxTX") diemMonHoc.DiemTX = n.ToString();
                    if (tb.Name == "tbx15") diemMonHoc.Diem15p = n.ToString();
                    if (tb.Name == "tbxGK") diemMonHoc.DiemGK = n.ToString();
                    if (tb.Name == "tbxCK") diemMonHoc.DiemCK1 = n.ToString();
                    if (tb.Name == "tbxTK") diemMonHoc.DiemCK2 = n.ToString();
                }
                if (tb.Name == "txbMaMon")
                {
                    if (MonHocDAO.Instance.IsExist(txbMaMon.Text))
                    {
                        diemMonHoc.MaMonHoc = txbMaMon.Text;
                        txbmaLop.Enabled = true;

                    }
                    else
                    {
                        XtraMessageBox.Show("Mã môn không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                if (tb.Name == "txEMsv")
                {
                    if (SinhVienDAO.Instance.IsExist(txEMsv.Text))
                    {
                        diemMonHoc.MaSinhVien = txEMsv.Text;
                    }
                    else
                    {
                        XtraMessageBox.Show("Mã sinh viên không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                if (tb.Name == "txbmaLop")
                {
                    if (LopDAO.Instance.IsExist(txbmaLop.Text))
                    {
                        checkKhoiTao();
                        txEMsv.Enabled = true;
                    }
                    else
                    {
                        XtraMessageBox.Show("Mã Lớp không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }



            }
        }

        private void addMaHocKy(object sender, EventArgs e)
        {
            diemMonHoc.MaHocKy = cbHocKy.SelectedValue.ToString();
        }


        void checkKhoiTao()
        {
            if (!DiemMonHocDAO.Instance.IsCreate(cbHocKy.SelectedValue.ToString(), txbmaLop.Text, txbMaMon.Text))
            {
                DialogResult dlr;
                dlr = XtraMessageBox.Show("Chưa tạo bảng điểm môn học. Chọn Yes để đồng ý tạo bảng điểm, No để thoát", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlr == DialogResult.Yes)
                {
                    int dem = DiemMonHocDAO.Instance.Create(cbHocKy.SelectedValue.ToString(), txbmaLop.Text, txbMaMon.Text);
                    if (dem > 0)
                    {
                        XtraMessageBox.Show("Đã tạo bảng điểm cho " + dem + " sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }

            }
            LoadView();
        }

        private void gvDSLop_Click(object sender, EventArgs e)
        {
            txbTX.Enabled = true;
            txb15.Enabled = true;
            txbGK.Enabled = true;
            txbCK.Enabled = true;
            txbTL.Enabled = true;
            foreach (int i in gridView1.GetSelectedRows())
            {
                DataRow row = gridView1.GetDataRow(i);
                txEMsv.Text = Convert.ToString(row[0]);
                txbTX.Text = Convert.ToString(row[2]);
                txb15.Text = Convert.ToString(row[3]);
                txbGK.Text = Convert.ToString(row[4]);
                txbCK.Text = Convert.ToString(row[5]);
                txbTL.Text = Convert.ToString(row[6]);

            }
        }

        string diemso(string num)
        {

            float n;
            bool isNumeric = float.TryParse(num, out n);
            if (isNumeric)
            {
                return n.ToString();
            }
            return "";
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            diemMonHoc.MaHocKy = cbHocKy.SelectedValue.ToString();
            diemMonHoc.MaMonHoc = txbMaMon.Text;
            

            for (int n = 0; n < gridView1.RowCount - 1; n++)
            {

                diemMonHoc.MaSinhVien = gridView1.GetRowCellValue(n, "Mã sinh viên").ToString();
                diemMonHoc.DiemTX = diemso(gridView1.GetRowCellValue(n, "Thường xuyên").ToString());
                diemMonHoc.Diem15p = diemso(gridView1.GetRowCellValue(n, "15 phút").ToString());
                diemMonHoc.DiemGK = diemso(gridView1.GetRowCellValue(n, "Giữa kỳ").ToString());
                diemMonHoc.DiemCK1 = diemso(gridView1.GetRowCellValue(n, "Cuối kỳ").ToString());
                diemMonHoc.DiemCK2 = diemso(gridView1.GetRowCellValue(n, "Thi lại").ToString());
                if (diemMonHoc.IsGood())
                {
                    DiemMonHocDAO.Instance.ChamDiem(diemMonHoc);
                }
            }



        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            DialogResult dlr;
            dlr = XtraMessageBox.Show("Thao tác này sẽ hủy bỏ các số liệu vừa nhập", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {

                LoadView();
            }

        }
    }
}

