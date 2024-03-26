namespace Lab1
{
    partial class Lab01_Bai07
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
            tb1_Input = new TextBox();
            tb2_Name = new TextBox();
            bt1_Input = new Button();
            tb3_Score = new TextBox();
            tb4_DTB = new TextBox();
            tb5_Max = new TextBox();
            tb6_Min = new TextBox();
            tb7_Passed = new TextBox();
            tb8_Failed = new TextBox();
            tb9_Xeploai = new TextBox();
            bt2_Reset = new Button();
            label7 = new Label();
            label1 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            bt3_Exit = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tb1_Input
            // 
            tb1_Input.BorderStyle = BorderStyle.FixedSingle;
            tb1_Input.ImeMode = ImeMode.Close;
            tb1_Input.Location = new Point(121, 54);
            tb1_Input.Multiline = true;
            tb1_Input.Name = "tb1_Input";
            tb1_Input.ScrollBars = ScrollBars.Horizontal;
            tb1_Input.Size = new Size(364, 33);
            tb1_Input.TabIndex = 0;
            tb1_Input.TextChanged += tb1_Input_TextChanged;
            // 
            // tb2_Name
            // 
            tb2_Name.BorderStyle = BorderStyle.FixedSingle;
            tb2_Name.ImeMode = ImeMode.Close;
            tb2_Name.Location = new Point(121, 124);
            tb2_Name.Multiline = true;
            tb2_Name.Name = "tb2_Name";
            tb2_Name.ReadOnly = true;
            tb2_Name.ScrollBars = ScrollBars.Horizontal;
            tb2_Name.Size = new Size(364, 32);
            tb2_Name.TabIndex = 1;
            // 
            // bt1_Input
            // 
            bt1_Input.BackColor = SystemColors.ButtonFace;
            bt1_Input.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bt1_Input.Location = new Point(548, 228);
            bt1_Input.Name = "bt1_Input";
            bt1_Input.Size = new Size(177, 29);
            bt1_Input.TabIndex = 2;
            bt1_Input.Text = "Kiểm tra mã";
            bt1_Input.UseVisualStyleBackColor = false;
            bt1_Input.Click += bt1_Input_Click;
            // 
            // tb3_Score
            // 
            tb3_Score.BackColor = SystemColors.ControlLightLight;
            tb3_Score.BorderStyle = BorderStyle.FixedSingle;
            tb3_Score.ImeMode = ImeMode.Close;
            tb3_Score.Location = new Point(514, 55);
            tb3_Score.Multiline = true;
            tb3_Score.Name = "tb3_Score";
            tb3_Score.ReadOnly = true;
            tb3_Score.ScrollBars = ScrollBars.Both;
            tb3_Score.Size = new Size(259, 157);
            tb3_Score.TabIndex = 3;
            // 
            // tb4_DTB
            // 
            tb4_DTB.BorderStyle = BorderStyle.FixedSingle;
            tb4_DTB.ImeMode = ImeMode.Close;
            tb4_DTB.Location = new Point(39, 212);
            tb4_DTB.Multiline = true;
            tb4_DTB.Name = "tb4_DTB";
            tb4_DTB.ReadOnly = true;
            tb4_DTB.Size = new Size(121, 28);
            tb4_DTB.TabIndex = 7;
            tb4_DTB.TextAlign = HorizontalAlignment.Center;
            // 
            // tb5_Max
            // 
            tb5_Max.BorderStyle = BorderStyle.FixedSingle;
            tb5_Max.ImeMode = ImeMode.Close;
            tb5_Max.Location = new Point(208, 212);
            tb5_Max.Multiline = true;
            tb5_Max.Name = "tb5_Max";
            tb5_Max.ReadOnly = true;
            tb5_Max.Size = new Size(121, 28);
            tb5_Max.TabIndex = 8;
            tb5_Max.TextAlign = HorizontalAlignment.Center;
            // 
            // tb6_Min
            // 
            tb6_Min.BorderStyle = BorderStyle.FixedSingle;
            tb6_Min.ImeMode = ImeMode.Close;
            tb6_Min.Location = new Point(364, 212);
            tb6_Min.Multiline = true;
            tb6_Min.Name = "tb6_Min";
            tb6_Min.ReadOnly = true;
            tb6_Min.Size = new Size(121, 28);
            tb6_Min.TabIndex = 11;
            tb6_Min.TextAlign = HorizontalAlignment.Center;
            // 
            // tb7_Passed
            // 
            tb7_Passed.BorderStyle = BorderStyle.FixedSingle;
            tb7_Passed.ImeMode = ImeMode.Close;
            tb7_Passed.Location = new Point(39, 298);
            tb7_Passed.Multiline = true;
            tb7_Passed.Name = "tb7_Passed";
            tb7_Passed.ReadOnly = true;
            tb7_Passed.Size = new Size(121, 28);
            tb7_Passed.TabIndex = 13;
            tb7_Passed.TextAlign = HorizontalAlignment.Center;
            // 
            // tb8_Failed
            // 
            tb8_Failed.BorderStyle = BorderStyle.FixedSingle;
            tb8_Failed.ImeMode = ImeMode.Close;
            tb8_Failed.Location = new Point(208, 298);
            tb8_Failed.Multiline = true;
            tb8_Failed.Name = "tb8_Failed";
            tb8_Failed.ReadOnly = true;
            tb8_Failed.Size = new Size(121, 28);
            tb8_Failed.TabIndex = 16;
            tb8_Failed.TextAlign = HorizontalAlignment.Center;
            // 
            // tb9_Xeploai
            // 
            tb9_Xeploai.BorderStyle = BorderStyle.FixedSingle;
            tb9_Xeploai.ImeMode = ImeMode.Close;
            tb9_Xeploai.Location = new Point(364, 298);
            tb9_Xeploai.Multiline = true;
            tb9_Xeploai.Name = "tb9_Xeploai";
            tb9_Xeploai.ReadOnly = true;
            tb9_Xeploai.Size = new Size(121, 28);
            tb9_Xeploai.TabIndex = 18;
            tb9_Xeploai.TextAlign = HorizontalAlignment.Center;
            // 
            // bt2_Reset
            // 
            bt2_Reset.BackColor = SystemColors.ButtonFace;
            bt2_Reset.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bt2_Reset.Location = new Point(548, 266);
            bt2_Reset.Name = "bt2_Reset";
            bt2_Reset.Size = new Size(177, 29);
            bt2_Reset.TabIndex = 20;
            bt2_Reset.Text = "Đặt lại";
            bt2_Reset.UseVisualStyleBackColor = false;
            bt2_Reset.Click += bt2_Reset_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 12F);
            label7.Location = new Point(39, 125);
            label7.Name = "label7";
            label7.Size = new Size(68, 22);
            label7.TabIndex = 23;
            label7.Text = "Họ tên:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F);
            label1.Location = new Point(50, 56);
            label1.Name = "label1";
            label1.Size = new Size(42, 22);
            label1.TabIndex = 24;
            label1.Text = "Mã:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label8.Location = new Point(564, 9);
            label8.Name = "label8";
            label8.Size = new Size(141, 23);
            label8.TabIndex = 25;
            label8.Text = "Danh sách điểm";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 12F);
            label9.Location = new Point(71, 187);
            label9.Name = "label9";
            label9.Size = new Size(49, 22);
            label9.TabIndex = 26;
            label9.Text = "DTB";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 12F);
            label10.Location = new Point(400, 187);
            label10.Name = "label10";
            label10.Size = new Size(42, 22);
            label10.TabIndex = 27;
            label10.Text = "Min";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 12F);
            label11.Location = new Point(244, 187);
            label11.Name = "label11";
            label11.Size = new Size(45, 22);
            label11.TabIndex = 28;
            label11.Text = "Max";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Times New Roman", 12F);
            label12.Location = new Point(71, 273);
            label12.Name = "label12";
            label12.Size = new Size(65, 22);
            label12.TabIndex = 29;
            label12.Text = "Passed";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Times New Roman", 12F);
            label13.Location = new Point(241, 273);
            label13.Name = "label13";
            label13.Size = new Size(61, 22);
            label13.TabIndex = 30;
            label13.Text = "Failed";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Times New Roman", 12F);
            label14.Location = new Point(389, 273);
            label14.Name = "label14";
            label14.Size = new Size(79, 22);
            label14.TabIndex = 31;
            label14.Text = "Xếp loại";
            // 
            // bt3_Exit
            // 
            bt3_Exit.BackColor = SystemColors.ButtonFace;
            bt3_Exit.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bt3_Exit.Location = new Point(548, 301);
            bt3_Exit.Name = "bt3_Exit";
            bt3_Exit.Size = new Size(177, 29);
            bt3_Exit.TabIndex = 32;
            bt3_Exit.Text = "Thoát";
            bt3_Exit.UseVisualStyleBackColor = false;
            bt3_Exit.Click += bt3_Exit_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Location = new Point(12, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(776, 322);
            pictureBox1.TabIndex = 33;
            pictureBox1.TabStop = false;
            // 
            // Lab01_Bai07
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 359);
            Controls.Add(bt3_Exit);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label1);
            Controls.Add(label7);
            Controls.Add(bt2_Reset);
            Controls.Add(tb9_Xeploai);
            Controls.Add(tb8_Failed);
            Controls.Add(tb7_Passed);
            Controls.Add(tb6_Min);
            Controls.Add(tb5_Max);
            Controls.Add(tb4_DTB);
            Controls.Add(tb3_Score);
            Controls.Add(bt1_Input);
            Controls.Add(tb2_Name);
            Controls.Add(tb1_Input);
            Controls.Add(pictureBox1);
            Name = "Lab01_Bai07";
            Text = "Lab01_Bai07";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb1_Input;
        private TextBox tb2_Name;
        private Button bt1_Input;
        private TextBox tb3_Score;
        private TextBox tb4_DTB;
        private TextBox tb5_Max;
        private TextBox tb6_Min;
        private TextBox tb7_Passed;
        private TextBox tb8_Failed;
        private TextBox tb9_Xeploai;
        private Button bt2_Reset;
        private Label label7;
        private Label label1;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Button bt3_Exit;
        private PictureBox pictureBox1;
    }
}