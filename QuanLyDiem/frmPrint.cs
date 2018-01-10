using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DTO;
using QuanLyDiem.Reports;

namespace QuanLyDiem
{
    public partial class frmPrint : DevExpress.XtraEditors.XtraForm
    {
        public frmPrint()
        {
            InitializeComponent();
        }
       public void printDSSVLop(string Lop,string khoa, List<DTO.Student> data)
        {
            StudentsReport studentsReport = new StudentsReport();
            foreach(DevExpress.XtraReports.Parameters.Parameter p in studentsReport.Parameters)
            {
                p.Visible = true;
            }
            studentsReport.initData(Lop, khoa, data);
            documentViewer1.DocumentSource = studentsReport;
            studentsReport.CreateDocument();
            
        }
        public void printDSMonHoc(string Lop, string khoa, List<DTO.RpMonHoc> data)
        {
            ReportMonHoc Report = new ReportMonHoc();
            foreach (DevExpress.XtraReports.Parameters.Parameter p in Report.Parameters)
            {
                p.Visible = true;
            }
            Report.initData(Lop, khoa, data);
            documentViewer1.DocumentSource = Report;
            Report.CreateDocument();

        }
        public void printDSDiemCaNhan(DTO.StudentDetail sv, List<DTO.rpDiemMonHoc> data)
        {
            rpDiemCaNhan Report = new rpDiemCaNhan();
            foreach (DevExpress.XtraReports.Parameters.Parameter p in Report.Parameters)
            {
                p.Visible = true;
            }
            Report.initData(sv, data);
            documentViewer1.DocumentSource = Report;

            Report.CreateDocument();

        }
        public void printDHB(string khoa,DTO.rpThongTin rp, List<DTO.rpHocBong> data)
        {
            Reports.rpHocBong Report = new Reports.rpHocBong();
            foreach (DevExpress.XtraReports.Parameters.Parameter p in Report.Parameters)
            {
                p.Visible = true;
            }
            Report.initData(khoa,rp, data);
            documentViewer1.DocumentSource = Report;

            Report.CreateDocument();

        }
    }
}