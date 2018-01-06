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
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Drawing.Imaging;

namespace QuanLyDiem
{
  

    public partial class frmKhoa : DevExpress.XtraEditors.XtraForm

    {
        private static Khoa khoaSelected = new Khoa();
        public frmKhoa()
        {
            InitializeComponent();
            loadDSKhoa();
        }
        #region btnClick
        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string maKhoa = txbMaKhoa.Text;
            string tenKhoa = txbKhoa.Text;
            KhoaDAO.Instance.addKhoa(maKhoa, tenKhoa);
            loadDSKhoa();
        }

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string maKhoa = txbMaKhoa.Text;
            string tenKhoa = txbKhoa.Text;
            if( KhoaDAO.Instance.editKhoa(khoaSelected.MaKhoa,maKhoa, tenKhoa)>0)
            {
                loadDSKhoa();
                khoaSelected.MaKhoa = maKhoa;
                khoaSelected.TenKhoa = tenKhoa;

            }
            
        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string maKhoa = txbMaKhoa.Text;
            
            if (KhoaDAO.Instance.removeKhoa(maKhoa) >0)
            {
                loadDSKhoa();
                khoaSelected.MaKhoa = "";
                khoaSelected.TenKhoa = "";
                txbMaKhoa.Text = "";
                txbKhoa.Text = "";

            }
        }

        private void btnReset_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txbKhoa.Text = "";
            txbMaKhoa.Text = "";
        }
        #endregion
        #region method
        void loadDSKhoa()
        {
            Controls.RemoveByKey("flpKhoas");
            flpKhoas = new FlowLayoutPanel();
            flpKhoas.AutoScroll = true;
            flpKhoas.Location = new Point(14, 151);
            flpKhoas.Name = "flpKhoas";
            flpKhoas.Size = new Size(700, 350);
            flpKhoas.TabIndex = 11;
            Controls.Add(flpKhoas);
            List<Khoa> dsKhoa = KhoaDAO.Instance.loadAllKhoa();
            foreach (Khoa item in dsKhoa)
            {

                Button btn = new Button()
                {
                    Width = KhoaDAO.width,
                    Height = KhoaDAO.height
                };
                btn.Text = item.TenKhoa;
                btn.Name = item.MaKhoa;
                btn.Click += new System.EventHandler(this.Khoa_click);
              
               
                flpKhoas.Controls.Add(btn);
            }

           
        }
        public Image byteArrayToImage(byte[] bytesArr)
        {


            MemoryStream memstr = new MemoryStream(bytesArr);
            Image img = Image.FromStream(memstr);
            return img;

        }

        private byte[] GetBitmapFromByteArray(Object obj)
        {
            if (obj == null)
                return null;

            BinaryFormatter bf = new BinaryFormatter();
            MemoryStream ms = new MemoryStream();
            bf.Serialize(ms, obj);

            return ms.ToArray();
        }
     /*   public Bitmap GetBitmapFromByteArray(byte[] bmp)
        {
            System.IO.MemoryStream ms = new System.IO.MemoryStream(bmp);
            Bitmap btMap = (Bitmap)System.Drawing.Image.FromStream(ms);
            ms.Close();

            return btMap;
        }*/
        private void Khoa_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            khoaSelected.MaKhoa=b.Name;
            khoaSelected.TenKhoa = b.Text;

            txbMaKhoa.Text = khoaSelected.MaKhoa;
            txbKhoa.Text = khoaSelected.TenKhoa;


        }
        #endregion
        byte[] ReadFile(string sPath)
        {
            //Initialize byte array with a null value initially.
            byte[] data = null;

            //Use FileInfo object to get file size.
            FileInfo fInfo = new FileInfo(sPath);
            long numBytes = fInfo.Length;

            //Open FileStream to read file
            FileStream fStream = new FileStream(sPath, FileMode.Open, FileAccess.Read);

            //Use BinaryReader to read file stream into byte array.
            BinaryReader br = new BinaryReader(fStream);

            //When you use BinaryReader, you need to supply number of bytes 
            //to read from file.
            //In this case we want to read entire file. 
            //So supplying total number of bytes.
            data = br.ReadBytes((int)numBytes);

            return data;
        }
        private void btnAddLogo_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "All Files|*.*|Bitmaps|*.bmp|GIFs|*.gif|JPEGs|*.jpg|*.png|";
            openFileDialog1.FilterIndex = 7;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                  
                    byte[] imageData = ReadFile(openFileDialog1.FileName);
                    
                    

                  
                    string qry = "exec USP_addLogo @maKhoa , @img )";
                    KhoaDAO.Instance.addLogo(txbMaKhoa.Text,imageData);
          
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }
    }
}