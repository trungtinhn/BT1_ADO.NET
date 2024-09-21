using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{   
    public class De : GiaSuc
    {
        public override string Keu()
        {
            return "Dê kêu: Eéé!";
        }

        public override void ChoSua()
        {
            Random rnd = new Random();
            SoLuongSua = rnd.Next(0, 11);
        }
        public override void SinhCon() 
        { 
            Random rnd = new Random();
            SoLuongCon = rnd.Next(0, 3);
        }
    }
}
