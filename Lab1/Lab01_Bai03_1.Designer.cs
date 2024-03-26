namespace Lab1
{
    partial class Lab01_Bai03_1
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
            bt3_Close = new Button();
            bt2_Reset = new Button();
            bt1_Read = new Button();
            lb2_kq = new Label();
            tb2_kq = new TextBox();
            lb1_num = new Label();
            tb1_num = new TextBox();
            SuspendLayout();
            // 
            // bt3_Close
            // 
            bt3_Close.BackColor = SystemColors.ButtonFace;
            bt3_Close.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bt3_Close.Location = new Point(678, 125);
            bt3_Close.Name = "bt3_Close";
            bt3_Close.Size = new Size(208, 45);
            bt3_Close.TabIndex = 14;
            bt3_Close.Text = "Thoát";
            bt3_Close.UseVisualStyleBackColor = false;
            bt3_Close.Click += bt3_Close_Click;
            // 
            // bt2_Reset
            // 
            bt2_Reset.BackColor = SystemColors.ButtonFace;
            bt2_Reset.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bt2_Reset.Location = new Point(678, 74);
            bt2_Reset.Name = "bt2_Reset";
            bt2_Reset.Size = new Size(208, 45);
            bt2_Reset.TabIndex = 13;
            bt2_Reset.Text = "Xóa";
            bt2_Reset.UseVisualStyleBackColor = false;
            bt2_Reset.Click += bt2_Reset_Click;
            // 
            // bt1_Read
            // 
            bt1_Read.BackColor = SystemColors.ButtonFace;
            bt1_Read.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bt1_Read.Location = new Point(678, 23);
            bt1_Read.Name = "bt1_Read";
            bt1_Read.Size = new Size(208, 45);
            bt1_Read.TabIndex = 12;
            bt1_Read.Text = "Đọc";
            bt1_Read.UseVisualStyleBackColor = false;
            bt1_Read.Click += bt1_Read_Click;
            // 
            // lb2_kq
            // 
            lb2_kq.AutoSize = true;
            lb2_kq.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb2_kq.Location = new Point(29, 92);
            lb2_kq.Name = "lb2_kq";
            lb2_kq.Size = new Size(82, 22);
            lb2_kq.TabIndex = 11;
            lb2_kq.Text = "Kết quả: ";
            // 
            // tb2_kq
            // 
            tb2_kq.BorderStyle = BorderStyle.FixedSingle;
            tb2_kq.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb2_kq.Location = new Point(117, 92);
            tb2_kq.Multiline = true;
            tb2_kq.Name = "tb2_kq";
            tb2_kq.ScrollBars = ScrollBars.Vertical;
            tb2_kq.Size = new Size(519, 87);
            tb2_kq.TabIndex = 10;
            // 
            // lb1_num
            // 
            lb1_num.AutoSize = true;
            lb1_num.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb1_num.Location = new Point(29, 34);
            lb1_num.Name = "lb1_num";
            lb1_num.Size = new Size(227, 22);
            lb1_num.TabIndex = 9;
            lb1_num.Text = "Nhập số nguyên 12 chữ số: ";
            // 
            // tb1_num
            // 
            tb1_num.BorderStyle = BorderStyle.FixedSingle;
            tb1_num.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb1_num.Location = new Point(262, 28);
            tb1_num.Name = "tb1_num";
            tb1_num.Size = new Size(374, 30);
            tb1_num.TabIndex = 8;
            tb1_num.TextChanged += tb1_num_TextChanged;
            // 
            // Lab01_Bai03_1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(917, 191);
            Controls.Add(bt3_Close);
            Controls.Add(bt2_Reset);
            Controls.Add(bt1_Read);
            Controls.Add(lb2_kq);
            Controls.Add(tb2_kq);
            Controls.Add(lb1_num);
            Controls.Add(tb1_num);
            Name = "Lab01_Bai03_1";
            Text = "Lab01_Bai04";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bt3_Close;
        private Button bt2_Reset;
        private Button bt1_Read;
        private Label lb2_kq;
        private TextBox tb2_kq;
        private Label lb1_num;
        private TextBox tb1_num;
    }
}