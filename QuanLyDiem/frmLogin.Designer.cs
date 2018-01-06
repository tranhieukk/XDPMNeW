namespace QuanLyDiem
{
    partial class frmLogin
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.hLDangky = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.txbUserName = new System.Windows.Forms.TextBox();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnLongin = new DevExpress.XtraEditors.SimpleButton();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.hLDangky);
            this.groupControl1.Controls.Add(this.txbUserName);
            this.groupControl1.Controls.Add(this.txbPassword);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(35, 22);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(412, 169);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Thông tin đăng nhập";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(20, 126);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(136, 19);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Bạn chưa có tài khoản";
            // 
            // hLDangky
            // 
            this.hLDangky.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hLDangky.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hLDangky.Location = new System.Drawing.Point(182, 127);
            this.hLDangky.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hLDangky.Name = "hLDangky";
            this.hLDangky.Size = new System.Drawing.Size(51, 19);
            this.hLDangky.TabIndex = 5;
            this.hLDangky.Text = "Đăng ký";
            this.hLDangky.Click += new System.EventHandler(this.hLDangky_Click);
            // 
            // txbUserName
            // 
            this.txbUserName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbUserName.Location = new System.Drawing.Point(153, 32);
            this.txbUserName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbUserName.Name = "txbUserName";
            this.txbUserName.Size = new System.Drawing.Size(159, 26);
            this.txbUserName.TabIndex = 4;
            this.txbUserName.Text = "tranhieukk";
            // 
            // txbPassword
            // 
            this.txbPassword.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPassword.Location = new System.Drawing.Point(153, 80);
            this.txbPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.Size = new System.Drawing.Size(159, 26);
            this.txbPassword.TabIndex = 3;
            this.txbPassword.Text = "admin";
            this.txbPassword.UseSystemPasswordChar = true;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(20, 81);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(58, 19);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Mật khẩu";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(20, 33);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(89, 19);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Tên đăng nhập";
            // 
            // btnLongin
            // 
            this.btnLongin.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLongin.Appearance.Options.UseFont = true;
            this.btnLongin.Location = new System.Drawing.Point(94, 216);
            this.btnLongin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLongin.Name = "btnLongin";
            this.btnLongin.Size = new System.Drawing.Size(96, 28);
            this.btnLongin.TabIndex = 1;
            this.btnLongin.Text = "OK";
            this.btnLongin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnExit
            // 
            this.btnExit.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Appearance.Options.UseFont = true;
            this.btnExit.Location = new System.Drawing.Point(226, 216);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(96, 28);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Cancel";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 266);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLongin);
            this.Controls.Add(this.groupControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmLogin";
            this.Text = "ĐĂNG NHẬP";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.HyperlinkLabelControl hLDangky;
        private System.Windows.Forms.TextBox txbUserName;
        private System.Windows.Forms.TextBox txbPassword;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnLongin;
        private DevExpress.XtraEditors.SimpleButton btnExit;
    }
}