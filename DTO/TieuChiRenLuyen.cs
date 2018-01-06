using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class TieuChiRenLuyen
    {
        string maTieuChi;
        string tenTieuChi;
        int mucDiem;
        public TieuChiRenLuyen(string maTieuChi, string tenTieuChi, string mucDiem)
        {

            MaTieuChi = maTieuChi;          
            TenTieuChi = tenTieuChi;
            MucDiem = int.Parse(mucDiem);
        }
       
        public string MaTieuChi { get => maTieuChi; set => maTieuChi = value; }
        public string TenTieuChi { get => tenTieuChi; set => tenTieuChi = value; }
        public int MucDiem { get => mucDiem; set => mucDiem = value; }
    }
}
