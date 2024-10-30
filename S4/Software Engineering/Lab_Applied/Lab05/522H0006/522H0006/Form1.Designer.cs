namespace _522H0006
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
            bSAVE = new Button();
            bEDIT = new Button();
            bADD = new Button();
            txtDD = new TextBox();
            txtTK = new TextBox();
            txtSDT = new TextBox();
            txtMK = new TextBox();
            label2 = new Label();
            bCANCEL = new Button();
            grd = new DataGridView();
            label5 = new Label();
            label3 = new Label();
            bDEL = new Button();
            grp3 = new GroupBox();
            grp1 = new GroupBox();
            label1 = new Label();
            grp2 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)grd).BeginInit();
            grp3.SuspendLayout();
            grp1.SuspendLayout();
            grp2.SuspendLayout();
            SuspendLayout();
            // 
            // bSAVE
            // 
            bSAVE.Location = new Point(497, 35);
            bSAVE.Margin = new Padding(5, 6, 5, 6);
            bSAVE.Name = "bSAVE";
            bSAVE.Size = new Size(127, 64);
            bSAVE.TabIndex = 1;
            bSAVE.Text = "Save";
            bSAVE.UseVisualStyleBackColor = true;
            // 
            // bEDIT
            // 
            bEDIT.Location = new Point(361, 35);
            bEDIT.Margin = new Padding(5, 6, 5, 6);
            bEDIT.Name = "bEDIT";
            bEDIT.Size = new Size(127, 64);
            bEDIT.TabIndex = 3;
            bEDIT.Text = "Edit";
            bEDIT.UseVisualStyleBackColor = true;
            // 
            // bADD
            // 
            bADD.Location = new Point(86, 35);
            bADD.Margin = new Padding(5, 6, 5, 6);
            bADD.Name = "bADD";
            bADD.Size = new Size(127, 64);
            bADD.TabIndex = 0;
            bADD.Text = "Add";
            bADD.UseVisualStyleBackColor = true;
            bADD.Click += bADD_Click;
            // 
            // txtDD
            // 
            txtDD.Location = new Point(166, 109);
            txtDD.Margin = new Padding(5, 6, 5, 6);
            txtDD.Name = "txtDD";
            txtDD.Size = new Size(287, 39);
            txtDD.TabIndex = 5;
            // 
            // txtTK
            // 
            txtTK.Location = new Point(904, 34);
            txtTK.Margin = new Padding(5, 6, 5, 6);
            txtTK.Name = "txtTK";
            txtTK.Size = new Size(287, 39);
            txtTK.TabIndex = 1;
            txtTK.TextChanged += txtTK_TextChanged;
            txtTK.Leave += txtTK_Leave;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(904, 102);
            txtSDT.Margin = new Padding(5, 6, 5, 6);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(287, 39);
            txtSDT.TabIndex = 4;
            // 
            // txtMK
            // 
            txtMK.AcceptsReturn = true;
            txtMK.Location = new Point(166, 35);
            txtMK.Margin = new Padding(5, 6, 5, 6);
            txtMK.Name = "txtMK";
            txtMK.Size = new Size(287, 39);
            txtMK.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(735, 43);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(113, 32);
            label2.TabIndex = 0;
            label2.Text = "Tên Khoa";
            // 
            // bCANCEL
            // 
            bCANCEL.Location = new Point(635, 35);
            bCANCEL.Margin = new Padding(5, 6, 5, 6);
            bCANCEL.Name = "bCANCEL";
            bCANCEL.Size = new Size(127, 64);
            bCANCEL.TabIndex = 4;
            bCANCEL.Text = "Cancel";
            bCANCEL.UseVisualStyleBackColor = true;
            // 
            // grd
            // 
            grd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grd.Location = new Point(18, 44);
            grd.Margin = new Padding(5, 6, 5, 6);
            grd.Name = "grd";
            grd.RowHeadersWidth = 62;
            grd.RowTemplate.Height = 25;
            grd.Size = new Size(1253, 465);
            grd.TabIndex = 0;
            grd.CellClick += grd_CellClick;
            grd.CellContentClick += grd_CellContentClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(735, 105);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(156, 32);
            label5.TabIndex = 0;
            label5.Text = "Số điện thoại";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 120);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(110, 32);
            label3.TabIndex = 0;
            label3.Text = "Địa điểm";
            // 
            // bDEL
            // 
            bDEL.Location = new Point(223, 35);
            bDEL.Margin = new Padding(5, 6, 5, 6);
            bDEL.Name = "bDEL";
            bDEL.Size = new Size(127, 64);
            bDEL.TabIndex = 2;
            bDEL.Text = "Delete";
            bDEL.UseVisualStyleBackColor = true;
            // 
            // grp3
            // 
            grp3.Controls.Add(grd);
            grp3.Location = new Point(68, 324);
            grp3.Margin = new Padding(5, 6, 5, 6);
            grp3.Name = "grp3";
            grp3.Padding = new Padding(5, 6, 5, 6);
            grp3.Size = new Size(1324, 530);
            grp3.TabIndex = 21;
            grp3.TabStop = false;
            grp3.Text = "Danh sách khoa";
            // 
            // grp1
            // 
            grp1.Controls.Add(txtDD);
            grp1.Controls.Add(txtTK);
            grp1.Controls.Add(txtSDT);
            grp1.Controls.Add(txtMK);
            grp1.Controls.Add(label2);
            grp1.Controls.Add(label5);
            grp1.Controls.Add(label3);
            grp1.Controls.Add(label1);
            grp1.Location = new Point(68, 25);
            grp1.Margin = new Padding(5, 6, 5, 6);
            grp1.Name = "grp1";
            grp1.Padding = new Padding(5, 6, 5, 6);
            grp1.Size = new Size(1280, 170);
            grp1.TabIndex = 20;
            grp1.TabStop = false;
            grp1.Text = "Thông tin Khoa";
            grp1.Enter += grp1_Enter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 51);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(109, 32);
            label1.TabIndex = 0;
            label1.Text = "Mã Khoa";
            // 
            // grp2
            // 
            grp2.Controls.Add(bCANCEL);
            grp2.Controls.Add(bSAVE);
            grp2.Controls.Add(bEDIT);
            grp2.Controls.Add(bDEL);
            grp2.Controls.Add(bADD);
            grp2.Location = new Point(68, 207);
            grp2.Margin = new Padding(5, 6, 5, 6);
            grp2.Name = "grp2";
            grp2.Padding = new Padding(5, 6, 5, 6);
            grp2.Size = new Size(1290, 115);
            grp2.TabIndex = 22;
            grp2.TabStop = false;
            grp2.Text = "Functions";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1414, 845);
            Controls.Add(grp3);
            Controls.Add(grp1);
            Controls.Add(grp2);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)grd).EndInit();
            grp3.ResumeLayout(false);
            grp1.ResumeLayout(false);
            grp1.PerformLayout();
            grp2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button bSAVE;
        private Button bEDIT;
        private Button bADD;
        private TextBox txtDD;
        private TextBox txtTK;
        private TextBox txtSDT;
        private TextBox txtMK;
        private Label label2;
        private Button bCANCEL;
        private DataGridView grd;
        private Label label5;
        private Label label3;
        private Button bDEL;
        private GroupBox grp3;
        private GroupBox grp1;
        private Label label1;
        private GroupBox grp2;
    }
}
