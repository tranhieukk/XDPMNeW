namespace QuanLyDiem
{
    partial class frmHocLai
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.rdTuyetDoi = new System.Windows.Forms.RadioButton();
            this.rdTuongDoi = new System.Windows.Forms.RadioButton();
            this.txeMaSV = new DevExpress.XtraEditors.TextEdit();
            this.txeMaKhoa = new DevExpress.XtraEditors.TextEdit();
            this.txeMaLop = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txeMaSV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txeMaKhoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txeMaLop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.rdTuyetDoi);
            this.layoutControl1.Controls.Add(this.rdTuongDoi);
            this.layoutControl1.Controls.Add(this.txeMaSV);
            this.layoutControl1.Controls.Add(this.txeMaKhoa);
            this.layoutControl1.Controls.Add(this.txeMaLop);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(806, 57);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // rdTuyetDoi
            // 
            this.rdTuyetDoi.Location = new System.Drawing.Point(694, 12);
            this.rdTuyetDoi.Name = "rdTuyetDoi";
            this.rdTuyetDoi.Size = new System.Drawing.Size(83, 25);
            this.rdTuyetDoi.TabIndex = 8;
            this.rdTuyetDoi.Text = "Chính xác";
            this.rdTuyetDoi.UseVisualStyleBackColor = true;
            // 
            // rdTuongDoi
            // 
            this.rdTuongDoi.Checked = true;
            this.rdTuongDoi.Location = new System.Drawing.Point(607, 12);
            this.rdTuongDoi.Name = "rdTuongDoi";
            this.rdTuongDoi.Size = new System.Drawing.Size(83, 25);
            this.rdTuongDoi.TabIndex = 7;
            this.rdTuongDoi.TabStop = true;
            this.rdTuongDoi.Text = "Tương đối";
            this.rdTuongDoi.UseVisualStyleBackColor = true;
            // 
            // txeMaSV
            // 
            this.txeMaSV.Location = new System.Drawing.Point(456, 12);
            this.txeMaSV.Name = "txeMaSV";
            this.txeMaSV.Size = new System.Drawing.Size(147, 20);
            this.txeMaSV.StyleController = this.layoutControl1;
            this.txeMaSV.TabIndex = 6;
            this.txeMaSV.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TimkiemtheoSV);
            // 
            // txeMaKhoa
            // 
            this.txeMaKhoa.Location = new System.Drawing.Point(74, 12);
            this.txeMaKhoa.Name = "txeMaKhoa";
            this.txeMaKhoa.Size = new System.Drawing.Size(115, 20);
            this.txeMaKhoa.StyleController = this.layoutControl1;
            this.txeMaKhoa.TabIndex = 5;
            this.txeMaKhoa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TimkiemKhiEnter);
            // 
            // txeMaLop
            // 
            this.txeMaLop.Location = new System.Drawing.Point(255, 12);
            this.txeMaLop.Name = "txeMaLop";
            this.txeMaLop.Size = new System.Drawing.Size(135, 20);
            this.txeMaLop.StyleController = this.layoutControl1;
            this.txeMaLop.TabIndex = 4;
            this.txeMaLop.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TimKiemByMaLop);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.emptySpaceItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(789, 59);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txeMaLop;
            this.layoutControlItem1.Location = new System.Drawing.Point(181, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(201, 29);
            this.layoutControlItem1.Text = "Mã lớp";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(59, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 29);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(769, 10);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txeMaKhoa;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(181, 29);
            this.layoutControlItem2.Text = "Mã khoa";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(59, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txeMaSV;
            this.layoutControlItem3.Location = new System.Drawing.Point(382, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(213, 29);
            this.layoutControlItem3.Text = "Mã sinh viên";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(59, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.rdTuongDoi;
            this.layoutControlItem4.Location = new System.Drawing.Point(595, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(87, 29);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.rdTuyetDoi;
            this.layoutControlItem5.Location = new System.Drawing.Point(682, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(87, 29);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 57);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(806, 444);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // frmHocLai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 501);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.layoutControl1);
            this.Name = "frmHocLai";
            this.Text = "Danh sách học lại";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txeMaSV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txeMaKhoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txeMaLop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.TextEdit txeMaSV;
        private DevExpress.XtraEditors.TextEdit txeMaKhoa;
        private DevExpress.XtraEditors.TextEdit txeMaLop;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private System.Windows.Forms.RadioButton rdTuyetDoi;
        private System.Windows.Forms.RadioButton rdTuongDoi;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
    }
}