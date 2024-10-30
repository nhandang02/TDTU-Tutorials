namespace Lab7_2
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
            grb1 = new GroupBox();
            grd = new DataGridView();
            label1 = new Label();
            comboBox1 = new ComboBox();
            Khoa = new Label();
            grp2 = new GroupBox();
            textBox5 = new TextBox();
            label7 = new Label();
            textBox4 = new TextBox();
            label6 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            textBox2 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            groupBox1 = new GroupBox();
            print = new Button();
            save = new Button();
            edit = new Button();
            del = new Button();
            add = new Button();
            grb1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grd).BeginInit();
            grp2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // grb1
            // 
            grb1.Controls.Add(grd);
            grb1.Location = new Point(38, 368);
            grb1.Name = "grb1";
            grb1.Size = new Size(1370, 361);
            grb1.TabIndex = 0;
            grb1.TabStop = false;
            grb1.Text = "Hien Thi Thong Tin";
            // 
            // grd
            // 
            grd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grd.Location = new Point(30, 46);
            grd.Name = "grd";
            grd.RowHeadersWidth = 82;
            grd.Size = new Size(1312, 309);
            grd.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 10);
            label1.Name = "label1";
            label1.Size = new Size(0, 32);
            label1.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(133, 59);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(407, 40);
            comboBox1.TabIndex = 2;
            // 
            // Khoa
            // 
            Khoa.AutoSize = true;
            Khoa.Location = new Point(15, 62);
            Khoa.Name = "Khoa";
            Khoa.Size = new Size(68, 32);
            Khoa.TabIndex = 3;
            Khoa.Text = "Khoa";
            // 
            // grp2
            // 
            grp2.Controls.Add(textBox5);
            grp2.Controls.Add(label7);
            grp2.Controls.Add(textBox4);
            grp2.Controls.Add(label6);
            grp2.Controls.Add(textBox3);
            grp2.Controls.Add(label5);
            grp2.Controls.Add(label4);
            grp2.Controls.Add(dateTimePicker1);
            grp2.Controls.Add(textBox2);
            grp2.Controls.Add(label3);
            grp2.Controls.Add(label2);
            grp2.Controls.Add(textBox1);
            grp2.Controls.Add(Khoa);
            grp2.Controls.Add(comboBox1);
            grp2.Controls.Add(label1);
            grp2.Location = new Point(35, 26);
            grp2.Name = "grp2";
            grp2.Size = new Size(1348, 233);
            grp2.TabIndex = 4;
            grp2.TabStop = false;
            grp2.Text = "Thong Tin Sinh Vien";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(858, 188);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(407, 39);
            textBox5.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(703, 187);
            label7.Name = "label7";
            label7.Size = new Size(103, 32);
            label7.TabIndex = 14;
            label7.Text = "GioiTinh";
            label7.Click += label7_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(858, 139);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(407, 39);
            textBox4.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(703, 146);
            label6.Name = "label6";
            label6.Size = new Size(84, 32);
            label6.TabIndex = 12;
            label6.Text = "DiaChi";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(858, 89);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(407, 39);
            textBox3.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(703, 96);
            label5.Name = "label5";
            label5.Size = new Size(117, 32);
            label5.TabIndex = 10;
            label5.Text = "QueQuan";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(703, 33);
            label4.Name = "label4";
            label4.Size = new Size(117, 32);
            label4.TabIndex = 9;
            label4.Text = "NgaySinh";
            label4.Click += label4_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(858, 28);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(407, 39);
            dateTimePicker1.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(133, 180);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(407, 39);
            textBox2.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 132);
            label3.Name = "label3";
            label3.Size = new Size(77, 32);
            label3.TabIndex = 6;
            label3.Text = "MSSV";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 183);
            label2.Name = "label2";
            label2.Size = new Size(90, 32);
            label2.TabIndex = 5;
            label2.Text = "Ho Ten";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(133, 125);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(407, 39);
            textBox1.TabIndex = 4;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(print);
            groupBox1.Controls.Add(save);
            groupBox1.Controls.Add(edit);
            groupBox1.Controls.Add(del);
            groupBox1.Controls.Add(add);
            groupBox1.Location = new Point(40, 273);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1346, 85);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chuc Nang";
            // 
            // print
            // 
            print.Location = new Point(1019, 33);
            print.Name = "print";
            print.Size = new Size(150, 46);
            print.TabIndex = 4;
            print.Text = "In";
            print.UseVisualStyleBackColor = true;
            // 
            // save
            // 
            save.Location = new Point(814, 33);
            save.Name = "save";
            save.Size = new Size(150, 46);
            save.TabIndex = 3;
            save.Text = "Luu";
            save.UseVisualStyleBackColor = true;
            // 
            // edit
            // 
            edit.Location = new Point(614, 33);
            edit.Name = "edit";
            edit.Size = new Size(150, 46);
            edit.TabIndex = 2;
            edit.Text = "Sua";
            edit.UseVisualStyleBackColor = true;
            // 
            // del
            // 
            del.Location = new Point(405, 33);
            del.Name = "del";
            del.Size = new Size(150, 46);
            del.TabIndex = 1;
            del.Text = "Xoa";
            del.UseVisualStyleBackColor = true;
            // 
            // add
            // 
            add.Location = new Point(191, 33);
            add.Name = "add";
            add.Size = new Size(150, 46);
            add.TabIndex = 0;
            add.Text = "Them ";
            add.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1438, 741);
            Controls.Add(groupBox1);
            Controls.Add(grp2);
            Controls.Add(grb1);
            Name = "Form1";
            Text = "Form1";
            grb1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grd).EndInit();
            grp2.ResumeLayout(false);
            grp2.PerformLayout();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grb1;
        private DataGridView grd;
        private Label label1;
        private ComboBox comboBox1;
        private Label Khoa;
        private GroupBox grp2;
        private Label label2;
        private TextBox textBox1;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox2;
        private Label label3;
        private Label label6;
        private TextBox textBox3;
        private Label label5;
        private Label label7;
        private TextBox textBox4;
        private TextBox textBox5;
        private GroupBox groupBox1;
        private Button print;
        private Button save;
        private Button edit;
        private Button del;
        private Button add;
    }
}
