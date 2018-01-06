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
namespace QuanLyDiem
{
    public partial class frmMenu : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMenu()
        {
            InitializeComponent();
            //Establish();



        }
        private void Establish()
        {
            this.btnLogIn.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.btnChangePass.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.btnLogOut.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.btnRole.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.skinRibbonGalleryBarItem1.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.btnMonhoc.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.btnKhoa.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.btnLop.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.btnSinhVien.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.btnGiangVien.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.btnDiemmonhoc.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.btnThiLai.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.btnHoclai.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.btnDSSVThiLai.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.hocKy.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.btnHocKy.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.btnDiemRenLuyen.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.btnBieuMauSinhVien.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.btnDanhSachMonHoc.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.btnBangDiemCaNhan.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.btndanhSachHocBong.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.btnTieuChiRenLuyen.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;

            this.ribbonDanhMuc.Visible = false;
            this.ribonDanhMuc.Visible = false;
            this.ribbonQuanLy.Visible = false;
            this.rPGQuanLy.Visible = false;
            this.ribbonBaoCao.Visible = false;
            this.rPGBieuMau.Visible = false;
            this.rbtaiKhoan.Visible = false;
            this.rpgTruyCap.Visible = false;
            this.ribbonCaiDat.Visible = false;
            this.rpgGiaoDien.Visible = false;


        }
        void Enablecontrol()
        {
            
            if (checkper("ND")|| checkper("SD"))
            {
                this.ribbonQuanLy.Visible = true;
                this.btnDiemmonhoc.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
          
            if (checkper("NDR")|| checkper("SDR"))
            {
                this.ribbonQuanLy.Visible = true;
                this.btnDiemmonhoc.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
           

            this.ribbonDanhMuc.Visible = false;
            this.ribonDanhMuc.Visible = false;
            this.ribbonQuanLy.Visible = false;
            this.rPGQuanLy.Visible = false;
            this.ribbonBaoCao.Visible = false;
            this.rPGBieuMau.Visible = false;
            this.rbtaiKhoan.Visible = false;
            this.rpgTruyCap.Visible = false;
            this.ribbonCaiDat.Visible = true;
            this.rpgGiaoDien.Visible = true;
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
            themes.LookAndFeel.SkinName = "Blue"; // giao diện mặc định khi mở chương trình
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
            DialogResult dlr;
            dlr = XtraMessageBox.Show("Bạn có muốn thoát chương trình?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.No)
            {
                Application.Exit();
            }
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
    }
}
