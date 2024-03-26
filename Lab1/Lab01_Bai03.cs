using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Lab01_Bai03 : Form
    {
        public Lab01_Bai03()
        {
            InitializeComponent();
        }

        private void tb1_num_TextChanged(object sender, EventArgs e)
        {
            if (tb1_num.Text == "")
                return;
            int num;
            string s = tb1_num.Text;
            bool ck = int.TryParse(s, out int result); // check kieu du lieu
            if (!ck)
            {
                MessageBox.Show("Vui lòng nhập số nguyên từ 0 - 9", "Warning");
                tb1_num.Text = "";
                return;
            }
            num = Int32.Parse(s.Trim()); // check dieu kien 0 - 9
            if (num < 0 || num > 9)
            {
                MessageBox.Show("Vui lòng nhập số nguyên từ 0 - 9", "Warning");
                tb1_num.Text = "";
            }

        }

        private void tb2_kq_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt1_Read_Click(object sender, EventArgs e)
        {
            if (tb1_num.Text == "" || tb1_num.Text == null)
            {
                MessageBox.Show("Vui lòng nhập số nguyên từ 0 - 9", "Warning");
                return;
            }
            int num = Int32.Parse(tb1_num.Text.Trim());
            switch (num)
            {
                case 0:
                    tb2_kq.Text = "Không";
                    break;
                case 1:
                    tb2_kq.Text = "Một";
                    break;
                case 2:
                    tb2_kq.Text = "Hai";
                    break;
                case 3:
                    tb2_kq.Text = "Ba";
                    break;
                case 4:
                    tb2_kq.Text = "Bốn";
                    break;
                case 5:
                    tb2_kq.Text = "Năm";
                    break;
                case 6:
                    tb2_kq.Text = "Sáu";
                    break;
                case 7:
                    tb2_kq.Text = "Bảy";
                    break;
                case 8:
                    tb2_kq.Text = "Tám";
                    break;
                case 9:
                    tb2_kq.Text = "Chín";
                    break;
            }
        }

        private void bt2__Click(object sender, EventArgs e)
        {
            tb1_num.Text = "";
            tb2_kq.Text = "";
        }

        private void bt3_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
