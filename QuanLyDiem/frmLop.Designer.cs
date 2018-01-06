namespace QuanLyDiem
{
    partial class frmLop
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
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar4 = new DevExpress.XtraBars.Bar();
            this.btnAdd = new DevExpress.XtraBars.BarButtonItem();
            this.btnEdit = new DevExpress.XtraBars.BarButtonItem();
            this.btnDelete = new DevExpress.XtraBars.BarButtonItem();
            this.btnReset = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.cbbnganhhoc = new System.Windows.Forms.ComboBox();
            this.cbbHeDaoTao = new System.Windows.Forms.ComboBox();
            this.cbbKhoaHoc = new System.Windows.Forms.ComboBox();
            this.cbbkhoa = new System.Windows.Forms.ComboBox();
            this.txeTenLop = new DevExpress.XtraEditors.TextEdit();
            this.txEMaLop = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.Khoa = new DevExpress.XtraLayout.LayoutControlItem();
            this.Khóa = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grvLop = new DevExpress.XtraGrid.GridControl();
            this.lbThongBao = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txeTenLop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txEMaLop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Khoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Khóa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvLop)).BeginInit();
            this.SuspendLayout();
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // bar1
            // 
            this.bar1.BarName = "Main menu";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.OptionsBar.MultiLine = true;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Main menu";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar4});
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
            this.barManager1.MainMenu = this.bar4;
            this.barManager1.MaxItemId = 4;
            // 
            // bar4
            // 
            this.bar4.BarName = "Main menu";
            this.bar4.DockCol = 0;
            this.bar4.DockRow = 0;
            this.bar4.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar4.FloatLocation = new System.Drawing.Point(257, 130);
            this.bar4.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnAdd, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnEdit, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnDelete, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnReset, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar4.OptionsBar.MultiLine = true;
            this.bar4.OptionsBar.UseWholeRow = true;
            this.bar4.Text = "Main menu";
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
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlTop.Size = new System.Drawing.Size(1167, 32);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 452);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlBottom.Size = new System.Drawing.Size(1167, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 32);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 420);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1167, 32);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 420);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.cbbnganhhoc);
            this.layoutControl1.Controls.Add(this.cbbHeDaoTao);
            this.layoutControl1.Controls.Add(this.cbbKhoaHoc);
            this.layoutControl1.Controls.Add(this.cbbkhoa);
            this.layoutControl1.Controls.Add(this.txeTenLop);
            this.layoutControl1.Controls.Add(this.txEMaLop);
            this.layoutControl1.Location = new System.Drawing.Point(11, 39);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1165, 98);
            this.layoutControl1.TabIndex = 4;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // cbbnganhhoc
            // 
            this.cbbnganhhoc.FormattingEnabled = true;
            this.cbbnganhhoc.Location = new System.Drawing.Point(575, 37);
            this.cbbnganhhoc.Name = "cbbnganhhoc";
            this.cbbnganhhoc.Size = new System.Drawing.Size(578, 21);
            this.cbbnganhhoc.TabIndex = 12;
            // 
            // cbbHeDaoTao
            // 
            this.cbbHeDaoTao.FormattingEnabled = true;
            this.cbbHeDaoTao.Location = new System.Drawing.Point(575, 12);
            this.cbbHeDaoTao.Name = "cbbHeDaoTao";
            this.cbbHeDaoTao.Size = new System.Drawing.Size(578, 21);
            this.cbbHeDaoTao.TabIndex = 11;
            // 
            // cbbKhoaHoc
            // 
            this.cbbKhoaHoc.FormattingEnabled = true;
            this.cbbKhoaHoc.Location = new System.Drawing.Point(575, 62);
            this.cbbKhoaHoc.Name = "cbbKhoaHoc";
            this.cbbKhoaHoc.Size = new System.Drawing.Size(578, 21);
            this.cbbKhoaHoc.TabIndex = 10;
            // 
            // cbbkhoa
            // 
            this.cbbkhoa.FormattingEnabled = true;
            this.cbbkhoa.Location = new System.Drawing.Point(86, 60);
            this.cbbkhoa.Name = "cbbkhoa";
            this.cbbkhoa.Size = new System.Drawing.Size(411, 21);
            this.cbbkhoa.TabIndex = 3;
            // 
            // txeTenLop
            // 
            this.txeTenLop.Location = new System.Drawing.Point(86, 36);
            this.txeTenLop.MenuManager = this.barManager1;
            this.txeTenLop.Name = "txeTenLop";
            this.txeTenLop.Size = new System.Drawing.Size(411, 20);
            this.txeTenLop.StyleController = this.layoutControl1;
            this.txeTenLop.TabIndex = 2;
            // 
            // txEMaLop
            // 
            this.txEMaLop.Location = new System.Drawing.Point(86, 12);
            this.txEMaLop.MenuManager = this.barManager1;
            this.txEMaLop.Name = "txEMaLop";
            this.txEMaLop.Size = new System.Drawing.Size(411, 20);
            this.txEMaLop.StyleController = this.layoutControl1;
            this.txEMaLop.TabIndex = 0;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.Khoa,
            this.Khóa,
            this.layoutControlItem3,
            this.layoutControlItem4});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.OptionsItemText.TextToControlDistance = 4;
            this.layoutControlGroup1.Size = new System.Drawing.Size(1165, 98);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txEMaLop;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(489, 24);
            this.layoutControlItem1.Text = "Mã lớp";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(70, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txeTenLop;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(489, 24);
            this.layoutControlItem2.Text = "Tên lớp";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(70, 13);
            // 
            // Khoa
            // 
            this.Khoa.Control = this.cbbkhoa;
            this.Khoa.Location = new System.Drawing.Point(0, 48);
            this.Khoa.Name = "Khoa";
            this.Khoa.Size = new System.Drawing.Size(489, 30);
            this.Khoa.TextSize = new System.Drawing.Size(70, 13);
            // 
            // Khóa
            // 
            this.Khóa.Control = this.cbbKhoaHoc;
            this.Khóa.Location = new System.Drawing.Point(489, 50);
            this.Khóa.Name = "Khóa";
            this.Khóa.Size = new System.Drawing.Size(656, 28);
            this.Khóa.TextSize = new System.Drawing.Size(70, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.cbbHeDaoTao;
            this.layoutControlItem3.Location = new System.Drawing.Point(489, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(656, 25);
            this.layoutControlItem3.Text = "Hệ đào tạo";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(70, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.cbbnganhhoc;
            this.layoutControlItem4.Location = new System.Drawing.Point(489, 25);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(656, 25);
            this.layoutControlItem4.Text = "Chuyên ngành";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(70, 13);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.grvLop;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.Editable = false;
            // 
            // grvLop
            // 
            this.grvLop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grvLop.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grvLop.Location = new System.Drawing.Point(11, 188);
            this.grvLop.MainView = this.gridView1;
            this.grvLop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grvLop.MenuManager = this.barManager1;
            this.grvLop.Name = "grvLop";
            this.grvLop.Size = new System.Drawing.Size(1158, 242);
            this.grvLop.TabIndex = 5;
            this.grvLop.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.grvLop.Click += new System.EventHandler(this.grvLop_Click);
            // 
            // lbThongBao
            // 
            this.lbThongBao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbThongBao.AutoSize = true;
            this.lbThongBao.Location = new System.Drawing.Point(8, 432);
            this.lbThongBao.Name = "lbThongBao";
            this.lbThongBao.Size = new System.Drawing.Size(62, 13);
            this.lbThongBao.TabIndex = 10;
            this.lbThongBao.Text = "Thông báo:";
            // 
            // frmLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1167, 452);
            this.Controls.Add(this.lbThongBao);
            this.Controls.Add(this.grvLop);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmLop";
            this.Text = "LỚP";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txeTenLop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txEMaLop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Khoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Khóa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvLop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar4;
        private DevExpress.XtraBars.BarButtonItem btnAdd;
        private DevExpress.XtraBars.BarButtonItem btnEdit;
        private DevExpress.XtraBars.BarButtonItem btnDelete;
        private DevExpress.XtraBars.BarButtonItem btnReset;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.TextEdit txeTenLop;
        private DevExpress.XtraEditors.TextEdit txEMaLop;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private System.Windows.Forms.ComboBox cbbkhoa;
        private DevExpress.XtraLayout.LayoutControlItem Khoa;
        private DevExpress.XtraGrid.GridControl grvLop;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.ComboBox cbbHeDaoTao;
        private System.Windows.Forms.ComboBox cbbKhoaHoc;
        private DevExpress.XtraLayout.LayoutControlItem Khóa;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private System.Windows.Forms.ComboBox cbbnganhhoc;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private System.Windows.Forms.Label lbThongBao;
    }
}