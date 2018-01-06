using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using DTO;

namespace QuanLyDiem
{
    static class Program
    {
        private static string username;
        private static List<ChiTietQuyenHan> listPermision;

        public static string Username { get => username; set => username = value; }
        public static List<ChiTietQuyenHan> ListPermision { get => listPermision; set => listPermision = value; }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BonusSkins.Register();
            SkinManager.EnableFormSkins();
            Application.Run(new frmMenu());
        }
    }
}
