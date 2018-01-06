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
using BUS;

namespace QuanLyDiem
{
    public partial class frmSinhVien : DevExpress.XtraEditors.XtraForm
    {
        string masinhvienOLd = null;
        private SinhVien sinhVien=null;
        public frmSinhVien()
        {
            InitializeComponent();
            loadLop();
            loadDsSV();
            loadGioiTinh();
            loadChinhSachUutien();
            cleartextbox();

        }
        void cleartextbox()
        {
            txbDiaChi.Text = "";
            txbHoTen.Text = "";
            txbMasV.Text = "";
            txbNgaySinh.Text = "";
            cbbChinhSach.SelectedIndex = -1;
            cbbGioiTinh.SelectedIndex = -1 ;
            cbbLop.SelectedIndex = -1 ;
            masinhvienOLd = null;

        }
        private void gridControl1_Click(object sender, EventArgs e)
        {
            foreach (int i in gridView1.GetSelectedRows())
            {
                DataRow row = gridView1.GetDataRow(i);
                txbMasV.Text = Convert.ToString(row[0]);
                txbHoTen.Text = Convert.ToString(row[1]);
                txbNgaySinh.Text = Convert.ToString(row[2]);
                cbbGioiTinh.SelectedIndex = cbbGioiTinh.FindString(Convert.ToString(row[3]));
                cbbLop.SelectedIndex = cbbLop.FindString(Convert.ToString(row[4]));
                txbDiaChi.Text = Convert.ToString(row[5]);
                cbbChinhSach.SelectedIndex = cbbChinhSach.FindString(Convert.ToString(row[6]));
                
            }
            masinhvienOLd = txbMasV.Text;

        }
        void loadLop()
        {
            cbbLop.DataSource = LopDAO.Instance.getAllData();
            cbbLop.DisplayMember = "Tên lớp";
            cbbLop.ValueMember = "Mã lớp";
        }
        void loadGioiTinh()
        {
            Dictionary<string, string> GT = new Dictionary<string, string>();
            GT.Add("1", "Nam");
            GT.Add("0", "Nữ");
          
            cbbGioiTinh.DataSource = new BindingSource(GT, null);
            cbbGioiTinh.DisplayMember = "Value";
            cbbGioiTinh.ValueMember = "Key";

        }
        void loadChinhSachUutien()
        {
            Dictionary<string, string> GT = new Dictionary<string, string>();
            GT.Add("0", "Không");
            GT.Add("1", "Có");

            cbbChinhSach.DataSource = new BindingSource(GT, null);
            cbbChinhSach.DisplayMember = "Value";
            cbbChinhSach.ValueMember = "Key";
        }
        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txbMasV.Text.Length < 1 || txbHoTen.Text.Length < 1 || cbbChinhSach.SelectedIndex == -1 || cbbGioiTinh.SelectedIndex == -1 || cbbLop.SelectedIndex == -1)
            {
                XtraMessageBox.Show("Bạn chưa nhập thông tin để thêm sinh viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string[] hovaten;
                hovaten = ChuanHoa.Instance.Chuoi(txbHoTen.Text).Split(' ');
                string ten = hovaten[hovaten.Length - 1];
                string ho = "";
                int i = 0;
                while (i < hovaten.Length - 1)
                {
                    ho += hovaten[i];
                    if (i < hovaten.Length - 1) ho += " ";
                    i++;
                }
                sinhVien = new SinhVien(txbMasV.Text, ho, ten, Convert.ToDateTime(txbNgaySinh.Text), cbbGioiTinh.SelectedValue.ToString(), Encoding.ASCII.GetBytes("0101010"), cbbLop.SelectedValue.ToString(), txbDiaChi.Text, cbbChinhSach.SelectedValue.ToString());
                SinhVienDAO.Instance.Insert(sinhVien);
                loadDsSV();
            }
        }
        private void loadDsSV()
        {
            grCSinhViens.DataSource = SinhVienDAO.Instance.SelectAll();
            cleartextbox();
            
        }
      /*  void unbinding()
        {
            txbMasV.DataBindings.Clear();
            txbHoTen.DataBindings.Clear();
            txbDiaChi.DataBindings.Clear();
            txbNgaySinh.DataBindings.Clear();
            cbbChinhSach.DataBindings.Clear();
            cbbGioiTinh.DataBindings.Clear();
            cbbLop.DataBindings.Clear();
        }
        void binding()
        {
            txbMasV.DataBindings.Add("Text",grCSinhViens.DataSource,"Mã sinh viên");
            txbHoTen.DataBindings.Add("Text", grCSinhViens.DataSource, "Họ và tên");
            txbDiaChi.DataBindings.Add("Text", grCSinhViens.DataSource, "Địa chỉ");
            txbNgaySinh.DataBindings.Add("Text", grCSinhViens.DataSource, "Ngày sinh");
            cbbChinhSach.DataBindings.Add("Text", grCSinhViens.DataSource, "Chính sách ưu tiên");
            cbbGioiTinh.DataBindings.Add("Text", grCSinhViens.DataSource, "Giới tính");
            cbbLop.DataBindings.Add("Text", grCSinhViens.DataSource, "Lớp");
        }*/
        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txbMasV.Text.Length < 1 || txbHoTen.Text.Length < 1)
            {
                XtraMessageBox.Show("Bạn chưa nhập đủ thông tin sinh viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string[] hovaten;

                hovaten = ChuanHoa.Instance.Chuoi(txbHoTen.Text).Split(' ');
                string ten = hovaten[hovaten.Length - 1];
                string ho = "";
                int i = 0;
                while (i < hovaten.Length - 1)
                {
                    ho += hovaten[i];
                    if (i < hovaten.Length - 1) ho += " ";
                    i++;
                }

                sinhVien = new SinhVien(txbMasV.Text, ho, ten, Convert.ToDateTime(txbNgaySinh.Text), cbbGioiTinh.SelectedValue.ToString(), Encoding.ASCII.GetBytes("0101010"), cbbLop.SelectedValue.ToString(), txbDiaChi.Text, cbbChinhSach.SelectedValue.ToString());
                SinhVienDAO.Instance.Update(sinhVien, masinhvienOLd);
                loadDsSV();
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            cleartextbox();

        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txbMasV.Text.Length < 1 )
            {
                XtraMessageBox.Show("Bạn chưa chọn sinh viên cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                DialogResult dlr;
                dlr = XtraMessageBox.Show("Bạn có muốn xóa sinh viên " + txbHoTen.Text + "?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlr == DialogResult.Yes)
                {
                    SinhVien sv = new SinhVien();
                    sv.MaSinhVien = txbMasV.Text;

                    SinhVienDAO.Instance.Remove(sv);
                    lbThongBao.Text = "Thông báo: Đã xóa sinh viên: " + txbHoTen.Text;
                    loadDsSV();



                }
            }
        }
    }
}