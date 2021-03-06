﻿using BUS;
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
    public partial class frmDiemRenLuyen : Form
    {
        private static int maxDiem=0; 
        private static DiemRenLuyen diemRenLuyen;
        public frmDiemRenLuyen()
        {
            InitializeComponent();
            gridView1.CustomDrawRowIndicator += gridView1_CustomDrawRowIndicator;
            gridView2.CustomDrawRowIndicator += gridView1_CustomDrawRowIndicator;
            loadComboxOption();
            loadOption2();
            show();

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
        void show()
        {
            int dem = 0;

            if (txtMaHocKy.Text.Length == 0)
            {
                txtMaSV.Enabled = false;
            }
            if (txtMaHocKy.Text.Length > 0)
            {
                dem = HocKyDAO.Instance.SoLuong(new HocKy(txtMaHocKy.Text, ""));
                if (dem == 0) txtMaSV.Enabled = false;
                else txtMaSV.Enabled = true;
            }

            if (txtMaSV.Enabled == false)
            {
                txtMaTieuChi.Enabled = false;
            }
            else
            {
                if (txtMaSV.Text.Length > 0)
                {
                    if (SinhVienDAO.Instance.IsExist(txtMaSV.Text)) txtMaTieuChi.Enabled = true;
                }

            }
            if (txtMaTieuChi.Enabled == false)
            {
                txtTuCham.Enabled = false;
                txtLopTruong.Enabled = false;
                txtGVCN.Enabled = false;
                txbKhoacham.Enabled = false;
            }
            else
            {
                if (txtMaTieuChi.Text.Length > 0)
                {
                    if (TieuChiRenLuyenDAO.Instance.IsExist(txtMaTieuChi.Text))
                    {
                        txtTuCham.Enabled = true;
                        txtLopTruong.Enabled = true;
                        txtGVCN.Enabled = true;
                        txbKhoacham.Enabled = true;
                    }
                }

            }
        }
        int getDiemFromTexbox(string s)
        {
            int n;
            if (int.TryParse(s, out n))
                return n;
            return 0;
           

        }
        void addToObject()
        {
            
            int max = TieuChiRenLuyenDAO.Instance.MaxDiem(txtMaTieuChi.Text);
            diemRenLuyen = new DiemRenLuyen();
            diemRenLuyen.MaHocKy = txtMaHocKy.Text;
            diemRenLuyen.MaSinhVien = txtMaSV.Text;
            diemRenLuyen.MaTieuChi = txtMaTieuChi.Text;
          
            diemRenLuyen.Tucham = getDiemFromTexbox(txtTuCham.Text);
            diemRenLuyen.Loptruong = getDiemFromTexbox(txtLopTruong.Text);
            diemRenLuyen.Gvcn = getDiemFromTexbox(txtGVCN.Text);
            diemRenLuyen.Khoa = getDiemFromTexbox(txbKhoacham.Text);
            diemRenLuyen.Good(max);
        }
        void loadComboxOption()
        {
            Dictionary<string, string> GT = new Dictionary<string, string>();
            GT.Add("1", "Chưa chấm một trong 4 cột");
            GT.Add("2", "Lớp trưởng chưa chấm");
            GT.Add("3", "Sinh viên chưa tự chấm");
            GT.Add("4", "GVCN chưa chấm");
            GT.Add("5", "Khoa chưa chấm");

            cbbOption.DataSource = new BindingSource(GT, null);
            cbbOption.DisplayMember = "Value";
            cbbOption.ValueMember = "Key";

        }
        void loadOption2()
        {
            Dictionary<string, string> GT = new Dictionary<string, string>();
            GT.Add("0", "Tất cả sinh viên");
            GT.Add("1", "Sinh viên của lớp");
            GT.Add("2", "Sinh viên của khoa");


            cbbOptionViewDSSV.DataSource = new BindingSource(GT, null);
            cbbOptionViewDSSV.DisplayMember = "Value";
            cbbOptionViewDSSV.ValueMember = "Key";


        }
        void loadTieuChiChuaCham()
        {
            if (txtMaSV.Text.Length > 0 && txtMaHocKy.Text.Length > 0)
            {

                gvDsTieuChi.DataSource = TieuChiRenLuyenDAO.Instance.SelectChuaCham(txtMaSV.Text, txtMaHocKy.Text, int.Parse(cbbOption.SelectedValue.ToString()));

            }
        }

        void loadAllDanhSach()
        {
            if (txtMaHocKy.Text.Length > 0)
            {
                string keyword = "x";
                int thamso = 0;
                string mahocky = "x";
                mahocky = txtMaHocKy.Text;
                if (txtKeyword.Text.Length > 0) keyword = txtKeyword.Text;
                thamso = getDiemFromTexbox(cbbOptionViewDSSV.SelectedValue.ToString());
                gvDiemRenLuyen.DataSource = DiemRenLuyenDAO.Instance.SelectAllData(thamso, mahocky, keyword);
            }
        }
        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            addToObject();
            DiemRenLuyenDAO.Instance.Insert(diemRenLuyen);
            clearTextDiem();
            loadAllDanhSach();
            loadTieuChiChuaCham();

        }

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            addToObject();
            DiemRenLuyenDAO.Instance.Insert(diemRenLuyen);
            loadAllDanhSach();
            loadTieuChiChuaCham();
            clearTextDiem();
        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            addToObject();
            DiemRenLuyenDAO.Instance.Remove(diemRenLuyen);
            loadAllDanhSach();
            loadTieuChiChuaCham();
            Clear();

        }

        private void btnReset_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            txbKhoacham.Text = "";
            txtGVCN.Text = "";
            txtLopTruong.Text = "";
            txtMaHocKy.Text = "";
            txtMaSV.Text = "";
            txtMaTieuChi.Text = "";
            txtTuCham.Text = "";
            show();
        }

        private void gvDiemRenLuyen_Click(object sender, EventArgs e)
        {

            foreach (int i in gridView1.GetSelectedRows())
            {
                DataRow row = gridView1.GetDataRow(i);
                txtMaSV.Text = Convert.ToString(row[0]);
                txtMaTieuChi.Text = Convert.ToString(row[2]);
                txtTuCham.Text = Convert.ToString(row[3]);
                txtLopTruong.Text = Convert.ToString(row[4]);
                txtGVCN.Text = Convert.ToString(row[5]);
                txbKhoacham.Text = Convert.ToString(row[6]);

            }
            int soluong = DiemRenLuyenDAO.Instance.DemSoLuongTieuChiSV(txtMaSV.Text, txtMaHocKy.Text);
            if (soluong == 0)
            {
                DiemRenLuyenDAO.Instance.KhoiTaoForSV(txtMaSV.Text, txtMaHocKy.Text);
                loadAllDanhSach();

            }
            loadTieuChiChuaCham();
            show();

        }

        private void onChangeOption(object sender, EventArgs e)
        {
            loadTieuChiChuaCham();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadAllDanhSach();
        }

        private void onKeyDownEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (DiemRenLuyenDAO.Instance.IsExist(txtMaHocKy.Text))
                {
                    loadAllDanhSach();
                    show();
                }
                else
                {
                    int check = HocKyDAO.Instance.SoLuong(new HocKy(txtMaHocKy.Text, ""));
                    if (check == 0)
                    {
                        XtraMessageBox.Show("Mã học kỳ không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        DialogResult dlr;
                        dlr = XtraMessageBox.Show("Chưa tạo bảng điểm rèm luyện. Chọn Yes để đồng ý tạo bảng điểm, No để thoát", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                        if (dlr == DialogResult.Yes)
                        {
                            int dem = DiemRenLuyenDAO.Instance.KhoiTao(txtMaHocKy.Text);
                            if (dem > 0)
                            {
                                XtraMessageBox.Show("Đã tạo bảng điểm cho " + dem + " sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }


                }

            }
        }

        private void gvDsTieuChi_Click(object sender, EventArgs e)
        {
            foreach (int i in gridView2.GetSelectedRows())
            {
                DataRow row = gridView2.GetDataRow(i);
                txtMaTieuChi.Text = Convert.ToString(row[0]);
                clearTextDiem();
            }
            
            show();
        }
        void clearTextDiem()
        {
            txbKhoacham.Text = "";
            txtGVCN.Text = "";
            txtLopTruong.Text = "";
            txtTuCham.Text = "";
        }
    }
}
