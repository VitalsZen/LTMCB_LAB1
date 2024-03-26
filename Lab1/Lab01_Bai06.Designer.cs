namespace Lab1
{
    partial class Lab01_Bai06
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
            tb1_Answer = new TextBox();
            label1 = new Label();
            dtb1_Input = new DateTimePicker();
            bt1_Find = new Button();
            bt3_Exit = new Button();
            bt2_Reset = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // tb1_Answer
            // 
            tb1_Answer.BorderStyle = BorderStyle.FixedSingle;
            tb1_Answer.Location = new Point(223, 122);
            tb1_Answer.Multiline = true;
            tb1_Answer.Name = "tb1_Answer";
            tb1_Answer.ReadOnly = true;
            tb1_Answer.Size = new Size(361, 31);
            tb1_Answer.TabIndex = 0;
            tb1_Answer.TextChanged += tb1_Answer_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F);
            label1.Location = new Point(29, 40);
            label1.Name = "label1";
            label1.Size = new Size(187, 22);
            label1.TabIndex = 1;
            label1.Text = "Nhập ngày tháng năm: ";
            // 
            // dtb1_Input
            // 
            dtb1_Input.Location = new Point(233, 40);
            dtb1_Input.Name = "dtb1_Input";
            dtb1_Input.Size = new Size(250, 27);
            dtb1_Input.TabIndex = 2;
            dtb1_Input.Value = new DateTime(2024, 3, 23, 0, 0, 0, 0);
            // 
            // bt1_Find
            // 
            bt1_Find.BackColor = SystemColors.Info;
            bt1_Find.Font = new Font("Times New Roman", 11F);
            bt1_Find.Location = new Point(29, 178);
            bt1_Find.Name = "bt1_Find";
            bt1_Find.Size = new Size(194, 53);
            bt1_Find.TabIndex = 3;
            bt1_Find.Text = "Tìm cung hoàng đạo";
            bt1_Find.UseVisualStyleBackColor = false;
            bt1_Find.Click += bt1_Find_Click;
            // 
            // bt3_Exit
            // 
            bt3_Exit.BackColor = SystemColors.Info;
            bt3_Exit.Font = new Font("Times New Roman", 11F);
            bt3_Exit.Location = new Point(570, 178);
            bt3_Exit.Name = "bt3_Exit";
            bt3_Exit.Size = new Size(173, 53);
            bt3_Exit.TabIndex = 5;
            bt3_Exit.Text = "Thoát";
            bt3_Exit.UseVisualStyleBackColor = false;
            bt3_Exit.Click += bt3_Exit_Click;
            // 
            // bt2_Reset
            // 
            bt2_Reset.BackColor = SystemColors.Info;
            bt2_Reset.Enabled = false;
            bt2_Reset.Font = new Font("Times New Roman", 11F);
            bt2_Reset.Location = new Point(317, 178);
            bt2_Reset.Name = "bt2_Reset";
            bt2_Reset.Size = new Size(173, 53);
            bt2_Reset.TabIndex = 6;
            bt2_Reset.Text = "Đặt lại";
            bt2_Reset.UseVisualStyleBackColor = false;
            bt2_Reset.Click += bt2_Reset_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F);
            label2.Location = new Point(355, 97);
            label2.Name = "label2";
            label2.Size = new Size(96, 22);
            label2.TabIndex = 7;
            label2.Text = "Cung mệnh";
            // 
            // Lab01_Bai06
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 268);
            Controls.Add(label2);
            Controls.Add(bt2_Reset);
            Controls.Add(bt3_Exit);
            Controls.Add(bt1_Find);
            Controls.Add(dtb1_Input);
            Controls.Add(label1);
            Controls.Add(tb1_Answer);
            Name = "Lab01_Bai06";
            Text = "Lab01_Bai06";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb1_Answer;
        private Label label1;
        private DateTimePicker dtb1_Input;
        private Button bt1_Find;
        private Button bt3_Exit;
        private Button bt2_Reset;
        private Label label2;
    }
}