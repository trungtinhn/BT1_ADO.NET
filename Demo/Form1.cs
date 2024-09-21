using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Demo
{
    public partial class Form1 : Form
    {
        private GiaSucBLL giaSucBLL = new GiaSucBLL();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            List<GiaSuc> giaSucList = new List<GiaSuc>
        {
            new Bo { SoLuong = int.Parse(txt_Bo.Text) },
            new Cuu { SoLuong = int.Parse(txt_Cuu.Text) },
            new De { SoLuong = int.Parse(txt_De.Text) }
        };

            foreach (var giaSuc in giaSucList)
            {
                giaSucBLL.SinhConVaChoSua(giaSuc);
                MessageBox.Show(giaSuc.Keu());
            }

            lbl_KetQua.Text = $"Bò: {giaSucList[0].SoLuong} con, {giaSucList[0].SoLuongSua} lít sữa\n" +
                             $"Cừu: {giaSucList[1].SoLuong} con, {giaSucList[1].SoLuongSua} lít sữa\n" +
                             $"Dê: {giaSucList[2].SoLuong} con, {giaSucList[2].SoLuongSua} lít sữa";
        }
    }
}
