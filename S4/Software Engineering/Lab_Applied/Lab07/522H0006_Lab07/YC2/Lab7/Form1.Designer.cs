namespace Lab7
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
            grd = new DataGridView();
            grp3 = new GroupBox();
            bADD = new Button();
            bDEL = new Button();
            bEDIT = new Button();
            bSAVE = new Button();
            bCANCEL = new Button();
            grp2 = new GroupBox();
            cbKhoa = new ComboBox();
            label4 = new Label();
            label1 = new Label();
            label3 = new Label();
            label5 = new Label();
            label2 = new Label();
            txtMK = new TextBox();
            txtSDT = new TextBox();
            txtTK = new TextBox();
            txtDD = new TextBox();
            grp1 = new GroupBox();
            textBox1 = new TextBox();
            label6 = new Label();
            label7 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)grd).BeginInit();
            grp3.SuspendLayout();
            grp2.SuspendLayout();
            grp1.SuspendLayout();
            SuspendLayout();
            // 
            // grd
            // 
            grd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grd.Location = new Point(11, 28);
            grd.Margin = new Padding(3, 4, 3, 4);
            grd.Name = "grd";
            grd.RowHeadersWidth = 62;
            grd.RowTemplate.Height = 25;
            grd.Size = new Size(771, 410);
            grd.TabIndex = 0;
            grd.CellContentClick += grd_CellContentClick;
            grd.Click += grd_Click;
            // 
            // grp3
            // 
            grp3.Controls.Add(grd);
            grp3.Location = new Point(29, 283);
            grp3.Margin = new Padding(3, 4, 3, 4);
            grp3.Name = "grp3";
            grp3.Padding = new Padding(3, 4, 3, 4);
            grp3.Size = new Size(788, 330);
            grp3.TabIndex = 18;
            grp3.TabStop = false;
            grp3.Text = "Danh sách khoa";
            grp3.Enter += grp3_Enter;
            // 
            // bADD
            // 
            bADD.Location = new Point(53, 22);
            bADD.Margin = new Padding(3, 4, 3, 4);
            bADD.Name = "bADD";
            bADD.Size = new Size(78, 40);
            bADD.TabIndex = 0;
            bADD.Text = "Add";
            bADD.UseVisualStyleBackColor = true;
            bADD.Click += bADD_Click;
            // 
            // bDEL
            // 
            bDEL.Location = new Point(137, 22);
            bDEL.Margin = new Padding(3, 4, 3, 4);
            bDEL.Name = "bDEL";
            bDEL.Size = new Size(78, 40);
            bDEL.TabIndex = 2;
            bDEL.Text = "Delete";
            bDEL.UseVisualStyleBackColor = true;
            bDEL.Click += bDEL_Click;
            // 
            // bEDIT
            // 
            bEDIT.Location = new Point(222, 22);
            bEDIT.Margin = new Padding(3, 4, 3, 4);
            bEDIT.Name = "bEDIT";
            bEDIT.Size = new Size(78, 40);
            bEDIT.TabIndex = 3;
            bEDIT.Text = "Edit";
            bEDIT.UseVisualStyleBackColor = true;
            // 
            // bSAVE
            // 
            bSAVE.Location = new Point(306, 22);
            bSAVE.Margin = new Padding(3, 4, 3, 4);
            bSAVE.Name = "bSAVE";
            bSAVE.Size = new Size(78, 40);
            bSAVE.TabIndex = 1;
            bSAVE.Text = "Save";
            bSAVE.UseVisualStyleBackColor = true;
            bSAVE.Click += bSAVE_Click;
            // 
            // bCANCEL
            // 
            bCANCEL.Location = new Point(391, 22);
            bCANCEL.Margin = new Padding(3, 4, 3, 4);
            bCANCEL.Name = "bCANCEL";
            bCANCEL.Size = new Size(78, 40);
            bCANCEL.TabIndex = 4;
            bCANCEL.Text = "Cancel";
            bCANCEL.UseVisualStyleBackColor = true;
            bCANCEL.Click += bCANCEL_Click;
            // 
            // grp2
            // 
            grp2.Controls.Add(bCANCEL);
            grp2.Controls.Add(bSAVE);
            grp2.Controls.Add(bEDIT);
            grp2.Controls.Add(bDEL);
            grp2.Controls.Add(bADD);
            grp2.Location = new Point(29, 199);
            grp2.Margin = new Padding(3, 4, 3, 4);
            grp2.Name = "grp2";
            grp2.Padding = new Padding(3, 4, 3, 4);
            grp2.Size = new Size(788, 76);
            grp2.TabIndex = 19;
            grp2.TabStop = false;
            grp2.Text = "Functions";
            // 
            // cbKhoa
            // 
            cbKhoa.FormattingEnabled = true;
            cbKhoa.Location = new Point(94, 25);
            cbKhoa.Name = "cbKhoa";
            cbKhoa.Size = new Size(723, 28);
            cbKhoa.TabIndex = 20;
            cbKhoa.SelectedIndexChanged += cbHT_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(45, 33);
            label4.Name = "label4";
            label4.Size = new Size(43, 20);
            label4.TabIndex = 21;
            label4.Text = "Khoa";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 30);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã SV";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 73);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 0;
            label3.Text = "Quê quán";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(302, 73);
            label5.Name = "label5";
            label5.Size = new Size(57, 20);
            label5.TabIndex = 0;
            label5.Text = "Địa Chỉ";
            label5.Click += label5_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(302, 25);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 0;
            label2.Text = "Tên SV";
            label2.Click += label2_Click;
            // 
            // txtMK
            // 
            txtMK.AcceptsReturn = true;
            txtMK.Location = new Point(102, 22);
            txtMK.Margin = new Padding(3, 4, 3, 4);
            txtMK.Name = "txtMK";
            txtMK.Size = new Size(178, 27);
            txtMK.TabIndex = 0;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(365, 70);
            txtSDT.Margin = new Padding(3, 4, 3, 4);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(178, 27);
            txtSDT.TabIndex = 4;
            // 
            // txtTK
            // 
            txtTK.Location = new Point(365, 18);
            txtTK.Margin = new Padding(3, 4, 3, 4);
            txtTK.Name = "txtTK";
            txtTK.Size = new Size(178, 27);
            txtTK.TabIndex = 1;
            txtTK.TextChanged += txtTK_TextChanged;
            // 
            // txtDD
            // 
            txtDD.Location = new Point(102, 68);
            txtDD.Margin = new Padding(3, 4, 3, 4);
            txtDD.Name = "txtDD";
            txtDD.Size = new Size(178, 27);
            txtDD.TabIndex = 5;
            // 
            // grp1
            // 
            grp1.Controls.Add(radioButton2);
            grp1.Controls.Add(radioButton1);
            grp1.Controls.Add(label7);
            grp1.Controls.Add(textBox1);
            grp1.Controls.Add(label6);
            grp1.Controls.Add(txtDD);
            grp1.Controls.Add(txtTK);
            grp1.Controls.Add(txtSDT);
            grp1.Controls.Add(txtMK);
            grp1.Controls.Add(label2);
            grp1.Controls.Add(label5);
            grp1.Controls.Add(label3);
            grp1.Controls.Add(label1);
            grp1.Location = new Point(29, 85);
            grp1.Margin = new Padding(3, 4, 3, 4);
            grp1.Name = "grp1";
            grp1.Padding = new Padding(3, 4, 3, 4);
            grp1.Size = new Size(788, 106);
            grp1.TabIndex = 16;
            grp1.TabStop = false;
            grp1.Text = "Thông tin Khoa";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(626, 18);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(140, 27);
            textBox1.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(549, 24);
            label6.Name = "label6";
            label6.Size = new Size(74, 20);
            label6.TabIndex = 6;
            label6.Text = "Ngày sinh";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(549, 73);
            label7.Name = "label7";
            label7.Size = new Size(65, 20);
            label7.TabIndex = 8;
            label7.Text = "Giới tính";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(626, 71);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(62, 24);
            radioButton1.TabIndex = 9;
            radioButton1.TabStop = true;
            radioButton1.Text = "Nam";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(694, 71);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(50, 24);
            radioButton2.TabIndex = 10;
            radioButton2.TabStop = true;
            radioButton2.Text = "Nữ";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(856, 726);
            Controls.Add(label4);
            Controls.Add(cbKhoa);
            Controls.Add(grp2);
            Controls.Add(grp3);
            Controls.Add(grp1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)grd).EndInit();
            grp3.ResumeLayout(false);
            grp2.ResumeLayout(false);
            grp1.ResumeLayout(false);
            grp1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView grd;
        private GroupBox grp3;
        private Button bADD;
        private Button bDEL;
        private Button bEDIT;
        private Button bSAVE;
        private Button bCANCEL;
        private GroupBox grp2;
        private ComboBox cbKhoa;
        private Label label4;
        private Label label1;
        private Label label3;
        private Label label5;
        private Label label2;
        private TextBox txtMK;
        private TextBox txtSDT;
        private TextBox txtTK;
        private TextBox txtDD;
        private GroupBox grp1;
        private Label label7;
        private TextBox textBox1;
        private Label label6;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
    }
}
