using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class Cuu: GiaSuc
    {
        public override string Keu()
        {
            return "Cừu kêu: Bêêê!";
        }

        public override void ChoSua()
        {
            Random rnd = new Random();
            SoLuongSua = rnd.Next(0, 6); // Cừu cho sữa từ 0 đến 5 lít
        }
        public override void SinhCon()
        {
            Random rnd = new Random();
            SoLuongCon = rnd.Next(0, 3);
        }
    }
}
