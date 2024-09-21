using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class Bo : GiaSuc
    {
        public override string Keu()
        {
            return "Bò kêu: Moo Moo!";
        }

        public override void ChoSua()
        {
            Random rnd = new Random();
            SoLuongSua = rnd.Next(0, 21); // Bò cho sữa từ 0 đến 20 lít
        }
        public override void SinhCon()
        {
            Random rnd = new Random();
            SoLuongCon = rnd.Next(0, 2);
        }

    }
}
 