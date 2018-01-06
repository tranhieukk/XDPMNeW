using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ChuanHoa
    {
        private static ChuanHoa instance;

        public static ChuanHoa Instance {
            get { if (instance == null) instance = new ChuanHoa(); return instance; }
           private set => instance = value; }

        public string Chuoi(string str)
        {
            CultureInfo cultureInfo = new CultureInfo("vi-VN");
            TextInfo textInfo = cultureInfo.TextInfo;
            str = textInfo.ToLower(str);
            // Replace multiple white space to 1 white  space
            str = System.Text.RegularExpressions.Regex.Replace(str, @"\s{2,}", " ");
            //Upcase like Title
            return textInfo.ToTitleCase(str);
        }

    }
}
