using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Pkcs;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.Collections.Generic;
using System.CodeDom.Compiler;

namespace Lab1
{
    public partial class Lab01_Bai04 : Form
    {
        Dictionary<string, HashSet<string>> test = new Dictionary<string, HashSet<string>>();
        Dictionary<string, HashSet<string>> Mai = new Dictionary<string, HashSet<string>>();
        Dictionary<string, HashSet<string>> GLCB = new Dictionary<string, HashSet<string>>();
        Dictionary<string, HashSet<string>> Tarot = new Dictionary<string, HashSet<string>>();
        Dictionary<string, HashSet<string>> DPP = new Dictionary<string, HashSet<string>>();
        HashSet<string> temp = new HashSet<string>();

        static int check = 0;
        static double cost = 0;
        public Lab01_Bai04()
        {
            InitializeComponent();
            temp = new HashSet<string> { "A1", "A2", "A3", "A4", "A5", "B1", "B2", "B3", "B4", "B5", "C1", "C2", "C3", "C4", "C5" };
            Mai.Add("P2", new HashSet<string>() { "A1", "A2", "A3", "A4", "A5", "B1", "B2", "B3", "B4", "B5", "C1", "C2", "C3", "C4", "C5" });
            Mai.Add("P3", new HashSet<string>() { "A1", "A2", "A3", "A4", "A5", "B1", "B2", "B3", "B4", "B5", "C1", "C2", "C3", "C4", "C5" });

            DPP.Add("P1", new HashSet<string>() { "A1", "A2", "A3", "A4", "A5", "B1", "B2", "B3", "B4", "B5", "C1", "C2", "C3", "C4", "C5" });
            DPP.Add("P2", new HashSet<string>() { "A1", "A2", "A3", "A4", "A5", "B1", "B2", "B3", "B4", "B5", "C1", "C2", "C3", "C4", "C5" });
            DPP.Add("P3", new HashSet<string>() { "A1", "A2", "A3", "A4", "A5", "B1", "B2", "B3", "B4", "B5", "C1", "C2", "C3", "C4", "C5" });

            GLCB.Add("P1", new HashSet<string>() { "A1", "A2", "A3", "A4", "A5", "B1", "B2", "B3", "B4", "B5", "C1", "C2", "C3", "C4", "C5" });

            Tarot.Add("P3", new HashSet<string>() { "A1", "A2", "A3", "A4", "A5", "B1", "B2", "B3", "B4", "B5", "C1", "C2", "C3", "C4", "C5" });
            //test.Add("P2", new HashSet<string>() { "A1", "A2", "A3", "A4", "A5", "B1", "B2", "B3", "B4", "B5", "C1", "C2", "C3", "C4", "C5" });
            //test.Add("P3", new HashSet<string>() { "A1", "A2", "A3", "A4", "A5", "B1", "B2", "B3", "B4", "B5", "C1", "C2", "C3", "C4", "C5" });
            //Mai.Remove("P1");
            //GLCB.Remove("P2");
            //GLCB.Remove("P3");
            //Tarot.Remove("P2");
            //Tarot.Remove("P1");
        }


        private void cb2_Movie_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cb1_Theater.Items.Clear();
            cb1_Theater.Items.AddRange(new object[] { "P1", "P2", "P3" });
            if (cb2_Movie.SelectedText != null)
            {
                switch (cb2_Movie.SelectedItem)
                {
                    case "Mai":
                        cb1_Theater.Items.Remove("P1");
                        check = 1;
                        cost = 100000;
                        break;
                    case "Đào, phở và piano":
                        check = 2;
                        cost = 45000;
                        break;
                    case "Gặp lại chị bầu":
                        cb1_Theater.Items.Remove("P2");
                        cb1_Theater.Items.Remove("P3");
                        check = 3;
                        cost = 70000;
                        break;
                    case "Tarot":
                        cb1_Theater.Items.Remove("P2");
                        cb1_Theater.Items.Remove("P1");
                        check = 4;
                        cost = 90000;
                        break;
                    default:
                        break;
                }
                MessageBox.Show("Chọn phòng chiếu và chỗ ngồi");
                cb1_Theater.Enabled = true;
            }
            else
                check = 0;
        }

        private void cb1_Movie_SelectionChangeCommitted(Object sender, EventArgs e)
        {
            clb1_Seats.Items.Clear();
            string s = cb1_Theater.SelectedItem.ToString();
            cb1_Theater.Text = "";
            bool ck = true;
            HashSet<string> set = new HashSet<string> { };
            if (check == 1) // xét csdl hiện có và hiện những seats hiện có trong csdl
            {
                ck = Mai.TryGetValue(s, out set);
                if (set != null)
                {
                    foreach (string c in set)
                    {
                        if (new[] { "A1", "A2", "A3", "A4", "A5", "B1", "B2", "B3", "B4", "B5", "C1", "C2", "C3", "C4", "C5" }.Contains(c))
                            clb1_Seats.Items.Add(c);
                    }
                }
            }
            else if (check == 2)
            {
                ck = DPP.TryGetValue(s, out set);
                if (set != null)
                {
                    foreach (string c in set)
                    {
                        if (new[] { "A1", "A2", "A3", "A4", "A5", "B1", "B2", "B3", "B4", "B5", "C1", "C2", "C3", "C4", "C5" }.Contains(c))
                            clb1_Seats.Items.Add(c);
                    }
                }
            }
            else if (check == 3)
            {
                ck = GLCB.TryGetValue(s, out set);
                if (set != null)
                {
                    foreach (string c in set)
                    {
                        if (new[] { "A1", "A2", "A3", "A4", "A5", "B1", "B2", "B3", "B4", "B5", "C1", "C2", "C3", "C4", "C5" }.Contains(c))
                            clb1_Seats.Items.Add(c);
                    }
                }
            }
            else if (check == 4)
            {
                ck = Tarot.TryGetValue(s, out set);
                if (set != null)
                {
                    foreach (string c in set)
                    {
                        if (new[] { "A1", "A2", "A3", "A4", "A5", "B1", "B2", "B3", "B4", "B5", "C1", "C2", "C3", "C4", "C5" }.Contains(c))
                            clb1_Seats.Items.Add(c);
                    }
                }
            }
            else
            {
                MessageBox.Show("Chon lai phim"); // trường hợp chọn phim lỗi ( chưa xác nhận ) - backup

            }

        }

        private void clb1_Seats_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (clb1_Seats.CheckedItems.Count == 1)
            {
                if (e.NewValue == CheckState.Unchecked)
                    bt1_Confirm.Enabled = false;
            }
            else
                bt1_Confirm.Enabled = true;
        }

        private void bt1_Confirm_Click(object sender, EventArgs e)
        {

            double tong = 0; // tinh tổng tiền từ checked seats
            foreach (string c in clb1_Seats.CheckedItems)
            {
                if (new[] { "A1", "A5", "B1", "B5", "C1", "C5" }.Contains(c))
                {
                    tong += cost * 1 / 4;
                }
                else if (new[] { "A2", "A3", "A4", "C2", "C3", "C4" }.Contains(c))
                {
                    tong += cost * 1;
                }
                else
                {
                    tong += cost * 2;
                }
            }
            // chuỗi s là chuỗi show ra thông báo
            tb2_Cost.Text = tong.ToString();
            string s = "Ho va ten: " + tb1_Name.Text;
            s += System.Environment.NewLine + "Các vé đã chọn: ";
            foreach (string c in clb1_Seats.CheckedItems)
                s += c + " ";
            s += System.Environment.NewLine;
            s += "Phòng chiếu: " + cb1_Theater.Text;
            s += System.Environment.NewLine;
            s += "Số tiền phải trả: " + tong.ToString();
            if (MessageBox.Show(s, "Warning !!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) // thông báo lần cuối chắc chắn hay ko ? 
            {
                return;
            }
            else
            {
                MessageBox.Show("Bạn đã đặt vé thành công.", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // xóa các seats đã check trong csdl ( không biết truy cập hashset bên trong dictionary nên xóa bộ csdl hiện thời và cài vào một hashset mới )
                foreach (string c in clb1_Seats.CheckedItems)
                {
                    temp.Remove(c);
                }
                clb1_Seats.Items.Clear();
                if (check == 1)
                {
                    Mai.Remove(cb1_Theater.Text);
                    Mai.Add(cb1_Theater.Text, temp);
                }
                else if (check == 2)
                {
                    DPP.Remove(cb1_Theater.Text);
                    DPP.Add(cb1_Theater.Text, temp);
                }
                else if (check == 3)
                {
                    GLCB.Remove(cb1_Theater.Text);
                    GLCB.Add(cb1_Theater.Text, temp);
                }
                else
                {
                    Tarot.Remove(cb1_Theater.Text);
                    Tarot.Add(cb1_Theater.Text, temp);
                }
                // blank các ô -> đẹp
                tb1_Name.Text = "";
                tb2_Cost.Text = "";
                cb2_Movie.Text = "";
                cb1_Theater.Text = "";
            }

        }

        private void bt2_Reset_Click(object sender, EventArgs e)
        {
            tb1_Name.Text = "";
            tb2_Cost.Text = "";
            cb2_Movie.Text = "";
            cb1_Theater.Text = "";
        }

        private void bt3_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
