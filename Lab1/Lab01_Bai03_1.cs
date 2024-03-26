using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Lab01_Bai03_1 : Form
    {
        public Lab01_Bai03_1()
        {
            InitializeComponent();
        }
        static string[] ChuSo = { "", "Một", "Hai", "Ba", "Bốn", "Năm", "Sáu", "Bảy", "Tám", "Chín" };
        static string[] DonVi = { " Tỉ", " Triệu", " Nghìn", " " };

        static string DocSo(int so) // đọc cụm 3 chữ số ( xét trường hợp 3/2/1 chữ số )
        {
            if (so == 0)
                return "Không";
            if (so < 10)
                return ChuSo[so];
            string str = "";
            if (so >= 100)
            {
                str += ChuSo[(so) / 100] + " Trăm ";
                so %= 100;
            }
            if (so >= 10)
            {
                if (so >= 20)
                {
                    str += ChuSo[(so) / 10] + " Mươi ";
                    so %= 10;
                }
                if (so > 10)
                {
                    str += " Mười ";
                    so %= 10;
                }
            }
            if (so > 0)
            {
                str += ChuSo[(so)];
            }
            return str;
        }
        private void bt1_Read_Click(object sender, EventArgs e)
        {
            string s = tb1_num.Text.Trim();
            bool ck = long.TryParse(s, out long result); // check kieu du lieu
            if (!ck || result < 100000000000 || result > 999999999999)
            {
                MessageBox.Show("Vui lòng nhập số có 12 chữ số", "Warning");
                tb1_num.Text = "";
                return;
            }

            string chuoi = "";
            for (int i = 0; i < 4; i++)
            {
                int so = int.Parse(s.Substring(i * 3, 3));
                if (so > 0)
                {
                    chuoi += DocSo(so) + DonVi[i] + ", ";

                }


            }
            for (int i = chuoi.Length - 1; i >= 0; i--)
            {
                if (chuoi[i] == ',')
                {
                    chuoi = chuoi.Remove(i, 1);
                    break;
                }
            }
            chuoi = chuoi.Trim();
            tb2_kq.Text = chuoi;

        }



        private void tb1_num_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt3_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt2_Reset_Click(object sender, EventArgs e)
        {
            tb1_num.Text = "";
            tb2_kq.Text = "";
        }
    }
}
