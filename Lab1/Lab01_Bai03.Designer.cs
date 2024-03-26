namespace Lab1
{
    partial class Lab01_Bai03
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
            tb1_num = new TextBox();
            lb1_num = new Label();
            tb2_kq = new TextBox();
            lb2_kq = new Label();
            bt1_Read = new Button();
            bt2_ = new Button();
            bt3_Close = new Button();
            SuspendLayout();
            // 
            // tb1_num
            // 
            tb1_num.BorderStyle = BorderStyle.FixedSingle;
            tb1_num.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb1_num.Location = new Point(235, 30);
            tb1_num.Name = "tb1_num";
            tb1_num.Size = new Size(125, 30);
            tb1_num.TabIndex = 0;
            tb1_num.TextChanged += tb1_num_TextChanged;
            // 
            // lb1_num
            // 
            lb1_num.AutoSize = true;
            lb1_num.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb1_num.Location = new Point(26, 38);
            lb1_num.Name = "lb1_num";
            lb1_num.Size = new Size(203, 22);
            lb1_num.TabIndex = 1;
            lb1_num.Text = "Nhập số nguyên từ 0 - 9:";
            // 
            // tb2_kq
            // 
            tb2_kq.BorderStyle = BorderStyle.FixedSingle;
            tb2_kq.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb2_kq.Location = new Point(114, 102);
            tb2_kq.Name = "tb2_kq";
            tb2_kq.Size = new Size(125, 30);
            tb2_kq.TabIndex = 3;
            tb2_kq.TextChanged += tb2_kq_TextChanged;
            // 
            // lb2_kq
            // 
            lb2_kq.AutoSize = true;
            lb2_kq.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb2_kq.Location = new Point(26, 104);
            lb2_kq.Name = "lb2_kq";
            lb2_kq.Size = new Size(82, 22);
            lb2_kq.TabIndex = 4;
            lb2_kq.Text = "Kết quả: ";
            // 
            // bt1_Read
            // 
            bt1_Read.BackColor = SystemColors.ButtonFace;
            bt1_Read.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bt1_Read.Location = new Point(396, 30);
            bt1_Read.Name = "bt1_Read";
            bt1_Read.Size = new Size(125, 30);
            bt1_Read.TabIndex = 5;
            bt1_Read.Text = "Đọc";
            bt1_Read.UseVisualStyleBackColor = false;
            bt1_Read.Click += bt1_Read_Click;
            // 
            // bt2_
            // 
            bt2_.BackColor = SystemColors.ButtonFace;
            bt2_.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bt2_.Location = new Point(396, 80);
            bt2_.Name = "bt2_";
            bt2_.Size = new Size(125, 30);
            bt2_.TabIndex = 6;
            bt2_.Text = "Xóa";
            bt2_.UseVisualStyleBackColor = false;
            bt2_.Click += bt2__Click;
            // 
            // bt3_Close
            // 
            bt3_Close.BackColor = SystemColors.ButtonFace;
            bt3_Close.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bt3_Close.Location = new Point(396, 127);
            bt3_Close.Name = "bt3_Close";
            bt3_Close.Size = new Size(125, 29);
            bt3_Close.TabIndex = 7;
            bt3_Close.Text = "Thoát";
            bt3_Close.UseVisualStyleBackColor = false;
            bt3_Close.Click += bt3_Close_Click;
            // 
            // Lab01_Bai03
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(533, 178);
            Controls.Add(bt3_Close);
            Controls.Add(bt2_);
            Controls.Add(bt1_Read);
            Controls.Add(lb2_kq);
            Controls.Add(tb2_kq);
            Controls.Add(lb1_num);
            Controls.Add(tb1_num);
            Name = "Lab01_Bai03";
            Text = "Lab01_Bai03";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb1_num;
        private Label lb1_num;
        private TextBox tb2_kq;
        private Label lb2_kq;
        private Button bt1_Read;
        private Button bt2_;
        private Button bt3_Close;
    }
}