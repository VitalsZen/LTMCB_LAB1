﻿using System;
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
    public partial class Lab01_Bai02 : Form
    {
        public Lab01_Bai02()
        {
            InitializeComponent();
        }


        private void bt1_Find_Click(object sender, EventArgs e)
        {
            double num1 = Double.Parse(tb1_S1.Text.Trim()),
                num2 = Double.Parse(tb2_S2.Text.Trim()),
                num3 = Double.Parse(tb3_S3.Text.Trim());
            double max = num1;
            if (num2 > max)
                max = num2;
            if (num3 > max)
                max = num3;
            double min = num1;
            if (num2 < min)
                min = num2;
            if (num3 < min)
                min = num3;
            tb5_min.Text = min.ToString();
            tb4_max.Text = max.ToString();
            MessageBox.Show("  Tìm thành công");
        }

        private void tb1_S1_TextChanged(object sender, EventArgs e)
        {
            if (tb1_S1.Text == " ")
                return;
            string s = tb1_S1.Text;
            bool ck = false;
            ck = double.TryParse(s, out double result);
            if ((!ck) && (tb1_S1.Text != "-") && (tb1_S1.Text != "") )
            {
                MessageBox.Show("Xin mời nhập số bất kì!!!");
                return;
            }
        }

        private void tb2_S2_TextChanged(object sender, EventArgs e)
        {
            string s = tb2_S2.Text;
            bool ck = false;
            ck = double.TryParse(s, out double result);
            if ((!ck) && (tb2_S2.Text != "-") && (tb2_S2.Text != ""))
            {
                MessageBox.Show("Xin mời nhập số bất kì!!!");
                return;
            }
        }

        private void tb3_S3_TextChanged(object sender, EventArgs e)
        {
            string s = tb2_S2.Text;
            bool ck = false;
            ck = double.TryParse(s, out double result);
            if ((!ck) && (tb3_S3.Text != "-") && (tb3_S3.Text != ""))
            {
                MessageBox.Show("Xin mời nhập số bất kì!!!");
                return;
            }
        }

        private void bt2_Xoa_Click(object sender, EventArgs e)
        {
            tb1_S1.Text = "";
            tb2_S2.Text = "";
            tb3_S3.Text = ""; 
        }

        private void bt3_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
