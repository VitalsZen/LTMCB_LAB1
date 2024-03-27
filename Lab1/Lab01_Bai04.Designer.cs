using System.Runtime.InteropServices;

namespace Lab1
{
    partial class Lab01_Bai04
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
            cb1_Theater = new ComboBox();
            clb1_Seats = new CheckedListBox();
            cb2_Movie = new ComboBox();
            lb1_Name = new Label();
            tb1_Name = new TextBox();
            lb2_Movie = new Label();
            Lb3_Theater = new Label();
            bt1_Confirm = new Button();
            tb2_Cost = new TextBox();
            pictureBox1 = new PictureBox();
            lb4_Title = new Label();
            label1 = new Label();
            bt2_Reset = new Button();
            bt3_Exit = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // cb1_Theater
            // 
            cb1_Theater.Enabled = false;
            cb1_Theater.FormattingEnabled = true;
            cb1_Theater.Location = new Point(127, 201);
            cb1_Theater.Name = "cb1_Theater";
            cb1_Theater.Size = new Size(237, 28);
            cb1_Theater.TabIndex = 0;
            cb1_Theater.SelectionChangeCommitted += cb1_Theater_SelectionChangeCommitted;
            // 
            // clb1_Seats
            // 
            clb1_Seats.CheckOnClick = true;
            clb1_Seats.FormattingEnabled = true;
            clb1_Seats.ImeMode = ImeMode.NoControl;
            clb1_Seats.Location = new Point(406, 95);
            clb1_Seats.MultiColumn = true;
            clb1_Seats.Name = "clb1_Seats";
            clb1_Seats.ScrollAlwaysVisible = true;
            clb1_Seats.Size = new Size(371, 136);
            clb1_Seats.TabIndex = 1;
            clb1_Seats.ItemCheck += clb1_Seats_ItemCheck;
            // 
            // cb2_Movie
            // 
            cb2_Movie.FormattingEnabled = true;
            cb2_Movie.Items.AddRange(new object[] { "Đào, phở và piano", "Mai", "Gặp lại chị bầu", "Tarot" });
            cb2_Movie.Location = new Point(127, 128);
            cb2_Movie.Name = "cb2_Movie";
            cb2_Movie.Size = new Size(237, 28);
            cb2_Movie.TabIndex = 2;
            cb2_Movie.SelectionChangeCommitted += cb2_Movie_SelectionChangeCommitted;
            // 
            // lb1_Name
            // 
            lb1_Name.AutoSize = true;
            lb1_Name.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb1_Name.Location = new Point(30, 65);
            lb1_Name.Name = "lb1_Name";
            lb1_Name.Size = new Size(73, 22);
            lb1_Name.TabIndex = 3;
            lb1_Name.Text = "Họ tên: ";
            // 
            // tb1_Name
            // 
            tb1_Name.BorderStyle = BorderStyle.FixedSingle;
            tb1_Name.Location = new Point(127, 65);
            tb1_Name.Name = "tb1_Name";
            tb1_Name.Size = new Size(237, 27);
            tb1_Name.TabIndex = 4;
            // 
            // lb2_Movie
            // 
            lb2_Movie.AutoSize = true;
            lb2_Movie.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb2_Movie.Location = new Point(30, 130);
            lb2_Movie.Name = "lb2_Movie";
            lb2_Movie.Size = new Size(61, 22);
            lb2_Movie.TabIndex = 6;
            lb2_Movie.Text = "Phim: ";
            // 
            // Lb3_Theater
            // 
            Lb3_Theater.AutoSize = true;
            Lb3_Theater.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Lb3_Theater.Location = new Point(30, 201);
            Lb3_Theater.Name = "Lb3_Theater";
            Lb3_Theater.Size = new Size(69, 22);
            Lb3_Theater.TabIndex = 7;
            Lb3_Theater.Text = "Phòng: ";
            // 
            // bt1_Confirm
            // 
            bt1_Confirm.Enabled = false;
            bt1_Confirm.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bt1_Confirm.Location = new Point(308, 305);
            bt1_Confirm.Name = "bt1_Confirm";
            bt1_Confirm.Size = new Size(139, 40);
            bt1_Confirm.TabIndex = 9;
            bt1_Confirm.Text = "Xác nhận";
            bt1_Confirm.UseVisualStyleBackColor = true;
            bt1_Confirm.Click += bt1_Confirm_Click;
            // 
            // tb2_Cost
            // 
            tb2_Cost.BorderStyle = BorderStyle.FixedSingle;
            tb2_Cost.Enabled = false;
            tb2_Cost.Location = new Point(30, 313);
            tb2_Cost.Name = "tb2_Cost";
            tb2_Cost.ReadOnly = true;
            tb2_Cost.Size = new Size(237, 27);
            tb2_Cost.TabIndex = 10;
            tb2_Cost.Text = "0";
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Location = new Point(12, 36);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(776, 231);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // lb4_Title
            // 
            lb4_Title.AutoSize = true;
            lb4_Title.Font = new Font("Times New Roman", 13F, FontStyle.Bold);
            lb4_Title.Location = new Point(41, 22);
            lb4_Title.Name = "lb4_Title";
            lb4_Title.Size = new Size(132, 25);
            lb4_Title.TabIndex = 12;
            lb4_Title.Text = "Thông tin vé";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(104, 288);
            label1.Name = "label1";
            label1.Size = new Size(63, 22);
            label1.TabIndex = 13;
            label1.Text = "Giá vé";
            // 
            // bt2_Reset
            // 
            bt2_Reset.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bt2_Reset.Location = new Point(473, 305);
            bt2_Reset.Name = "bt2_Reset";
            bt2_Reset.Size = new Size(139, 40);
            bt2_Reset.TabIndex = 14;
            bt2_Reset.Text = "Xóa";
            bt2_Reset.UseVisualStyleBackColor = true;
            bt2_Reset.Click += bt2_Reset_Click;
            // 
            // bt3_Exit
            // 
            bt3_Exit.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bt3_Exit.Location = new Point(638, 305);
            bt3_Exit.Name = "bt3_Exit";
            bt3_Exit.Size = new Size(139, 40);
            bt3_Exit.TabIndex = 15;
            bt3_Exit.Text = "Thoát";
            bt3_Exit.UseVisualStyleBackColor = true;
            bt3_Exit.Click += bt3_Exit_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(530, 65);
            label2.Name = "label2";
            label2.Size = new Size(123, 22);
            label2.TabIndex = 16;
            label2.Text = "Chọn chỗ ngồi";
            // 
            // Lab01_Bai04
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 390);
            Controls.Add(label2);
            Controls.Add(bt3_Exit);
            Controls.Add(bt2_Reset);
            Controls.Add(label1);
            Controls.Add(lb4_Title);
            Controls.Add(tb2_Cost);
            Controls.Add(bt1_Confirm);
            Controls.Add(Lb3_Theater);
            Controls.Add(lb2_Movie);
            Controls.Add(tb1_Name);
            Controls.Add(lb1_Name);
            Controls.Add(cb2_Movie);
            Controls.Add(clb1_Seats);
            Controls.Add(cb1_Theater);
            Controls.Add(pictureBox1);
            Name = "Lab01_Bai04";
            Text = "Lab01_Bai05";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void Cb2_Movie_SelectionChangeCommitted(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private ComboBox cb1_Theater;
        private CheckedListBox clb1_Seats;
        private ComboBox cb2_Movie;
        private Label lb1_Name;
        private TextBox tb1_Name;
        private Label lb2_Movie;
        private Label Lb3_Theater;
        private Button bt1_Confirm;
        private TextBox tb2_Cost;
        private PictureBox pictureBox1;
        private Label lb4_Title;
        private Label label1;
        private Button bt2_Reset;
        private Button bt3_Exit;
        private Label label2;
    }
}