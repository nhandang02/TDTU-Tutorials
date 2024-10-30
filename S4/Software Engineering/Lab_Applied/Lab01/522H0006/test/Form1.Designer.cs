namespace test
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
            labelMSSV = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtMSSV = new TextBox();
            txtHT = new TextBox();
            txtHL = new TextBox();
            cbQQ = new ComboBox();
            dpNS = new DateTimePicker();
            grp1 = new GroupBox();
            groupBox2 = new GroupBox();
            bXEMIN = new Button();
            bHUY = new Button();
            bLUU = new Button();
            bSUA = new Button();
            bXOA = new Button();
            bTHEM = new Button();
            grd = new DataGridView();
            groupBox1 = new GroupBox();
            grp1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grd).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // labelMSSV
            // 
            labelMSSV.AutoSize = true;
            labelMSSV.Location = new Point(34, 23);
            labelMSSV.Name = "labelMSSV";
            labelMSSV.Size = new Size(110, 20);
            labelMSSV.TabIndex = 1;
            labelMSSV.Text = "Mã số sinh viên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 62);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 2;
            label3.Text = "Quê quán";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 106);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 3;
            label4.Text = "Học lực";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(465, 23);
            label5.Name = "label5";
            label5.Size = new Size(54, 20);
            label5.TabIndex = 4;
            label5.Text = "Họ tên";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(465, 62);
            label6.Name = "label6";
            label6.Size = new Size(74, 20);
            label6.TabIndex = 5;
            label6.Text = "Ngày sinh";
            // 
            // txtMSSV
            // 
            txtMSSV.Location = new Point(150, 20);
            txtMSSV.Name = "txtMSSV";
            txtMSSV.Size = new Size(299, 27);
            txtMSSV.TabIndex = 6;
            // 
            // txtHT
            // 
            txtHT.Location = new Point(549, 20);
            txtHT.Name = "txtHT";
            txtHT.Size = new Size(299, 27);
            txtHT.TabIndex = 7;
            // 
            // txtHL
            // 
            txtHL.Location = new Point(150, 99);
            txtHL.Name = "txtHL";
            txtHL.Size = new Size(299, 27);
            txtHL.TabIndex = 8;
            // 
            // cbQQ
            // 
            cbQQ.FormattingEnabled = true;
            cbQQ.Location = new Point(150, 59);
            cbQQ.Name = "cbQQ";
            cbQQ.Size = new Size(299, 28);
            cbQQ.TabIndex = 9;
            // 
            // dpNS
            // 
            dpNS.Location = new Point(549, 59);
            dpNS.Name = "dpNS";
            dpNS.Size = new Size(299, 27);
            dpNS.TabIndex = 10;
            // 
            // grp1
            // 
            grp1.Controls.Add(labelMSSV);
            grp1.Controls.Add(dpNS);
            grp1.Controls.Add(label3);
            grp1.Controls.Add(cbQQ);
            grp1.Controls.Add(label4);
            grp1.Controls.Add(txtHL);
            grp1.Controls.Add(label5);
            grp1.Controls.Add(txtHT);
            grp1.Controls.Add(label6);
            grp1.Controls.Add(txtMSSV);
            grp1.Location = new Point(12, 12);
            grp1.Name = "grp1";
            grp1.Size = new Size(883, 138);
            grp1.TabIndex = 11;
            grp1.TabStop = false;
            grp1.Text = "Thông tin sinh viên";
            grp1.Enter += groupBox1_Enter;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(bXEMIN);
            groupBox2.Controls.Add(bHUY);
            groupBox2.Controls.Add(bLUU);
            groupBox2.Controls.Add(bSUA);
            groupBox2.Controls.Add(bXOA);
            groupBox2.Controls.Add(bTHEM);
            groupBox2.Location = new Point(12, 156);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(883, 64);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chức năng";
            // 
            // bXEMIN
            // 
            bXEMIN.Location = new Point(607, 26);
            bXEMIN.Name = "bXEMIN";
            bXEMIN.Size = new Size(94, 29);
            bXEMIN.TabIndex = 5;
            bXEMIN.Text = "Xem in";
            bXEMIN.UseVisualStyleBackColor = true;
            // 
            // bHUY
            // 
            bHUY.Location = new Point(507, 26);
            bHUY.Name = "bHUY";
            bHUY.Size = new Size(94, 29);
            bHUY.TabIndex = 4;
            bHUY.Text = "Hủy";
            bHUY.UseVisualStyleBackColor = true;
            bHUY.Click += bHUY_Click;
            // 
            // bLUU
            // 
            bLUU.Location = new Point(407, 26);
            bLUU.Name = "bLUU";
            bLUU.Size = new Size(94, 29);
            bLUU.TabIndex = 3;
            bLUU.Text = "Lưu";
            bLUU.UseVisualStyleBackColor = true;
            bLUU.Click += bLUU_Click;
            // 
            // bSUA
            // 
            bSUA.Location = new Point(307, 26);
            bSUA.Name = "bSUA";
            bSUA.Size = new Size(94, 29);
            bSUA.TabIndex = 2;
            bSUA.Text = "Sửa";
            bSUA.UseVisualStyleBackColor = true;
            bSUA.Click += bSUA_Click;
            // 
            // bXOA
            // 
            bXOA.Location = new Point(207, 26);
            bXOA.Name = "bXOA";
            bXOA.Size = new Size(94, 29);
            bXOA.TabIndex = 1;
            bXOA.Text = "Xóa";
            bXOA.UseVisualStyleBackColor = true;
            bXOA.Click += bXOA_Click;
            // 
            // bTHEM
            // 
            bTHEM.Location = new Point(107, 26);
            bTHEM.Name = "bTHEM";
            bTHEM.Size = new Size(94, 29);
            bTHEM.TabIndex = 0;
            bTHEM.Text = "Thêm";
            bTHEM.UseVisualStyleBackColor = true;
            bTHEM.Click += bTHEM_CLICK;
            // 
            // grd
            // 
            grd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grd.Location = new Point(6, 26);
            grd.Name = "grd";
            grd.RowHeadersWidth = 51;
            grd.Size = new Size(871, 234);
            grd.TabIndex = 15;
            grd.Click += grd_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(grd);
            groupBox1.Location = new Point(12, 236);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(883, 260);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách sinh viên";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(907, 498);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Controls.Add(grp1);
            Name = "Form1";
            Text = "Quản lý sinh viên";
            Load += Form1_Load;
            grp1.ResumeLayout(false);
            grp1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grd).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label labelMSSV;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtMSSV;
        private TextBox txtHT;
        private TextBox txtHL;
        private ComboBox cbQQ;
        private DateTimePicker dpNS;
        private GroupBox grp1;
        private GroupBox groupBox2;
        private Button bXEMIN;
        private Button bHUY;
        private Button bLUU;
        private Button bSUA;
        private Button bXOA;
        private Button bTHEM;
        private DataGridView grd;
        private GroupBox groupBox1;
    }
}
