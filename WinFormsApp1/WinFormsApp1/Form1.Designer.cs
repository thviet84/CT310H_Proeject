namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label7 = new Label();
            panel2 = new Panel();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label8 = new Label();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            panel3 = new Panel();
            dataGridView1 = new DataGridView();
            label9 = new Label();
            textBox6 = new TextBox();
            label10 = new Label();
            textBox7 = new TextBox();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 4);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
            label1.TabIndex = 0;
            label1.Text = "Register Shifts";
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 192, 255);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(4, 2);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(784, 39);
            panel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 46);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 2;
            label2.Text = "Current Week:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(102, 44);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(54, 23);
            textBox1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(214, 47);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 4;
            label3.Text = "Staff:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(257, 44);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(54, 23);
            textBox2.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 82);
            label4.Name = "label4";
            label4.Size = new Size(100, 15);
            label4.TabIndex = 6;
            label4.Text = "Đăng kí cho tuần:";
            label4.Click += label4_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(122, 80);
            textBox3.Margin = new Padding(3, 2, 3, 2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(54, 23);
            textBox3.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(198, 85);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 8;
            label5.Text = "Từ ngày:";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(343, 85);
            label6.Name = "label6";
            label6.Size = new Size(26, 15);
            label6.TabIndex = 9;
            label6.Text = "Tới:";
            label6.Click += label6_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(259, 82);
            textBox4.Margin = new Padding(3, 2, 3, 2);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(54, 23);
            textBox4.TabIndex = 10;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(377, 81);
            textBox5.Margin = new Padding(3, 2, 3, 2);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(54, 23);
            textBox5.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(5, 9);
            label7.Name = "label7";
            label7.Size = new Size(65, 15);
            label7.TabIndex = 12;
            label7.Text = "Chọn ngày";
            label7.Click += label7_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 192, 255);
            panel2.Controls.Add(button7);
            panel2.Controls.Add(button6);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label7);
            panel2.Location = new Point(7, 124);
            panel2.Name = "panel2";
            panel2.Size = new Size(781, 97);
            panel2.TabIndex = 13;
            // 
            // button7
            // 
            button7.Location = new Point(668, 53);
            button7.Name = "button7";
            button7.Size = new Size(75, 23);
            button7.TabIndex = 19;
            button7.Text = "Chủ nhật";
            button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(551, 53);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 18;
            button6.Text = "Thứ 7";
            button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(450, 53);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 17;
            button5.Text = "Thứ 6";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(345, 53);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 16;
            button4.Text = "Thứ 5";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(230, 53);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 15;
            button3.Text = "Thứ 4";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(125, 53);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 14;
            button2.Text = "Thứ 3";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(5, 53);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 13;
            button1.Text = "Thứ 2";
            button1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(2, 9);
            label8.Name = "label8";
            label8.Size = new Size(77, 15);
            label8.TabIndex = 20;
            label8.Text = "Chọn ca làm ";
            label8.Click += label8_Click;
            // 
            // button8
            // 
            button8.Location = new Point(72, 46);
            button8.Name = "button8";
            button8.Size = new Size(119, 23);
            button8.TabIndex = 21;
            button8.Text = "Sáng (5:30 - 11:00)";
            button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Location = new Point(551, 46);
            button9.Name = "button9";
            button9.Size = new Size(149, 23);
            button9.TabIndex = 22;
            button9.Text = "Chiều (17:00 - 23:00)";
            button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            button10.Location = new Point(289, 46);
            button10.Name = "button10";
            button10.Size = new Size(135, 23);
            button10.TabIndex = 23;
            button10.Text = "Trưa (11:00 - 17:00)";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(255, 192, 255);
            panel3.Controls.Add(button10);
            panel3.Controls.Add(button9);
            panel3.Controls.Add(button8);
            panel3.Controls.Add(label8);
            panel3.Location = new Point(7, 246);
            panel3.Name = "panel3";
            panel3.Size = new Size(781, 89);
            panel3.TabIndex = 24;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(8, 349);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(569, 235);
            dataGridView1.TabIndex = 25;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(598, 349);
            label9.Name = "label9";
            label9.Size = new Size(35, 15);
            label9.TabIndex = 24;
            label9.Text = "Ngày";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(598, 367);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(129, 23);
            textBox6.TabIndex = 26;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(598, 402);
            label10.Name = "label10";
            label10.Size = new Size(68, 15);
            label10.TabIndex = 27;
            label10.Text = "Ca làm việc";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(598, 421);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(129, 23);
            textBox7.TabIndex = 28;
            // 
            // button11
            // 
            button11.Location = new Point(598, 462);
            button11.Name = "button11";
            button11.Size = new Size(72, 29);
            button11.TabIndex = 29;
            button11.Text = "Đăng kí";
            button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            button12.Location = new Point(598, 509);
            button12.Name = "button12";
            button12.Size = new Size(91, 29);
            button12.TabIndex = 30;
            button12.Text = "Hủy ca làm";
            button12.UseVisualStyleBackColor = true;
            button12.Click += button12_Click;
            // 
            // button13
            // 
            button13.Location = new Point(598, 555);
            button13.Name = "button13";
            button13.Size = new Size(72, 29);
            button13.TabIndex = 31;
            button13.Text = "Trở về";
            button13.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(788, 610);
            Controls.Add(button13);
            Controls.Add(button12);
            Controls.Add(button11);
            Controls.Add(textBox7);
            Controls.Add(label10);
            Controls.Add(textBox6);
            Controls.Add(label9);
            Controls.Add(dataGridView1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Đăng kí ca làm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private TextBox textBox2;
        private Label label4;
        private TextBox textBox3;
        private Label label5;
        private Label label6;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label7;
        private Panel panel2;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label8;
        private Button button8;
        private Button button9;
        private Button button10;
        private Panel panel3;
        private DataGridView dataGridView1;
        private Label label9;
        private TextBox textBox6;
        private Label label10;
        private TextBox textBox7;
        private Button button11;
        private Button button12;
        private Button button13;
    }
}