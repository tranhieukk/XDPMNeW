using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DTO;
using QuanLyDiem.Reports;
using BUS;

namespace QuanLyDiem
{
    public partial class frmMenu : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private static DevExpress.LookAndFeel.DefaultLookAndFeel themes = new DevExpress.LookAndFeel.DefaultLookAndFeel();
        public frmMenu()
        {
            InitializeComponent();
            Establish();
            Enablecontrol();


        }
        private void Establish()
        {
            this.rCTQuanLyDiem.Visible = true;
            this.rbtaiKhoan.Visible = true;
            this.rpgTruyCap.Visible = true;
            this.ribHeThongDaotao.Visible = false;
            this.ribDiemSo.Visible = false;
         
            this.ribbonDanhMuc.Visible = false;
            this.ribonDanhMuc.Visible = false;
            this.ribbonQuanLy.Visible = false;
            this.rPGQuanLy.Visible = false;
         
            this.ribbonBaoCao.Visible = false;            
            this.rPGBieuMau.Visible = false;

            this.btnHocKy.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.btnDiemRenLuyen.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.btnBieuMauSinhVien.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.btnDanhSachMonHoc.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.btnBangDiemCaNhan.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.btndanhSachHocBong.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.btnTieuChiRenLuyen.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.btnHeDaoTao.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.btnChuyenNganh.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.btnLogIn.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.btnChangePass.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            this.btnLogOut.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            this.btnRole.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.btnMonhoc.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.btnKhoa.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.btnLop.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.btnSinhVien.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.btnGiangVien.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.btnDiemmonhoc.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.btnThiLai.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.btnHoclai.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.btnDSSVThiLai.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;


        }
        void Enablecontrol()
        {
            
            if (checkper("ND")|| checkper("SD"))
            {
                this.ribbonQuanLy.Visible = true;
                this.btnDiemmonhoc.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                this.ribDiemSo.Visible = true;
            }
          
            if (checkper("NDR")|| checkper("SDR"))
            {
                this.ribbonQuanLy.Visible = true;
                this.btnDiemRenLuyen.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                this.ribDiemSo.Visible = true;
            }
            if (checkper("NMH") || checkper("SMH") || checkper("XMH"))
            {
                this.ribbonDanhMuc.Visible = true;
                this.btnMonhoc.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                this.ribonDanhMuc.Visible = true;
            }
            if (checkper("THD") || checkper("SHD") || checkper("XHD"))
            {
                this.ribbonDanhMuc.Visible = true;
                this.btnHeDaoTao.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                this.ribHeThongDaotao.Visible = true;
            }
            if (checkper("THK") || checkper("SHK") || checkper("XHK"))
            {
                this.ribbonDanhMuc.Visible = true;
                this.btnHocKy.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                this.ribHeThongDaotao.Visible = true;
            }

            if (checkper("TK") || checkper("SK") || checkper("XK"))
            {
                this.ribbonDanhMuc.Visible = true;
                this.btnKhoa.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                this.ribHeThongDaotao.Visible = true;
            }
            if (checkper("TL") || checkper("SL") || checkper("XL"))
            {
                this.ribbonDanhMuc.Visible = true;
                this.btnLop.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                this.ribHeThongDaotao.Visible = true;
            }
            
                if (checkper("TNDT") || checkper("SNDT") || checkper("XNDT"))
            {
                this.ribbonDanhMuc.Visible = true;
                this.btnChuyenNganh.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                this.ribHeThongDaotao.Visible = true;
            }
            if (checkper("TSV") || checkper("TSV") || checkper("TSV"))
            {
                this.ribbonQuanLy.Visible = true;
                this.btnSinhVien.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                this.rPGQuanLy.Visible = true;
            }
            if (checkper("TRL") || checkper("SRL") || checkper("XRL"))
            {
                this.ribbonQuanLy.Visible = true;
                this.btnSinhVien.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                this.rPGQuanLy.Visible = true;
            }
            if (checkper("TNDT") || checkper("SNDT") || checkper("XNDT"))
            {
                this.ribbonDanhMuc.Visible = true;
                this.btnTieuChiRenLuyen.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                this.ribonDanhMuc.Visible = true;
            }
            if (checkper("BCMH") )
            {
                this.ribbonBaoCao.Visible = true;
                this.btnDanhSachMonHoc.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                this.rPGBieuMau.Visible = true;
            }
            if (checkper("BCSV"))
            {
                this.ribbonBaoCao.Visible = true;
                this.btnBieuMauSinhVien.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                this.rPGBieuMau.Visible = true;
            }
            if (checkper("DCN"))
            {
                this.ribbonBaoCao.Visible = true;
                this.btnBangDiemCaNhan.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                this.rPGBieuMau.Visible = true;
            }
            if (checkper("LHB"))
            {
                this.ribbonBaoCao.Visible = true;
                this.btndanhSachHocBong.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                this.rPGBieuMau.Visible = true;
            }
            if (checkper("LTL"))
            {
                this.ribbonBaoCao.Visible = true;
                this.btnThiLai.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                this.rPGBieuMau.Visible = true;
            }
            
                 if (checkper("LHL"))
            {
                this.ribbonBaoCao.Visible = true;
                this.btnHoclai.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                this.rPGBieuMau.Visible = true;
            }
            if (checkper("QLND"))
            {
                this.ribbonDanhMuc.Visible = true;
                this.btnRole.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                this.ribonDanhMuc.Visible = true;
            }
        }
        private Boolean checkper(string code)
        {
            
            foreach (ChiTietQuyenHan item in Program.ListPermision)
            {
                if (item.Code_hoatDong ==code )
                {
                    return true;
                }
            }
            return false;
        }
        public void skins()
        {
            DevExpress.LookAndFeel.DefaultLookAndFeel themes = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            if(!changeSkin())
            themes.LookAndFeel.SkinName = "Blue"; // giao diện mặc định khi mở chương trình
        }
        bool changeSkin()
        {   string skin= QuanLyAccountDAO.Instance.GetSkin(Program.Username);
            if(skin.Length > 0)
            {
             themes.LookAndFeel.SkinName = skin;
                return true;
            }
            return false;
        }
        private void frmMenu_Load(object sender, EventArgs e)
        {
            skins();
        }
        public void ViewChildForm(Form _form)
        {
            //Check before open
            if (!IsFormActived(_form))
            {
                _form.MdiParent = this;
                _form.Show();
            }
        }
        //Check if a form is opened already      
        private bool IsFormActived(Form form)
        {
            
            bool IsOpenend = false;
            //If there is more than one form opened
            if (MdiChildren.Count() > 0)
            {
                foreach (var item in MdiChildren)
                {
                    if (form.Name == item.Name)
                    {
                        //Active this form
                        MdiManager.Pages[item].MdiChild.Activate();
                        IsOpenend = true;
                    }
                }
            }
            return IsOpenend;
        }
        private void frmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            QuanLyAccountDAO.Instance.Update(Program.Username, themes.LookAndFeel.SkinName);
        }
        
        private void btnLogIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }
        private void btnMonhoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmMonHoc frm = new frmMonHoc();
            ViewChildForm(frm);


        }

        private void btnKhoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmKhoa frm = new frmKhoa();
            
            ViewChildForm(frm);
        }

        private void btnLop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmLop frm = new frmLop();
            
            ViewChildForm(frm);
        }

        private void btnLogOut_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult dlr;
            dlr = XtraMessageBox.Show("Bạn có muốn đăng nhập lại?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                  this.Hide();
            }
            if(dlr == DialogResult.No)
            {
                Application.Exit();
            }
          
        }

        private void btnSinhVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmSinhVien frm = new frmSinhVien();
            ViewChildForm(frm);
        }

        private void btnGiangVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmGiangvien frm = new frmGiangvien();
            ViewChildForm(frm);
        }

        private void rCTQuanLyDiem_Click(object sender, EventArgs e)
        {

        }

        private void btnHeDaoTao_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmHeDaoTao frm = new frmHeDaoTao();
            ViewChildForm(frm);
        }

        private void btnChuyenNganh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmChuyenNganh frm = new frmChuyenNganh();
            ViewChildForm(frm);
        }

        private void btnHocKy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmHocKy frm = new frmHocKy();
            ViewChildForm(frm);
        }

        private void btnTieuChiRenLuyen_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmTieuChiRenLuyen frm = new frmTieuChiRenLuyen();
            ViewChildForm(frm);
        }

        private void btnDiemRenLuyen_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDiemRenLuyen frm = new frmDiemRenLuyen();
            ViewChildForm(frm);
        }

        private void btnDiemmonhoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDiemMonHoc frm = new frmDiemMonHoc();
            ViewChildForm(frm);
        }

        private void btnBieuMauSinhVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Reports.StudentReport frm = new Reports.StudentReport();
            ViewChildForm(frm);
        }

        private void btnDanhSachMonHoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Reports.ReportMonHoccs frm = new Reports.ReportMonHoccs();
            ViewChildForm(frm);
        }

        private void btnBangDiemCaNhan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmRpBangDiemCaNhan frm = new frmRpBangDiemCaNhan();
            ViewChildForm(frm);
        }

        private void btndanhSachHocBong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            rpFrmHocBong frm = new rpFrmHocBong();
            ViewChildForm(frm);
        }

        private void btnRole_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmQuanLyNguoiDung frm = new frmQuanLyNguoiDung();
            ViewChildForm(frm);
        }

        private void btnHoclai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            frmHocLai frm = new frmHocLai();
            ViewChildForm(frm);
        }

        private void btnChangePass_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDoiMatKhau frm = new frmDoiMatKhau();
            ViewChildForm(frm);
        }

        private void btnThiLai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmThiLai frm = new frmThiLai();
            ViewChildForm(frm);
        }
    }
}
