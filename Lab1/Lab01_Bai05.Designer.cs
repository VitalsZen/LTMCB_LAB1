namespace Lab1
{
    partial class Lab01_Bai05
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
            lb1_A = new Label();
            lb2_B = new Label();
            tb1_A = new TextBox();
            tb2_B = new TextBox();
            lb3_CachTinh = new Label();
            cb1_CachTinh = new ComboBox();
            pictureBox1 = new PictureBox();
            lb4_Tab1 = new Label();
            lb5_KQ = new Label();
            bt1_Tinh = new Button();
            tb3_KQ = new TextBox();
            bt2_Xoa = new Button();
            bt3_Thoat = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lb1_A
            // 
            lb1_A.AutoSize = true;
            lb1_A.Font = new Font("Times New Roman", 12F);
            lb1_A.Location = new Point(34, 58);
            lb1_A.Name = "lb1_A";
            lb1_A.Size = new Size(81, 22);
            lb1_A.TabIndex = 0;
            lb1_A.Text = "Nhập A: ";
            // 
            // lb2_B
            // 
            lb2_B.AutoSize = true;
            lb2_B.Font = new Font("Times New Roman", 12F);
            lb2_B.Location = new Point(361, 56);
            lb2_B.Name = "lb2_B";
            lb2_B.Size = new Size(81, 22);
            lb2_B.TabIndex = 1;
            lb2_B.Text = "Nhập B: ";
            // 
            // tb1_A
            // 
            tb1_A.Location = new Point(121, 58);
            tb1_A.Name = "tb1_A";
            tb1_A.Size = new Size(179, 27);
            tb1_A.TabIndex = 2;
            tb1_A.TextChanged += tb1_A_TextChanged;
            // 
            // tb2_B
            // 
            tb2_B.Location = new Point(448, 56);
            tb2_B.Name = "tb2_B";
            tb2_B.Size = new Size(177, 27);
            tb2_B.TabIndex = 3;
            tb2_B.TextChanged += tb2_B_TextChanged;
            // 
            // lb3_CachTinh
            // 
            lb3_CachTinh.AutoSize = true;
            lb3_CachTinh.Font = new Font("Times New Roman", 12F);
            lb3_CachTinh.Location = new Point(34, 112);
            lb3_CachTinh.Name = "lb3_CachTinh";
            lb3_CachTinh.Size = new Size(137, 22);
            lb3_CachTinh.TabIndex = 5;
            lb3_CachTinh.Text = "Chọn cách tính: ";
            // 
            // cb1_CachTinh
            // 
            cb1_CachTinh.FormattingEnabled = true;
            cb1_CachTinh.Items.AddRange(new object[] { "Bảng cửu chương", "Tính toán giá trị" });
            cb1_CachTinh.Location = new Point(177, 110);
            cb1_CachTinh.Name = "cb1_CachTinh";
            cb1_CachTinh.Size = new Size(151, 28);
            cb1_CachTinh.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Location = new Point(12, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(643, 132);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // lb4_Tab1
            // 
            lb4_Tab1.AutoSize = true;
            lb4_Tab1.Font = new Font("Times New Roman", 14F, FontStyle.Bold);
            lb4_Tab1.Location = new Point(34, 9);
            lb4_Tab1.Name = "lb4_Tab1";
            lb4_Tab1.Size = new Size(189, 26);
            lb4_Tab1.TabIndex = 8;
            lb4_Tab1.Text = "  Nhập thông tin  ";
            // 
            // lb5_KQ
            // 
            lb5_KQ.AutoSize = true;
            lb5_KQ.Font = new Font("Times New Roman", 14F, FontStyle.Bold);
            lb5_KQ.Location = new Point(34, 169);
            lb5_KQ.Name = "lb5_KQ";
            lb5_KQ.Size = new Size(114, 26);
            lb5_KQ.TabIndex = 9;
            lb5_KQ.Text = " Kết quả: ";
            // 
            // bt1_Tinh
            // 
            bt1_Tinh.BackColor = SystemColors.ButtonFace;
            bt1_Tinh.Font = new Font("Times New Roman", 11F);
            bt1_Tinh.Location = new Point(462, 190);
            bt1_Tinh.Name = "bt1_Tinh";
            bt1_Tinh.Size = new Size(176, 29);
            bt1_Tinh.TabIndex = 11;
            bt1_Tinh.Text = "Tính\r\n";
            bt1_Tinh.UseVisualStyleBackColor = false;
            bt1_Tinh.Click += bt1_Tinh_Click;
            // 
            // tb3_KQ
            // 
            tb3_KQ.BorderStyle = BorderStyle.FixedSingle;
            tb3_KQ.Location = new Point(12, 198);
            tb3_KQ.Multiline = true;
            tb3_KQ.Name = "tb3_KQ";
            tb3_KQ.ScrollBars = ScrollBars.Both;
            tb3_KQ.Size = new Size(404, 91);
            tb3_KQ.TabIndex = 12;
            // 
            // bt2_Xoa
            // 
            bt2_Xoa.BackColor = SystemColors.Menu;
            bt2_Xoa.Font = new Font("Times New Roman", 11F);
            bt2_Xoa.Location = new Point(462, 225);
            bt2_Xoa.Name = "bt2_Xoa";
            bt2_Xoa.Size = new Size(176, 29);
            bt2_Xoa.TabIndex = 13;
            bt2_Xoa.Text = "Xóa";
            bt2_Xoa.UseVisualStyleBackColor = false;
            bt2_Xoa.Click += bt2_Xoa_Click;
            // 
            // bt3_Thoat
            // 
            bt3_Thoat.BackColor = SystemColors.Menu;
            bt3_Thoat.Font = new Font("Times New Roman", 11F);
            bt3_Thoat.Location = new Point(462, 260);
            bt3_Thoat.Name = "bt3_Thoat";
            bt3_Thoat.Size = new Size(176, 29);
            bt3_Thoat.TabIndex = 14;
            bt3_Thoat.Text = "Thoát";
            bt3_Thoat.UseVisualStyleBackColor = false;
            bt3_Thoat.Click += bt3_Thoat_Click_1;
            // 
            // Lab01_Bai05
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(667, 312);
            Controls.Add(bt3_Thoat);
            Controls.Add(bt2_Xoa);
            Controls.Add(bt1_Tinh);
            Controls.Add(lb5_KQ);
            Controls.Add(lb4_Tab1);
            Controls.Add(cb1_CachTinh);
            Controls.Add(lb3_CachTinh);
            Controls.Add(tb2_B);
            Controls.Add(tb1_A);
            Controls.Add(lb2_B);
            Controls.Add(lb1_A);
            Controls.Add(pictureBox1);
            Controls.Add(tb3_KQ);
            Name = "Lab01_Bai05";
            Text = " ";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb1_A;
        private Label lb2_B;
        private TextBox tb1_A;
        private TextBox tb2_B;
        private Label lb3_CachTinh;
        private ComboBox cb1_CachTinh;
        private PictureBox pictureBox1;
        private Label lb4_Tab1;
        private Label lb5_KQ;
        private Button bt1_Tinh;
        private TextBox tb3_KQ;
        private Button bt2_Xoa;
        private Button bt3_Thoat;
    }
}