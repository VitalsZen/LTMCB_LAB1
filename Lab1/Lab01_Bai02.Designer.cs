namespace Lab1
{
    partial class Lab01_Bai02
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
            lb1_S1 = new Label();
            tb3_S3 = new TextBox();
            tb2_S2 = new TextBox();
            tb1_S1 = new TextBox();
            lb2_S2 = new Label();
            lb3_S3 = new Label();
            bt1_Find = new Button();
            tb4_max = new TextBox();
            tb5_min = new TextBox();
            lb4_max = new Label();
            lb5_min = new Label();
            bt2_Xoa = new Button();
            bt3_Thoat = new Button();
            SuspendLayout();
            // 
            // lb1_S1
            // 
            lb1_S1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lb1_S1.AutoSize = true;
            lb1_S1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb1_S1.Location = new Point(28, 32);
            lb1_S1.Name = "lb1_S1";
            lb1_S1.Size = new Size(104, 22);
            lb1_S1.TabIndex = 0;
            lb1_S1.Text = "Số thứ nhất:";
            // 
            // tb3_S3
            // 
            tb3_S3.BorderStyle = BorderStyle.FixedSingle;
            tb3_S3.Location = new Point(630, 32);
            tb3_S3.Name = "tb3_S3";
            tb3_S3.Size = new Size(125, 27);
            tb3_S3.TabIndex = 2;
            tb3_S3.TextChanged += tb3_S3_TextChanged;
            // 
            // tb2_S2
            // 
            tb2_S2.BorderStyle = BorderStyle.FixedSingle;
            tb2_S2.Location = new Point(391, 31);
            tb2_S2.Name = "tb2_S2";
            tb2_S2.Size = new Size(125, 27);
            tb2_S2.TabIndex = 2;
            tb2_S2.TextChanged += tb2_S2_TextChanged;
            // 
            // tb1_S1
            // 
            tb1_S1.BorderStyle = BorderStyle.FixedSingle;
            tb1_S1.Location = new Point(138, 31);
            tb1_S1.Name = "tb1_S1";
            tb1_S1.Size = new Size(127, 27);
            tb1_S1.TabIndex = 2;
            tb1_S1.TextChanged += tb1_S1_TextChanged;
            // 
            // lb2_S2
            // 
            lb2_S2.AutoSize = true;
            lb2_S2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb2_S2.Location = new Point(284, 36);
            lb2_S2.Name = "lb2_S2";
            lb2_S2.Size = new Size(101, 22);
            lb2_S2.TabIndex = 0;
            lb2_S2.Text = "Số thứ hai: ";
            // 
            // lb3_S3
            // 
            lb3_S3.AutoSize = true;
            lb3_S3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb3_S3.Location = new Point(528, 36);
            lb3_S3.Name = "lb3_S3";
            lb3_S3.Size = new Size(96, 22);
            lb3_S3.TabIndex = 0;
            lb3_S3.Text = "Số thứ ba: ";
            // 
            // bt1_Find
            // 
            bt1_Find.BackColor = SystemColors.ButtonFace;
            bt1_Find.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bt1_Find.Location = new Point(444, 104);
            bt1_Find.Name = "bt1_Find";
            bt1_Find.Size = new Size(268, 29);
            bt1_Find.TabIndex = 3;
            bt1_Find.Text = "Tìm";
            bt1_Find.UseVisualStyleBackColor = false;
            bt1_Find.Click += bt1_Find_Click;
            // 
            // tb4_max
            // 
            tb4_max.BorderStyle = BorderStyle.FixedSingle;
            tb4_max.Location = new Point(138, 106);
            tb4_max.Name = "tb4_max";
            tb4_max.Size = new Size(194, 27);
            tb4_max.TabIndex = 4;
            // 
            // tb5_min
            // 
            tb5_min.BorderStyle = BorderStyle.FixedSingle;
            tb5_min.Location = new Point(140, 163);
            tb5_min.Name = "tb5_min";
            tb5_min.Size = new Size(192, 27);
            tb5_min.TabIndex = 5;
            // 
            // lb4_max
            // 
            lb4_max.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lb4_max.AutoSize = true;
            lb4_max.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb4_max.Location = new Point(28, 109);
            lb4_max.Name = "lb4_max";
            lb4_max.Size = new Size(105, 22);
            lb4_max.TabIndex = 6;
            lb4_max.Text = "Số lớn nhất:";
            // 
            // lb5_min
            // 
            lb5_min.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lb5_min.AutoSize = true;
            lb5_min.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb5_min.Location = new Point(28, 164);
            lb5_min.Name = "lb5_min";
            lb5_min.Size = new Size(112, 22);
            lb5_min.TabIndex = 7;
            lb5_min.Text = "Số nhỏ nhất: ";
            // 
            // bt2_Xoa
            // 
            bt2_Xoa.BackColor = SystemColors.ButtonFace;
            bt2_Xoa.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bt2_Xoa.Location = new Point(444, 139);
            bt2_Xoa.Name = "bt2_Xoa";
            bt2_Xoa.Size = new Size(268, 29);
            bt2_Xoa.TabIndex = 8;
            bt2_Xoa.Text = "Xóa";
            bt2_Xoa.UseVisualStyleBackColor = false;
            bt2_Xoa.Click += bt2_Xoa_Click;
            // 
            // bt3_Thoat
            // 
            bt3_Thoat.BackColor = SystemColors.ButtonFace;
            bt3_Thoat.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bt3_Thoat.Location = new Point(444, 175);
            bt3_Thoat.Name = "bt3_Thoat";
            bt3_Thoat.Size = new Size(268, 29);
            bt3_Thoat.TabIndex = 9;
            bt3_Thoat.Text = "Thoát";
            bt3_Thoat.UseVisualStyleBackColor = false;
            bt3_Thoat.Click += bt3_Thoat_Click;
            // 
            // Lab01_Bai02
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(764, 216);
            Controls.Add(bt3_Thoat);
            Controls.Add(bt2_Xoa);
            Controls.Add(lb5_min);
            Controls.Add(lb4_max);
            Controls.Add(tb5_min);
            Controls.Add(tb4_max);
            Controls.Add(bt1_Find);
            Controls.Add(tb1_S1);
            Controls.Add(tb2_S2);
            Controls.Add(lb3_S3);
            Controls.Add(tb3_S3);
            Controls.Add(lb2_S2);
            Controls.Add(lb1_S1);
            Name = "Lab01_Bai02";
            Text = "Lab01_Bai02";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb1_S1;
        private TextBox tb3_S3;
        private TextBox tb2_S2;
        private TextBox tb1_S1;
        private Label lb2_S2;
        private Label lb3_S3;
        private Button bt1_Find;
        private TextBox tb4_max;
        private TextBox tb5_min;
        private Label lb4_max;
        private Label lb5_min;
        private Button bt2_Xoa;
        private Button bt3_Thoat;
    }
}