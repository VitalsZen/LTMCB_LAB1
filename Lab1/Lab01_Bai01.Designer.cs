namespace Lab1
{
    partial class Lab01_Bai01
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
            tb_KQ = new TextBox();
            tb_STT2 = new TextBox();
            tb_STT1 = new TextBox();
            Lb3_KQ = new Label();
            Lb2_STT2 = new Label();
            Lb1_STT1 = new Label();
            bt1_KQ = new Button();
            SuspendLayout();
            // 
            // tb_KQ
            // 
            tb_KQ.Location = new Point(145, 116);
            tb_KQ.Name = "tb_KQ";
            tb_KQ.Size = new Size(321, 27);
            tb_KQ.TabIndex = 11;
            // 
            // tb_STT2
            // 
            tb_STT2.Location = new Point(145, 67);
            tb_STT2.Name = "tb_STT2";
            tb_STT2.Size = new Size(321, 27);
            tb_STT2.TabIndex = 10;
            tb_STT2.TextChanged += tb_STT2_TextChanged;
            // 
            // tb_STT1
            // 
            tb_STT1.Location = new Point(145, 21);
            tb_STT1.Name = "tb_STT1";
            tb_STT1.Size = new Size(321, 27);
            tb_STT1.TabIndex = 9;
            tb_STT1.TextChanged += tb_STT1_TextChanged;
            // 
            // Lb3_KQ
            // 
            Lb3_KQ.AutoSize = true;
            Lb3_KQ.Font = new Font("Times New Roman", 12.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Lb3_KQ.Location = new Point(27, 120);
            Lb3_KQ.Name = "Lb3_KQ";
            Lb3_KQ.Size = new Size(75, 23);
            Lb3_KQ.TabIndex = 8;
            Lb3_KQ.Text = "Kết quả";
            Lb3_KQ.Click += Lb3_KQ_Click;
            // 
            // Lb2_STT2
            // 
            Lb2_STT2.AutoSize = true;
            Lb2_STT2.Font = new Font("Times New Roman", 12.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Lb2_STT2.Location = new Point(27, 71);
            Lb2_STT2.Name = "Lb2_STT2";
            Lb2_STT2.Size = new Size(80, 23);
            Lb2_STT2.TabIndex = 7;
            Lb2_STT2.Text = "Số thứ 2";
            // 
            // Lb1_STT1
            // 
            Lb1_STT1.AutoSize = true;
            Lb1_STT1.Font = new Font("Times New Roman", 12.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Lb1_STT1.Location = new Point(27, 22);
            Lb1_STT1.Name = "Lb1_STT1";
            Lb1_STT1.Size = new Size(80, 23);
            Lb1_STT1.TabIndex = 6;
            Lb1_STT1.Text = "Số thứ 1";
            // 
            // bt1_KQ
            // 
            bt1_KQ.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bt1_KQ.Location = new Point(199, 169);
            bt1_KQ.Name = "bt1_KQ";
            bt1_KQ.Size = new Size(94, 29);
            bt1_KQ.TabIndex = 12;
            bt1_KQ.Text = "Tính";
            bt1_KQ.UseVisualStyleBackColor = true;
            bt1_KQ.Click += bt1_KQ_Click;
            // 
            // Lab01_Bai01
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(488, 226);
            Controls.Add(bt1_KQ);
            Controls.Add(tb_KQ);
            Controls.Add(tb_STT2);
            Controls.Add(tb_STT1);
            Controls.Add(Lb3_KQ);
            Controls.Add(Lb2_STT2);
            Controls.Add(Lb1_STT1);
            Name = "Lab01_Bai01";
            Text = "Lab01_Bai1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb_KQ;
        private TextBox tb_STT2;
        private TextBox tb_STT1;
        private Label Lb3_KQ;
        private Label Lb2_STT2;
        private Label Lb1_STT1;
        private Button bt1_KQ;
    }
}