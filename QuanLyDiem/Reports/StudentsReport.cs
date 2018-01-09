using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;

namespace QuanLyDiem.Reports
{
    public partial class StudentsReport : DevExpress.XtraReports.UI.XtraReport
    {
        public StudentsReport()
        {
            InitializeComponent();
        }
        public void initData(string Lop, string khoa , List<DTO.Student> liststd)
        {
            prNameClass.Value = Lop;
            prKhoaName.Value = khoa;
          objectDataSource1.DataSource = liststd;


        }
    }
}
