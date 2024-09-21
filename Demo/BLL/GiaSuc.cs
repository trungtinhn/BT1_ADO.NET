using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public abstract class GiaSuc
    {
        public string LoaiGiaSuc { get; set; }
        public int SoLuong { get; set; }
        public float SoLuongSua { get; set; }
        public int SoLuongCon { get; set; }

        public abstract string Keu(); // Tiếng kêu khi đói

        public abstract void SinhCon(); // Phương thức sinh con

        public abstract void ChoSua(); // Phương thức cho sữa
    }
}
