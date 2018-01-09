using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using System.Data;

namespace QuanLyDiem.Reports
{
    public partial class ReportMonHoc : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportMonHoc()
        {
            InitializeComponent();
        }
        public void initData(string Lop, string khoa, List<DTO.RpMonHoc> data)
        {
            pLop.Value = Lop;
            pkhoa.Value = khoa;
            objectDataSource1.DataSource = data;


        }
    }
}
