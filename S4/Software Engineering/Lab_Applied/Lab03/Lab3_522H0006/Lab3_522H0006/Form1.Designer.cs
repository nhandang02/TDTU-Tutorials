namespace Lab3_522H0006
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
            cbHT = new ComboBox();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            groupBox1 = new GroupBox();
            grd = new DataGridView();
            groupBox2 = new GroupBox();
            button10 = new Button();
            button9 = new Button();
            cbSV = new ComboBox();
            label3 = new Label();
            button8 = new Button();
            button7 = new Button();
            cbH2 = new ComboBox();
            label2 = new Label();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grd).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // cbHT
            // 
            cbHT.FormattingEnabled = true;
            cbHT.Location = new Point(236, 43);
            cbHT.Name = "cbHT";
            cbHT.Size = new Size(599, 40);
            cbHT.TabIndex = 0;
            cbHT.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 46);
            label1.Name = "label1";
            label1.Size = new Size(120, 32);
            label1.TabIndex = 1;
            label1.Text = "Quê quán";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(841, 43);
            button1.Name = "button1";
            button1.Size = new Size(193, 46);
            button1.TabIndex = 2;
            button1.Text = "Tất cả";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(1051, 68);
            button2.Name = "button2";
            button2.Size = new Size(196, 46);
            button2.TabIndex = 3;
            button2.Text = "Xem in";
            button2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(grd);
            groupBox1.Location = new Point(23, 295);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1207, 480);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách sinh viên";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // grd
            // 
            grd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grd.Location = new Point(24, 68);
            grd.Name = "grd";
            grd.RowHeadersWidth = 82;
            grd.Size = new Size(1168, 477);
            grd.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button10);
            groupBox2.Controls.Add(button9);
            groupBox2.Controls.Add(cbSV);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(button8);
            groupBox2.Controls.Add(button7);
            groupBox2.Controls.Add(cbH2);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(cbHT);
            groupBox2.Location = new Point(11, 25);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1246, 264);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tìm kiếm";
            // 
            // button10
            // 
            button10.Location = new Point(1040, 159);
            button10.Name = "button10";
            button10.Size = new Size(196, 46);
            button10.TabIndex = 11;
            button10.Text = "Xem in";
            button10.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Location = new Point(841, 159);
            button9.Name = "button9";
            button9.Size = new Size(193, 46);
            button9.TabIndex = 10;
            button9.Text = "Tất cả";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // cbSV
            // 
            cbSV.FormattingEnabled = true;
            cbSV.Location = new Point(236, 159);
            cbSV.Name = "cbSV";
            cbSV.Size = new Size(599, 40);
            cbSV.TabIndex = 9;
            cbSV.SelectedIndexChanged += comboBox1_SelectedIndexChanged_2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 162);
            label3.Name = "label3";
            label3.Size = new Size(113, 32);
            label3.TabIndex = 8;
            label3.Text = "Sinh viên";
            label3.Click += label3_Click;
            // 
            // button8
            // 
            button8.Location = new Point(1040, 98);
            button8.Name = "button8";
            button8.Size = new Size(196, 46);
            button8.TabIndex = 7;
            button8.Text = "Xem in";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button7
            // 
            button7.Location = new Point(841, 98);
            button7.Name = "button7";
            button7.Size = new Size(193, 46);
            button7.TabIndex = 6;
            button7.Text = "Tất cả";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // cbH2
            // 
            cbH2.FormattingEnabled = true;
            cbH2.Location = new Point(236, 102);
            cbH2.Name = "cbH2";
            cbH2.Size = new Size(599, 40);
            cbH2.TabIndex = 5;
            cbH2.SelectedIndexChanged += comboBox1_SelectedIndexChanged_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 102);
            label2.Name = "label2";
            label2.Size = new Size(199, 32);
            label2.TabIndex = 4;
            label2.Text = "Chủ nhiệm đề tài";
            // 
            // button3
            // 
            button3.Location = new Point(1040, 43);
            button3.Name = "button3";
            button3.Size = new Size(200, 46);
            button3.TabIndex = 3;
            button3.Text = "Xem in";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(1278, 120);
            button4.Name = "button4";
            button4.Size = new Size(193, 46);
            button4.TabIndex = 6;
            button4.Text = "KP <= 100 triệu";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(1275, 57);
            button5.Name = "button5";
            button5.Size = new Size(196, 46);
            button5.TabIndex = 7;
            button5.Text = "KP <= 10 triệu";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(1278, 187);
            button6.Name = "button6";
            button6.Size = new Size(193, 46);
            button6.TabIndex = 8;
            button6.Text = "> 100 triệu";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1491, 790);
            Controls.Add(button6);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(button2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grd).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cbHT;
        private Label label1;
        private Button button1;
        private Button button2;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button button3;
        private DataGridView grd;
        private Label label2;
        private Button button5;
        private Button button4;
        private Button button6;
        private ComboBox cbH2;
        private Button button7;
        private Button button8;
        private Label label3;
        private Button button10;
        private Button button9;
        private ComboBox cbSV;
    }
}
