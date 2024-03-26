using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Lab01_Bai05 : Form
    {
        public Lab01_Bai05()
        {
            InitializeComponent();
        }

        private void tb1_A_TextChanged(object sender, EventArgs e)
        {
            string s = tb1_A.Text.Trim();
            if (s.Length == 0)
                return;
            bool ck = false;
            ck = int.TryParse(s, out int result);
            if ((!ck) && (s != "-") && (s != ""))
            {
                MessageBox.Show("Xin mời nhập số nguyên!!!");
                tb1_A.Text = "";
                return;
            }
        }

        private void tb2_B_TextChanged(object sender, EventArgs e)
        {
            string s = tb2_B.Text.Trim();
            if (s.Length == 0)
                return;
            bool ck = false;
            ck = int.TryParse(s, out int result);
            if ((!ck) && (s != "-") && (s != ""))
            {
                MessageBox.Show("Xin mời nhập số nguyên!!!");
                tb2_B.Text = "";
                return;
            }
        }

        private void bt1_Tinh_Click(object sender, EventArgs e)
        {
            cb1_CachTinh.SelectedItem = "";
            if (cb1_CachTinh.SelectedItem != null)
            {
                if (cb1_CachTinh.SelectedItem.ToString() == "Bảng cửu chương")
                {
                    // check truong hop ko co input hoac input ko du
                    string s = tb1_A.Text.Trim(); // check lai tb1 ( case: tb1 null)
                    bool ck = false;
                    ck = int.TryParse(s, out int result);
                    if ((!ck) && (tb1_A.Text != "-"))
                    {
                        MessageBox.Show("Xin mời nhập số nguyên ô số 1!!!");
                        return;
                    }
                    s = tb2_B.Text.Trim(); // check lai tb2 ( case: tb2 null ) 
                    ck = int.TryParse(s, out result);
                    if ((!ck) && (tb2_B.Text != "-"))
                    {
                        MessageBox.Show("Xin mời nhập số nguyên ô số 2!!!");
                        return;
                    }
                    // bang cuu chuong
                    int num1, num2;
                    long kq = 0;
                    num1 = Int32.Parse(tb1_A.Text.Trim());
                    num2 = Int32.Parse(tb2_B.Text.Trim());
                    kq = num2 - num1;
                    tb3_KQ.Text = "Phep tinh B - A = " + kq.ToString();
                    return;
                }
                // tinh gia tri
                if (cb1_CachTinh.SelectedItem.ToString() == "Tính toán giá trị")
                {
                    // check truong hop ko co input hoac input ko du
                    string s = tb1_A.Text.Trim(); // check lai tb1 ( case: tb1 null)
                    bool ck = false;
                    ck = int.TryParse(s, out int result);
                    if ((!ck) && (tb1_A.Text != "-"))
                    {
                        MessageBox.Show("Xin mời nhập số nguyên ô số 1!!!");
                        return;
                    }
                    s = tb2_B.Text.Trim(); // check lai tb2 ( case: tb2 null ) 
                    ck = int.TryParse(s, out result);
                    if ((!ck) && (tb2_B.Text != "-"))
                    {
                        MessageBox.Show("Xin mời nhập số nguyên ô số 2!!!");
                        return;
                    }
                    // tinh gia tri
                    int num1, num2;
                    long kq = 0;
                    num1 = Int32.Parse(tb1_A.Text.Trim());
                    num2 = Int32.Parse(tb2_B.Text.Trim());
                    kq = num1 - num2;
                    if (kq >= 0)
                    {
                        long i = kq;
                        kq = 1;
                        tb3_KQ.Text = "(A - B)! = " + i + "! = ";
                        for (; i > 0; i--) // giai thua
                        {
                            kq *= i;
                            tb3_KQ.Text += i.ToString();
                            if (i - 1 == 0)
                            {
                                tb3_KQ.Text += " = ";
                                break;
                            }
                            tb3_KQ.Text += "*";
                        }

                        tb3_KQ.Text += kq.ToString();
                    }
                    else
                        tb3_KQ.Text = "(A - B)! khong co ket qua";
                    tb3_KQ.AppendText(Environment.NewLine); // newline
                    tb3_KQ.Text += "S = ";
                    double kq1 = 0;
                    for (int i = 1; i <= num2; i++)
                    {
                        kq1 += Math.Pow(num1, i);
                        tb3_KQ.Text += num1.ToString() + "^" + i.ToString();
                        if (i == num2)
                        {
                            break;
                        }
                        tb3_KQ.Text += "+";
                    }
                    tb3_KQ.Text += " = " + Math.Round(kq1, 2).ToString();
                    return;
                }

                MessageBox.Show("Chon cach tinh!!", "Warning!!");
            }
            
        }

        private void bt2_Xoa_Click(object sender, EventArgs e)
        {
            tb1_A.Text = "";
            tb2_B.Text = "";
            tb3_KQ.Text = "";
            cb1_CachTinh.SelectedItem = " ";
        }

        private void bt3_Thoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
