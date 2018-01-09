using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;

namespace QuanLyDiem.Reports
{
    public partial class rpDiemCaNhan : DevExpress.XtraReports.UI.XtraReport
    {
        public rpDiemCaNhan()
        {
            InitializeComponent();
        }
        public void initData(DTO.StudentDetail sv, List<DTO.rpDiemMonHoc> data)
        {
            pfullName.Value = sv.FullName;
            pgender.Value = sv.Gender;
            phedaotao.Value = sv.TrainingSystem;
            pkhoahoc.Value = sv.Course;
            pchuyennganh.Value = sv.Specialized;
            pclass.Value = sv.Class;
            proot.Value = sv.Root;
            pdateofbirth.Value = sv.DateOfBirth;

            objectDataSource1.DataSource = data;


        }
    }
}
