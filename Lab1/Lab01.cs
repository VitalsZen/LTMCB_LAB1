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
    public partial class Lab01 : Form
    {
        public Lab01()
        {
            InitializeComponent();
        }

        private void tb_Bai5_Click(object sender, EventArgs e)
        {
            var ChildForm = new Lab01_Bai04();
            ChildForm.Show();
        }

        private void Lab01_Load(object sender, EventArgs e)
        {

        }

        private void bt_Bai1_Click(object sender, EventArgs e)
        {
            var ChildForm = new Lab01_Bai01();
            ChildForm.Show();
        }

        private void bt_Bai2_Click(object sender, EventArgs e)
        {
            var ChildForm = new Lab01_Bai02();
            ChildForm.Show();
        }

        private void bt_Bai3_Click(object sender, EventArgs e)
        {
            var ChildForm = new Lab01_Bai03();
            ChildForm.Show();
        }

        private void Bt_Bai4_Click(object sender, EventArgs e)
        {
            var ChildForm = new Lab01_Bai03_1();
            ChildForm.Show();
        }

        private void bt_Bai6_Click(object sender, EventArgs e)
        {
            var ChildForm = new Lab01_Bai05();
            ChildForm.Show();
        }

        private void bt_Bai7_Click(object sender, EventArgs e)
        {
            var ChildForm = new Lab01_Bai06();
            ChildForm.Show();
        }

        private void bt_Bai8_Click(object sender, EventArgs e)
        {
            var ChildForm = new Lab01_Bai07();
            ChildForm.Show();
        }

        private void bt_Bai9_Click(object sender, EventArgs e)
        {
            var ChildForm = new Lab01_Bai08();
            ChildForm.Show();
        }
    }
}
