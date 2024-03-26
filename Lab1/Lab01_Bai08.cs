using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Lab01_Bai08 : Form
    {
        public Lab01_Bai08()
        {
            InitializeComponent();
        }
        List<string> list = new List<string>();

        private void bt1_Add_Click(object sender, EventArgs e)
        {
            tb2_List.Text += tb1_Input.Text;
            tb2_List.AppendText(Environment.NewLine);
            list.Add(tb1_Input.Text);
        }

        private void bt2_FindRandom_Click(object sender, EventArgs e)
        {
            tb3_Output.Text = list[RandomNumberGenerator.GetInt32(0, list.Count)];
        }

        private void bt3_Reset_Click(object sender, EventArgs e)
        {
            list.Clear();
            tb2_List.Text = "";
            tb1_Input.Clear();
            tb3_Output.Text = "";
        }

        private void bt4_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tb2_List_TextChanged(object sender, EventArgs e)
        {
            if (tb2_List.Text != "")
            {
                bt2_FindRandom.Enabled = true;
                bt3_Reset.Enabled = true;
            }    
            else
            {
                bt3_Reset.Enabled = false;
                bt2_FindRandom.Enabled = false;
            }
                
        }
    }
}
