namespace QuanLyDiem
{
    partial class frmSinhVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnAdd = new DevExpress.XtraBars.BarButtonItem();
            this.btnEdit = new DevExpress.XtraBars.BarButtonItem();
            this.btnDelete = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.cbbLop = new System.Windows.Forms.ComboBox();
            this.cbbChinhSach = new System.Windows.Forms.ComboBox();
            this.txbDiaChi = new DevExpress.XtraEditors.TextEdit();
            this.cbbGioiTinh = new System.Windows.Forms.ComboBox();
            this.txbNgaySinh = new System.Windows.Forms.TextBox();
            this.txbHoTen = new System.Windows.Forms.TextBox();
            this.txbMasV = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.grCSinhViens = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.lbThongBao = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txbDiaChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbMasV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grCSinhViens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnAdd,
            this.btnEdit,
            this.btnDelete,
            this.barButtonItem1});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 4;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnAdd, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnEdit, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnDelete, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem1, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnAdd
            // 
            this.btnAdd.Caption = "Thêm";
            this.btnAdd.Glyph = global::QuanLyDiem.Properties.Resources.Actions_list_add_user_icon;
            this.btnAdd.Id = 0;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAdd_ItemClick);
            // 
            // btnEdit
            // 
            this.btnEdit.Caption = "Sửa";
            this.btnEdit.Glyph = global::QuanLyDiem.Properties.Resources.Edit_Male_User_icon;
            this.btnEdit.Id = 1;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEdit_ItemClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Caption = "Xóa";
            this.btnDelete.Glyph = global::QuanLyDiem.Properties.Resources.Close_2_icon;
            this.btnDelete.Id = 2;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDelete_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Làm lại";
            this.barButtonItem1.Glyph = global::QuanLyDiem.Properties.Resources.Repeat_22_icon;
            this.barButtonItem1.Id = 3;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlTop.Size = new System.Drawing.Size(1256, 32);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 516);
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlBottom.Size = new System.Drawing.Size(1256, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 32);
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 484);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1256, 32);
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 484);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.cbbLop);
            this.layoutControl1.Controls.Add(this.cbbChinhSach);
            this.layoutControl1.Controls.Add(this.txbDiaChi);
            this.layoutControl1.Controls.Add(this.cbbGioiTinh);
            this.layoutControl1.Controls.Add(this.txbNgaySinh);
            this.layoutControl1.Controls.Add(this.txbHoTen);
            this.layoutControl1.Controls.Add(this.txbMasV);
            this.layoutControl1.Location = new System.Drawing.Point(10, 46);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(943, 120);
            this.layoutControl1.TabIndex = 4;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // cbbLop
            // 
            this.cbbLop.FormattingEnabled = true;
            this.cbbLop.Location = new System.Drawing.Point(127, 85);
            this.cbbLop.Name = "cbbLop";
            this.cbbLop.Size = new System.Drawing.Size(342, 21);
            this.cbbLop.TabIndex = 11;
            // 
            // cbbChinhSach
            // 
            this.cbbChinhSach.FormattingEnabled = true;
            this.cbbChinhSach.Location = new System.Drawing.Point(588, 85);
            this.cbbChinhSach.Name = "cbbChinhSach";
            this.cbbChinhSach.Size = new System.Drawing.Size(343, 21);
            this.cbbChinhSach.TabIndex = 10;
            // 
            // txbDiaChi
            // 
            this.txbDiaChi.EditValue = "Hòa Nam - Di Linh - Lâm Đồng";
            this.txbDiaChi.Location = new System.Drawing.Point(127, 61);
            this.txbDiaChi.MenuManager = this.barManager1;
            this.txbDiaChi.Name = "txbDiaChi";
            this.txbDiaChi.Size = new System.Drawing.Size(804, 20);
            this.txbDiaChi.StyleController = this.layoutControl1;
            this.txbDiaChi.TabIndex = 9;
            // 
            // cbbGioiTinh
            // 
            this.cbbGioiTinh.FormattingEnabled = true;
            this.cbbGioiTinh.Location = new System.Drawing.Point(524, 36);
            this.cbbGioiTinh.Name = "cbbGioiTinh";
            this.cbbGioiTinh.Size = new System.Drawing.Size(407, 21);
            this.cbbGioiTinh.TabIndex = 7;
            // 
            // txbNgaySinh
            // 
            this.txbNgaySinh.Location = new System.Drawing.Point(127, 36);
            this.txbNgaySinh.Name = "txbNgaySinh";
            this.txbNgaySinh.Size = new System.Drawing.Size(278, 20);
            this.txbNgaySinh.TabIndex = 6;
            this.txbNgaySinh.Text = "25-4-1995";
            // 
            // txbHoTen
            // 
            this.txbHoTen.Location = new System.Drawing.Point(524, 12);
            this.txbHoTen.Name = "txbHoTen";
            this.txbHoTen.Size = new System.Drawing.Size(407, 20);
            this.txbHoTen.TabIndex = 5;
            this.txbHoTen.Text = "Trần Trung Hiếu";
            // 
            // txbMasV
            // 
            this.txbMasV.EditValue = "14DC027";
            this.txbMasV.Location = new System.Drawing.Point(127, 12);
            this.txbMasV.MenuManager = this.barManager1;
            this.txbMasV.Name = "txbMasV";
            this.txbMasV.Size = new System.Drawing.Size(278, 20);
            this.txbMasV.StyleController = this.layoutControl1;
            this.txbMasV.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.layoutControlItem5});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.OptionsItemText.TextToControlDistance = 4;
            this.layoutControlGroup1.Size = new System.Drawing.Size(943, 120);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txbMasV;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(397, 24);
            this.layoutControlItem1.Text = "Mã sinh viên";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(111, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txbHoTen;
            this.layoutControlItem2.Location = new System.Drawing.Point(397, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(526, 24);
            this.layoutControlItem2.Text = "Họ tên";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(111, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txbNgaySinh;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(397, 25);
            this.layoutControlItem3.Text = "Ngày sinh";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(111, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.cbbGioiTinh;
            this.layoutControlItem4.Location = new System.Drawing.Point(397, 24);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(526, 25);
            this.layoutControlItem4.Text = "Giới tính";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(111, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.txbDiaChi;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 49);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(923, 24);
            this.layoutControlItem6.Text = "Địa chỉ";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(111, 13);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.cbbChinhSach;
            this.layoutControlItem7.ControlAlignment = System.Drawing.ContentAlignment.BottomRight;
            this.layoutControlItem7.Location = new System.Drawing.Point(461, 73);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(462, 27);
            this.layoutControlItem7.Text = "Diện chính sách ưu tiên";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(111, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.cbbLop;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 73);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(461, 27);
            this.layoutControlItem5.Text = "Lớp";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(111, 13);
            // 
            // grCSinhViens
            // 
            this.grCSinhViens.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grCSinhViens.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grCSinhViens.Location = new System.Drawing.Point(21, 171);
            this.grCSinhViens.MainView = this.gridView1;
            this.grCSinhViens.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grCSinhViens.MenuManager = this.barManager1;
            this.grCSinhViens.Name = "grCSinhViens";
            this.grCSinhViens.Size = new System.Drawing.Size(1201, 292);
            this.grCSinhViens.TabIndex = 5;
            this.grCSinhViens.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.grCSinhViens.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.grCSinhViens;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            // 
            // lbThongBao
            // 
            this.lbThongBao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbThongBao.AutoSize = true;
            this.lbThongBao.Location = new System.Drawing.Point(7, 494);
            this.lbThongBao.Name = "lbThongBao";
            this.lbThongBao.Size = new System.Drawing.Size(62, 13);
            this.lbThongBao.TabIndex = 10;
            this.lbThongBao.Text = "Thông báo:";
            // 
            // frmSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 516);
            this.Controls.Add(this.lbThongBao);
            this.Controls.Add(this.grCSinhViens);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmSinhVien";
            this.Text = "THÔNG TIN SINH VIÊN";
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txbDiaChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbMasV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grCSinhViens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnAdd;
        private DevExpress.XtraBars.BarButtonItem btnEdit;
        private DevExpress.XtraBars.BarButtonItem btnDelete;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.TextEdit txbDiaChi;
        private System.Windows.Forms.ComboBox cbbGioiTinh;
        private System.Windows.Forms.TextBox txbNgaySinh;
        private System.Windows.Forms.TextBox txbHoTen;
        private DevExpress.XtraEditors.TextEdit txbMasV;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraGrid.GridControl grCSinhViens;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private System.Windows.Forms.ComboBox cbbChinhSach;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private System.Windows.Forms.ComboBox cbbLop;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private System.Windows.Forms.Label lbThongBao;
    }
}