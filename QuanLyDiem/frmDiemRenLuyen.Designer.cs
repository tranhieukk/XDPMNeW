namespace QuanLyDiem
{
    partial class frmDiemRenLuyen
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
            this.btnReset = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.txbKhoacham = new System.Windows.Forms.TextBox();
            this.txtGVCN = new DevExpress.XtraEditors.TextEdit();
            this.txtLopTruong = new DevExpress.XtraEditors.TextEdit();
            this.txtTuCham = new DevExpress.XtraEditors.TextEdit();
            this.txtMaTieuChi = new DevExpress.XtraEditors.TextEdit();
            this.txtMaHocKy = new DevExpress.XtraEditors.TextEdit();
            this.txtMaSV = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.gvDiemRenLuyen = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gvDsTieuChi = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cbbOption = new System.Windows.Forms.ComboBox();
            this.cbbOptionViewDSSV = new System.Windows.Forms.ComboBox();
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtGVCN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLopTruong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTuCham.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaTieuChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaHocKy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDiemRenLuyen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDsTieuChi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
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
            this.btnReset});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 4;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.FloatLocation = new System.Drawing.Point(209, 138);
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnAdd, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnEdit, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnDelete, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnReset, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnAdd
            // 
            this.btnAdd.Caption = "Thêm";
            this.btnAdd.Id = 0;
            this.btnAdd.ImageOptions.Image = global::QuanLyDiem.Properties.Resources.Actions_list_add_user_icon;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAdd_ItemClick);
            // 
            // btnEdit
            // 
            this.btnEdit.Caption = "Sửa";
            this.btnEdit.Id = 1;
            this.btnEdit.ImageOptions.Image = global::QuanLyDiem.Properties.Resources.Edit_Male_User_icon;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEdit_ItemClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Caption = "Xóa";
            this.btnDelete.Id = 2;
            this.btnDelete.ImageOptions.Image = global::QuanLyDiem.Properties.Resources.Close_2_icon;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDelete_ItemClick);
            // 
            // btnReset
            // 
            this.btnReset.Caption = "Làm lại";
            this.btnReset.Id = 3;
            this.btnReset.ImageOptions.Image = global::QuanLyDiem.Properties.Resources.Repeat_22_icon;
            this.btnReset.Name = "btnReset";
            this.btnReset.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReset_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(2);
            this.barDockControlTop.Size = new System.Drawing.Size(1298, 32);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 516);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(2);
            this.barDockControlBottom.Size = new System.Drawing.Size(1298, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 32);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(2);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 484);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1298, 32);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(2);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 484);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.txbKhoacham);
            this.layoutControl1.Controls.Add(this.txtGVCN);
            this.layoutControl1.Controls.Add(this.txtLopTruong);
            this.layoutControl1.Controls.Add(this.txtTuCham);
            this.layoutControl1.Controls.Add(this.txtMaTieuChi);
            this.layoutControl1.Controls.Add(this.txtMaHocKy);
            this.layoutControl1.Controls.Add(this.txtMaSV);
            this.layoutControl1.Location = new System.Drawing.Point(11, 36);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(2);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(802, 79);
            this.layoutControl1.TabIndex = 4;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // txbKhoacham
            // 
            this.txbKhoacham.Location = new System.Drawing.Point(723, 36);
            this.txbKhoacham.Name = "txbKhoacham";
            this.txbKhoacham.Size = new System.Drawing.Size(67, 20);
            this.txbKhoacham.TabIndex = 10;
            // 
            // txtGVCN
            // 
            this.txtGVCN.EditValue = "";
            this.txtGVCN.Location = new System.Drawing.Point(533, 36);
            this.txtGVCN.Margin = new System.Windows.Forms.Padding(2);
            this.txtGVCN.MenuManager = this.barManager1;
            this.txtGVCN.Name = "txtGVCN";
            this.txtGVCN.Size = new System.Drawing.Size(101, 20);
            this.txtGVCN.StyleController = this.layoutControl1;
            this.txtGVCN.TabIndex = 9;
            // 
            // txtLopTruong
            // 
            this.txtLopTruong.EditValue = "";
            this.txtLopTruong.Location = new System.Drawing.Point(317, 36);
            this.txtLopTruong.Margin = new System.Windows.Forms.Padding(2);
            this.txtLopTruong.MenuManager = this.barManager1;
            this.txtLopTruong.Name = "txtLopTruong";
            this.txtLopTruong.Size = new System.Drawing.Size(127, 20);
            this.txtLopTruong.StyleController = this.layoutControl1;
            this.txtLopTruong.TabIndex = 8;
            // 
            // txtTuCham
            // 
            this.txtTuCham.EditValue = "";
            this.txtTuCham.Location = new System.Drawing.Point(97, 36);
            this.txtTuCham.Margin = new System.Windows.Forms.Padding(2);
            this.txtTuCham.MenuManager = this.barManager1;
            this.txtTuCham.Name = "txtTuCham";
            this.txtTuCham.Size = new System.Drawing.Size(131, 20);
            this.txtTuCham.StyleController = this.layoutControl1;
            this.txtTuCham.TabIndex = 7;
            // 
            // txtMaTieuChi
            // 
            this.txtMaTieuChi.Location = new System.Drawing.Point(601, 12);
            this.txtMaTieuChi.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaTieuChi.MenuManager = this.barManager1;
            this.txtMaTieuChi.Name = "txtMaTieuChi";
            this.txtMaTieuChi.Size = new System.Drawing.Size(189, 20);
            this.txtMaTieuChi.StyleController = this.layoutControl1;
            this.txtMaTieuChi.TabIndex = 6;
            // 
            // txtMaHocKy
            // 
            this.txtMaHocKy.Location = new System.Drawing.Point(97, 12);
            this.txtMaHocKy.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaHocKy.MenuManager = this.barManager1;
            this.txtMaHocKy.Name = "txtMaHocKy";
            this.txtMaHocKy.Size = new System.Drawing.Size(131, 20);
            this.txtMaHocKy.StyleController = this.layoutControl1;
            this.txtMaHocKy.TabIndex = 5;
            this.txtMaHocKy.KeyDown += new System.Windows.Forms.KeyEventHandler(this.onKeyDownEnter);
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(317, 12);
            this.txtMaSV.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaSV.MenuManager = this.barManager1;
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(195, 20);
            this.txtMaSV.StyleController = this.layoutControl1;
            this.txtMaSV.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.layoutControlItem4,
            this.layoutControlItem1,
            this.layoutControlItem3});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.OptionsItemText.TextToControlDistance = 4;
            this.layoutControlGroup1.Size = new System.Drawing.Size(802, 79);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtMaHocKy;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(220, 24);
            this.layoutControlItem2.Text = "Mã học kỳ";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(81, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.txtLopTruong;
            this.layoutControlItem5.Location = new System.Drawing.Point(220, 24);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(216, 35);
            this.layoutControlItem5.Text = "Lớp trưởng chấm";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(81, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.txtGVCN;
            this.layoutControlItem6.Location = new System.Drawing.Point(436, 24);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(190, 35);
            this.layoutControlItem6.Text = "GVCN chấm";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(81, 13);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.txbKhoacham;
            this.layoutControlItem7.Location = new System.Drawing.Point(626, 24);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(156, 35);
            this.layoutControlItem7.Text = "Khoa chấm";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(81, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.txtTuCham;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(220, 35);
            this.layoutControlItem4.Text = "Tự chấm";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(81, 13);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtMaSV;
            this.layoutControlItem1.Location = new System.Drawing.Point(220, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(284, 24);
            this.layoutControlItem1.Text = "Mã sinh viên";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(81, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txtMaTieuChi;
            this.layoutControlItem3.Location = new System.Drawing.Point(504, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(278, 24);
            this.layoutControlItem3.Text = "Mã tiêu chí";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(81, 13);
            // 
            // gvDiemRenLuyen
            // 
            this.gvDiemRenLuyen.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.gvDiemRenLuyen.Location = new System.Drawing.Point(9, 174);
            this.gvDiemRenLuyen.MainView = this.gridView1;
            this.gvDiemRenLuyen.Margin = new System.Windows.Forms.Padding(2);
            this.gvDiemRenLuyen.MenuManager = this.barManager1;
            this.gvDiemRenLuyen.Name = "gvDiemRenLuyen";
            this.gvDiemRenLuyen.Size = new System.Drawing.Size(792, 380);
            this.gvDiemRenLuyen.TabIndex = 5;
            this.gvDiemRenLuyen.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gvDiemRenLuyen.Click += new System.EventHandler(this.gvDiemRenLuyen_Click);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gvDiemRenLuyen;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            // 
            // gvDsTieuChi
            // 
            this.gvDsTieuChi.Location = new System.Drawing.Point(829, 174);
            this.gvDsTieuChi.MainView = this.gridView2;
            this.gvDsTieuChi.MenuManager = this.barManager1;
            this.gvDsTieuChi.Name = "gvDsTieuChi";
            this.gvDsTieuChi.Size = new System.Drawing.Size(440, 361);
            this.gvDsTieuChi.TabIndex = 10;
            this.gvDsTieuChi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            this.gvDsTieuChi.Click += new System.EventHandler(this.gvDsTieuChi_Click);
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gvDsTieuChi;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            // 
            // cbbOption
            // 
            this.cbbOption.FormattingEnabled = true;
            this.cbbOption.Location = new System.Drawing.Point(829, 147);
            this.cbbOption.Name = "cbbOption";
            this.cbbOption.Size = new System.Drawing.Size(400, 21);
            this.cbbOption.TabIndex = 11;
            this.cbbOption.SelectedIndexChanged += new System.EventHandler(this.onChangeOption);
            // 
            // cbbOptionViewDSSV
            // 
            this.cbbOptionViewDSSV.FormattingEnabled = true;
            this.cbbOptionViewDSSV.Location = new System.Drawing.Point(12, 148);
            this.cbbOptionViewDSSV.Name = "cbbOptionViewDSSV";
            this.cbbOptionViewDSSV.Size = new System.Drawing.Size(269, 21);
            this.cbbOptionViewDSSV.TabIndex = 12;
            // 
            // txtKeyword
            // 
            this.txtKeyword.Location = new System.Drawing.Point(292, 147);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(173, 20);
            this.txtKeyword.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(481, 146);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Tìm kiếm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmDiemRenLuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1298, 516);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtKeyword);
            this.Controls.Add(this.cbbOptionViewDSSV);
            this.Controls.Add(this.cbbOption);
            this.Controls.Add(this.gvDsTieuChi);
            this.Controls.Add(this.gvDiemRenLuyen);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmDiemRenLuyen";
            this.Text = "ĐIỂM RÈN LUYỆN";
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtGVCN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLopTruong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTuCham.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaTieuChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaHocKy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDiemRenLuyen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDsTieuChi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
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
        private DevExpress.XtraBars.BarButtonItem btnReset;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.TextEdit txtGVCN;
        private DevExpress.XtraEditors.TextEdit txtLopTruong;
        private DevExpress.XtraEditors.TextEdit txtTuCham;
        private DevExpress.XtraEditors.TextEdit txtMaTieuChi;
        private DevExpress.XtraEditors.TextEdit txtMaHocKy;
        private DevExpress.XtraEditors.TextEdit txtMaSV;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraGrid.GridControl gvDiemRenLuyen;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.TextBox txbKhoacham;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraGrid.GridControl gvDsTieuChi;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.ComboBox cbbOption;
        private System.Windows.Forms.TextBox txtKeyword;
        private System.Windows.Forms.ComboBox cbbOptionViewDSSV;
        private System.Windows.Forms.Button button1;
    }
}