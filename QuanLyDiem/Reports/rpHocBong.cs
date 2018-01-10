using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DTO;
using System.Collections.Generic;

namespace QuanLyDiem.Reports
{
    public partial class rpHocBong : DevExpress.XtraReports.UI.XtraReport
    {
        public rpHocBong()
        {
            InitializeComponent();
        }
        public void initData (string tenKhoa,rpThongTin tt, List<DTO.rpHocBong> data)
        {
            pkhoa.Value = tenKhoa;
            pchuyennganh.Value = tt.chuyenNganh;
            phedaotao.Value = tt.hedaotao;
            phocky.Value = tt.hocky;
            pnamHoc.Value = tt.namHoc;

            objectDataSource1.DataSource = data;
        }
    }
}
