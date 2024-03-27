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
    public partial class Lab01_Bai07 : Form
    {
        public Lab01_Bai07()
        {
            InitializeComponent();
        }

        string[] substrings = new string[] { };
        private void tb1_Input_TextChanged(object sender, EventArgs e)
        {
            substrings = tb1_Input.Text.Split(',');
        }

        private void bt1_Input_Click(object sender, EventArgs e)
        {
            // Name + Score
            bool ck = false;
            string specialChar = @"\|!#$%&/()=?»«@£§€{}.-;'<>_,""0123456789^/+-*:]["; // loại special char trong nhập tên
            foreach (char c in specialChar) // check char đặc biệt 
            {
                if (substrings[0].Contains(c) == false)
                    continue;
                MessageBox.Show("Nhap sai format", "Warning");
                tb1_Input.Text = "";
                tb3_Score.Text = "";
                tb2_Name.Text = "";
                return;
            }
            tb2_Name.Text = substrings[0].Trim();
            ck = double.TryParse(substrings[0], out double result);
            if ((ck) || (substrings.Length < 2)) // check khi thieu ten/ chi ghi ten 
            {
                MessageBox.Show("Nhap sai format", "Warning");
                tb1_Input.Text = "";
                tb3_Score.Text = "";
                tb2_Name.Text = "";
                return;
            }
            double DTB = 0;
            double MAX = 10;
            double MIN = 0;
            int passed = 0;
            int check = 5;
            for (int i = 1; i < substrings.Length; i++)
            {
                ck = double.TryParse(substrings[i], out result);
                if (!ck || result < 0 || result > 10)
                {
                    MessageBox.Show("Nhap sai format", "Warning");
                    tb1_Input.Text = "";
                    tb3_Score.Text = "";
                    tb2_Name.Text = "";
                    return;
                }
                tb3_Score.Text += "Môn " + i.ToString() + ": " + result.ToString().Trim() + "   ";
                DTB += result;
                if (result > MAX)
                    MAX = result;
                if (result < MIN)
                    MIN = result;
                if (result >= 5)
                    passed++;
                if (result < 2)
                {
                    if (check > 1)
                        check = 1;
                }
                else if (result < 3.5)
                {
                    if (check > 2)
                        check = 2;
                }
                else if (result < 5)
                {
                    if (check > 3)
                        check = 3;
                }
                else if (result < 6.5)
                {
                    if (check > 4)
                        check = 4;
                }

            }

            // DTB,MAX,MIN
            tb4_DTB.Text = (DTB / (substrings.Length - 1)).ToString();
            tb5_Max.Text = MAX.ToString();
            tb6_Min.Text = MIN.ToString();
            tb7_Passed.Text = passed.ToString();
            tb8_Failed.Text = (substrings.Length - passed - 1).ToString();
            switch (check)
            {
                case 5:
                    if (DTB < 3.5)
                        tb9_Xeploai.Text = "Kém";
                    else if (DTB < 5)
                        tb9_Xeploai.Text = "Yếu";
                    else if (DTB < 6.5)
                        tb9_Xeploai.Text = "TB";
                    else if (DTB < 8)
                        tb9_Xeploai.Text = "Khá";
                    else tb9_Xeploai.Text = "Giỏi";
                    break;
                case 4:
                    if (DTB < 3.5)
                        tb9_Xeploai.Text = "Kém";
                    else if (DTB < 5)
                        tb9_Xeploai.Text = "Yếu";
                    else if (DTB < 6.5)
                        tb9_Xeploai.Text = "TB";
                    else
                        tb9_Xeploai.Text = "Khá";
                    break;
                case 3:
                    if (DTB < 3.5)
                        tb9_Xeploai.Text = "Kém";
                    else if (DTB < 5)
                        tb9_Xeploai.Text = "Yếu";
                    else
                        tb9_Xeploai.Text = "TB";
                    break;
                case 2:
                    if (DTB < 3.5)
                        tb9_Xeploai.Text = "Kém";
                    else
                        tb9_Xeploai.Text = "Yếu";
                    break;
                case 1:
                    tb9_Xeploai.Text = "Kém";
                    break;
            }
        }

        private void bt2_Reset_Click(object sender, EventArgs e)
        {
            foreach (var textbox in this.Controls.OfType<TextBox>()) // blank all textbox
                textbox.Text = "";
        }

        private void bt3_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
