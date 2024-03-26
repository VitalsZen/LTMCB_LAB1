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
    public partial class Lab01_Bai06 : Form
    {
        public Lab01_Bai06()
        {
            InitializeComponent();
        }

        private void bt1_Find_Click(object sender, EventArgs e)
        {
            int ngay = dtb1_Input.Value.Day;
            int thang = dtb1_Input.Value.Month;
            int nam = dtb1_Input.Value.Year;
            switch (thang)
            {
                case 1:
                    if (ngay < 21)
                        tb1_Answer.Text = "Cung Ma Kết";
                    else
                        tb1_Answer.Text = "Cung Bảo Bình";
                    break;
                case 2:
                    if (ngay < 20)
                        tb1_Answer.Text = "Cung Bảo Bình";
                    else
                        tb1_Answer.Text = "Cung Song Ngư";
                    break;
                case 3:
                    if (ngay < 21)
                        tb1_Answer.Text = "Cung Song Ngư";
                    else
                        tb1_Answer.Text = "Cung Bạch Dương";
                    break;
                case 4:
                    if (ngay < 20)
                        tb1_Answer.Text = "Cung Bạch Dương";
                    else
                        tb1_Answer.Text = "Cung Kim Ngưu";
                    break;
                case 5:
                    if (ngay < 22)
                        tb1_Answer.Text = "Cung Kim Ngưu";
                    else
                        tb1_Answer.Text = "Cung Song Tử";
                    break;
                case 6:
                    if (ngay < 22)
                        tb1_Answer.Text = "Cung Song Tử";
                    else
                        tb1_Answer.Text = "Cung Cự Giải";
                    break;
                case 7:
                    if (ngay < 23)
                        tb1_Answer.Text = "Cung Cự Giải";
                    else
                        tb1_Answer.Text = "Cung Sư Tử";
                    break;
                case 8:
                    if (ngay < 23)
                        tb1_Answer.Text = "Cung Sư Tử";
                    else
                        tb1_Answer.Text = "Cung Xử Nữ";
                    break;
                case 9:
                    if (ngay < 24)
                        tb1_Answer.Text = "Cung Xử Nữ";
                    else
                        tb1_Answer.Text = "Cung Thiên Bình";
                    break;
                case 10:
                    if (ngay < 24)
                        tb1_Answer.Text = "Cung Thiên Bình";
                    else
                        tb1_Answer.Text = "Cung Thần Nông";
                    break;
                case 11:
                    if (ngay < 23)
                        tb1_Answer.Text = "Cung Thần Nông";
                    else
                        tb1_Answer.Text = "Cung Nhân Mã";
                    break;
                case 12:
                    if (ngay < 22)
                        tb1_Answer.Text = "Cung Nhân Mã";
                    else
                        tb1_Answer.Text = "Cung Ma Kết";
                    break;
            }
            MessageBox.Show("Đã bói quẻ xong cung mệnh!!", "Cung mệnh của bạn");
        }

        private void bt3_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tb1_Answer_TextChanged(object sender, EventArgs e)
        {
            if (tb1_Answer.Text != "")
                bt2_Reset.Enabled = true;
            else 
                bt2_Reset.Enabled = false;
        }

        private void bt2_Reset_Click(object sender, EventArgs e)
        {
            tb1_Answer.Text = "";
            dtb1_Input.Value = DateTime.Now;
        }
    }
}
