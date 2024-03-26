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
    public partial class Lab01_Bai01 : Form
    {
        public Lab01_Bai01()
        {
            InitializeComponent();
        }

        private void tb_STT1_TextChanged(object sender, EventArgs e)
        {
            string s = tb_STT1.Text.Trim(); // ignore whitespace
            if (s.Length == 0)
                return;
            bool ck = false;
            ck = Int32.TryParse(s, out int result);
            if ((!ck) && (s != "-") && (s != ""))/// Warning if (tb = blank, not int, "-" for substract scenario)
            {
                MessageBox.Show("Xin mời nhập số nguyên!!!");
                tb_STT1.Text = "";
                return;
            }
        }

        private void tb_STT2_TextChanged(object sender, EventArgs e)
        {
            string s = tb_STT2.Text.Trim(); // ignore whitespace
            if (s.Length == 0)
                return;
            bool ck = false;
            ck = int.TryParse(s, out int result);
            if ((!ck) && (s != "-") && (s != ""))
            {
                MessageBox.Show("Xin mời nhập số nguyên!!!");
                tb_STT2.Text = "";
                return;
            }
        }

        private void Lb3_KQ_Click(object sender, EventArgs e)
        {
            
        }
        private void bt1_KQ_Click(Object sender, EventArgs e)
        {
            string s = tb_STT1.Text.Trim();
            bool ck = false;
            ck = int.TryParse(s, out int result);
            if ((!ck) && (tb_STT1.Text != "-"))
            {
                MessageBox.Show("Xin mời nhập số nguyên ô số 1!!!");
                return;
            }
            s = tb_STT2.Text.Trim();
            ck = int.TryParse(s, out result);
            if ((!ck) && (tb_STT2.Text != "-"))
            {
                MessageBox.Show("Xin mời nhập số nguyên ô số 2!!!");
                return;
            }
            int num1, num2;
            long sum = 0;
            num1 = Int32.Parse(tb_STT1.Text.Trim());
            num2 = Int32.Parse(tb_STT2.Text.Trim());
            sum = num1 + num2;
            tb_KQ.Text = sum.ToString();
            MessageBox.Show("      Kết quả:  " + sum.ToString(), "Kết quả");
        }
    }
   
}
