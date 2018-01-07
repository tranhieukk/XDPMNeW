using BUS;
using DevExpress.XtraGrid.Views.Grid;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDiem
{
    public partial class frmHeDaoTao : Form
    {
        private static HeDaoTao heDaoTao;
        private static string maHeDaoTaoOld;
        public frmHeDaoTao()
        {
            InitializeComponent();
            loadHeDaoTao();
            gridView1.CustomDrawRowIndicator += gridView1_CustomDrawRowIndicator;

        }
        void gridView1_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator)
            {
                if (e.RowHandle < 0)
                {
                    e.Info.ImageIndex = 0;
                    e.Info.DisplayText = String.Empty;
                }
                else
                {
                    e.Info.ImageIndex = -1;
                    e.Info.DisplayText = (e.RowHandle + 1).ToString();
                }
                SizeF sizeF = e.Graphics.MeasureString(e.Info.DisplayText, e.Appearance.Font);
                Int32 width = Convert.ToInt32(sizeF.Width) + 10;
                BeginInvoke(new MethodInvoker(delegate { cal(width, gridView1); }));
            }

        }
        bool cal(Int32 width, GridView _View)
        {
            _View.IndicatorWidth = _View.IndicatorWidth < width ? width : _View.IndicatorWidth;
            return true;
        }
        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            heDaoTao = new HeDaoTao(txtMaHe.Text,txtTenHe.Text);
            if(BUS.HeDaoTaoDAO.Instance.Insert(heDaoTao) > 0)
            {
                loadHeDaoTao();
                clear();
            }
        }

        private void loadHeDaoTao()
        {
            gvHeDaoTao.DataSource = HeDaoTaoDAO.Instance.GetTableHeDaoTao();
        }

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            heDaoTao = new HeDaoTao(txtMaHe.Text, txtTenHe.Text);
            if (BUS.HeDaoTaoDAO.Instance.Update(heDaoTao,maHeDaoTaoOld) > 0)
            {
                loadHeDaoTao();
                clear();
            }
        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            heDaoTao = new HeDaoTao(txtMaHe.Text, txtTenHe.Text);
            if (BUS.HeDaoTaoDAO.Instance.Remove(heDaoTao) > 0)
            {
                loadHeDaoTao();
                clear();
            }
        }
        void clear()
        {
            txtMaHe.Text = "";
            txtTenHe.Text = "";
            
          
        }

        private void btnReset_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            clear();
        }

        private void gvHeDaoTao_Click(object sender, EventArgs e)
        {
            foreach (int i in gridView1.GetSelectedRows())
            {
                DataRow row = gridView1.GetDataRow(i);
                txtMaHe.Text = Convert.ToString(row[0]);
                txtTenHe.Text = Convert.ToString(row[1]);

            }


            maHeDaoTaoOld = txtMaHe.Text;

        }
    }
}
