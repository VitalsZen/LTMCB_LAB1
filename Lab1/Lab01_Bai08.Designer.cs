using System.Windows.Forms.VisualStyles;

namespace Lab1
{
    partial class Lab01_Bai08
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tb2_List = new TextBox();
            tb1_Input = new TextBox();
            bt2_FindRandom = new Button();
            bt1_Add = new Button();
            tb3_Output = new TextBox();
            bt3_Reset = new Button();
            bt4_Exit = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // tb2_List
            // 
            tb2_List.BackColor = SystemColors.ControlLightLight;
            tb2_List.BorderStyle = BorderStyle.FixedSingle;
            tb2_List.Location = new Point(368, 36);
            tb2_List.Multiline = true;
            tb2_List.Name = "tb2_List";
            tb2_List.ReadOnly = true;
            tb2_List.ScrollBars = ScrollBars.Both;
            tb2_List.Size = new Size(334, 209);
            tb2_List.TabIndex = 0;
            tb2_List.TextChanged += tb2_List_TextChanged;
            // 
            // tb1_Input
            // 
            tb1_Input.BorderStyle = BorderStyle.FixedSingle;
            tb1_Input.Location = new Point(12, 61);
            tb1_Input.Name = "tb1_Input";
            tb1_Input.ScrollBars = ScrollBars.Horizontal;
            tb1_Input.Size = new Size(317, 27);
            tb1_Input.TabIndex = 1;
            // 
            // bt2_FindRandom
            // 
            bt2_FindRandom.BackColor = SystemColors.Info;
            bt2_FindRandom.Enabled = false;
            bt2_FindRandom.Font = new Font("Times New Roman", 10F);
            bt2_FindRandom.Location = new Point(51, 314);
            bt2_FindRandom.Name = "bt2_FindRandom";
            bt2_FindRandom.Size = new Size(173, 53);
            bt2_FindRandom.TabIndex = 7;
            bt2_FindRandom.Text = "Tìm món ăn \r\n(Ăn gì cũng được)";
            bt2_FindRandom.UseVisualStyleBackColor = false;
            bt2_FindRandom.Click += bt2_FindRandom_Click;
            // 
            // bt1_Add
            // 
            bt1_Add.BackColor = SystemColors.Info;
            bt1_Add.Font = new Font("Times New Roman", 10F);
            bt1_Add.Location = new Point(93, 106);
            bt1_Add.Name = "bt1_Add";
            bt1_Add.Size = new Size(151, 41);
            bt1_Add.TabIndex = 8;
            bt1_Add.Text = "Thêm món ăn";
            bt1_Add.UseVisualStyleBackColor = false;
            bt1_Add.Click += bt1_Add_Click;
            // 
            // tb3_Output
            // 
            tb3_Output.BorderStyle = BorderStyle.FixedSingle;
            tb3_Output.Location = new Point(12, 217);
            tb3_Output.Name = "tb3_Output";
            tb3_Output.ScrollBars = ScrollBars.Horizontal;
            tb3_Output.Size = new Size(317, 27);
            tb3_Output.TabIndex = 9;
            // 
            // bt3_Reset
            // 
            bt3_Reset.BackColor = SystemColors.Info;
            bt3_Reset.Cursor = Cursors.Hand;
            bt3_Reset.Enabled = false;
            bt3_Reset.FlatAppearance.BorderColor = Color.Black;
            bt3_Reset.FlatAppearance.BorderSize = 5;
            bt3_Reset.Font = new Font("Times New Roman", 10F);
            bt3_Reset.Location = new Point(291, 314);
            bt3_Reset.Name = "bt3_Reset";
            bt3_Reset.Size = new Size(173, 53);
            bt3_Reset.TabIndex = 10;
            bt3_Reset.Text = "Đặt lại";
            bt3_Reset.UseVisualStyleBackColor = false;
            bt3_Reset.Click += bt3_Reset_Click;
            // 
            // bt4_Exit
            // 
            bt4_Exit.BackColor = SystemColors.Info;
            bt4_Exit.Font = new Font("Times New Roman", 10F);
            bt4_Exit.Location = new Point(506, 314);
            bt4_Exit.Name = "bt4_Exit";
            bt4_Exit.Size = new Size(173, 53);
            bt4_Exit.TabIndex = 11;
            bt4_Exit.Text = "Thoát";
            bt4_Exit.UseVisualStyleBackColor = false;
            bt4_Exit.Click += bt4_Exit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F);
            label1.Location = new Point(107, 36);
            label1.Name = "label1";
            label1.Size = new Size(137, 22);
            label1.TabIndex = 12;
            label1.Text = "Món ăn ưa thích";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F);
            label2.Location = new Point(107, 192);
            label2.Name = "label2";
            label2.Size = new Size(103, 22);
            label2.TabIndex = 13;
            label2.Text = "Ăn món này";
            // 
            // Lab01_Bai08
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(714, 386);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(bt4_Exit);
            Controls.Add(bt3_Reset);
            Controls.Add(tb3_Output);
            Controls.Add(bt1_Add);
            Controls.Add(bt2_FindRandom);
            Controls.Add(tb1_Input);
            Controls.Add(tb2_List);
            Name = "Lab01_Bai08";
            Text = "Lab01_Bai08";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb2_List;
        private TextBox tb1_Input;
        private Button bt2_FindRandom;
        private Button bt1_Add;
        private TextBox tb3_Output;
        private Button bt3_Reset;
        private Button bt4_Exit;
        private Label label1;
        private Label label2;
    }
}