namespace GUI
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            groupBox2 = new GroupBox();
            txtTIM = new TextBox();
            textBox = new Label();
            BTIM = new Button();
            grp3 = new GroupBox();
            grd1 = new DataGridView();
            grp1 = new GroupBox();
            txtSoLuong = new TextBox();
            txtTacGia = new TextBox();
            label8 = new Label();
            label3 = new Label();
            txtTenSach = new TextBox();
            label2 = new Label();
            txtMaSach = new TextBox();
            label1 = new Label();
            grp2 = new GroupBox();
            BIN = new Button();
            BLUU = new Button();
            BSUA = new Button();
            BXOA = new Button();
            BTHEM = new Button();
            tabPage2 = new TabPage();
            groupBox1 = new GroupBox();
            grd2 = new DataGridView();
            grp4 = new GroupBox();
            CHITIET = new Button();
            SHOW = new Button();
            ngayTRA = new DateTimePicker();
            label7 = new Label();
            BMUON = new Button();
            ngayMuon = new DateTimePicker();
            maSachMuon = new TextBox();
            maDGMuon = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox2.SuspendLayout();
            grp3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grd1).BeginInit();
            grp1.SuspendLayout();
            grp2.SuspendLayout();
            tabPage2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grd2).BeginInit();
            grp4.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(-3, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1420, 872);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox2);
            tabPage1.Controls.Add(grp3);
            tabPage1.Controls.Add(grp1);
            tabPage1.Controls.Add(grp2);
            tabPage1.Location = new Point(8, 46);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1404, 818);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Quản lý sách";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtTIM);
            groupBox2.Controls.Add(textBox);
            groupBox2.Controls.Add(BTIM);
            groupBox2.Location = new Point(207, 283);
            groupBox2.Margin = new Padding(5);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(5);
            groupBox2.Size = new Size(1042, 83);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tìm kiếm";
            // 
            // txtTIM
            // 
            txtTIM.Location = new Point(333, 34);
            txtTIM.Margin = new Padding(5);
            txtTIM.Name = "txtTIM";
            txtTIM.Size = new Size(344, 39);
            txtTIM.TabIndex = 4;
            // 
            // textBox
            // 
            textBox.AutoSize = true;
            textBox.Location = new Point(142, 36);
            textBox.Margin = new Padding(5, 0, 5, 0);
            textBox.Name = "textBox";
            textBox.Size = new Size(102, 32);
            textBox.TabIndex = 3;
            textBox.Text = "Mã sách";
            // 
            // BTIM
            // 
            BTIM.Location = new Point(756, 29);
            BTIM.Margin = new Padding(5);
            BTIM.Name = "BTIM";
            BTIM.Size = new Size(130, 48);
            BTIM.TabIndex = 2;
            BTIM.Text = "Tìm";
            BTIM.UseVisualStyleBackColor = true;
            BTIM.Click += BTIM_Click;
            // 
            // grp3
            // 
            grp3.Controls.Add(grd1);
            grp3.Location = new Point(207, 376);
            grp3.Margin = new Padding(5);
            grp3.Name = "grp3";
            grp3.Padding = new Padding(5);
            grp3.Size = new Size(1037, 434);
            grp3.TabIndex = 13;
            grp3.TabStop = false;
            grp3.Text = "Thông tin về sách";
            // 
            // grd1
            // 
            grd1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grd1.Location = new Point(31, 42);
            grd1.Margin = new Padding(5);
            grd1.Name = "grd1";
            grd1.RowHeadersWidth = 51;
            grd1.RowTemplate.Height = 29;
            grd1.Size = new Size(977, 382);
            grd1.TabIndex = 0;
            grd1.CellClick += grd1_CellClick;
            // 
            // grp1
            // 
            grp1.Controls.Add(txtSoLuong);
            grp1.Controls.Add(txtTacGia);
            grp1.Controls.Add(label8);
            grp1.Controls.Add(label3);
            grp1.Controls.Add(txtTenSach);
            grp1.Controls.Add(label2);
            grp1.Controls.Add(txtMaSach);
            grp1.Controls.Add(label1);
            grp1.Location = new Point(202, 0);
            grp1.Margin = new Padding(5);
            grp1.Name = "grp1";
            grp1.Padding = new Padding(5);
            grp1.Size = new Size(1042, 176);
            grp1.TabIndex = 11;
            grp1.TabStop = false;
            grp1.Text = "Quản lý sách";
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(618, 118);
            txtSoLuong.Margin = new Padding(5);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(292, 39);
            txtSoLuong.TabIndex = 7;
            // 
            // txtTacGia
            // 
            txtTacGia.Location = new Point(158, 118);
            txtTacGia.Margin = new Padding(5);
            txtTacGia.Name = "txtTacGia";
            txtTacGia.Size = new Size(292, 39);
            txtTacGia.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(504, 125);
            label8.Margin = new Padding(5, 0, 5, 0);
            label8.Name = "label8";
            label8.Size = new Size(110, 32);
            label8.TabIndex = 5;
            label8.Text = "Số lượng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 120);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(86, 32);
            label3.TabIndex = 4;
            label3.Text = "Tác giả";
            // 
            // txtTenSach
            // 
            txtTenSach.Location = new Point(618, 53);
            txtTenSach.Margin = new Padding(5);
            txtTenSach.Name = "txtTenSach";
            txtTenSach.Size = new Size(392, 39);
            txtTenSach.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(504, 60);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(106, 32);
            label2.TabIndex = 2;
            label2.Text = "Tên sách";
            // 
            // txtMaSach
            // 
            txtMaSach.Location = new Point(156, 48);
            txtMaSach.Margin = new Padding(5);
            txtMaSach.Name = "txtMaSach";
            txtMaSach.Size = new Size(288, 39);
            txtMaSach.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 55);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(102, 32);
            label1.TabIndex = 0;
            label1.Text = "Mã sách";
            // 
            // grp2
            // 
            grp2.Controls.Add(BIN);
            grp2.Controls.Add(BLUU);
            grp2.Controls.Add(BSUA);
            grp2.Controls.Add(BXOA);
            grp2.Controls.Add(BTHEM);
            grp2.Location = new Point(207, 186);
            grp2.Margin = new Padding(5);
            grp2.Name = "grp2";
            grp2.Padding = new Padding(5);
            grp2.Size = new Size(1042, 101);
            grp2.TabIndex = 12;
            grp2.TabStop = false;
            grp2.Text = "Thao tác";
            // 
            // BIN
            // 
            BIN.Location = new Point(835, 42);
            BIN.Margin = new Padding(5);
            BIN.Name = "BIN";
            BIN.Size = new Size(130, 48);
            BIN.TabIndex = 2;
            BIN.Text = "In";
            BIN.UseVisualStyleBackColor = true;
            BIN.Click += BIN_Click;
            // 
            // BLUU
            // 
            BLUU.Location = new Point(653, 42);
            BLUU.Margin = new Padding(5);
            BLUU.Name = "BLUU";
            BLUU.Size = new Size(130, 48);
            BLUU.TabIndex = 2;
            BLUU.Text = "Lưu";
            BLUU.UseVisualStyleBackColor = true;
            BLUU.Click += BLUU_Click;
            // 
            // BSUA
            // 
            BSUA.Location = new Point(450, 42);
            BSUA.Margin = new Padding(5);
            BSUA.Name = "BSUA";
            BSUA.Size = new Size(130, 48);
            BSUA.TabIndex = 2;
            BSUA.Text = "Sửa";
            BSUA.UseVisualStyleBackColor = true;
            BSUA.Click += BSUA_Click;
            // 
            // BXOA
            // 
            BXOA.Location = new Point(237, 42);
            BXOA.Margin = new Padding(5);
            BXOA.Name = "BXOA";
            BXOA.Size = new Size(130, 48);
            BXOA.TabIndex = 1;
            BXOA.Text = "Xóa";
            BXOA.UseVisualStyleBackColor = true;
            BXOA.Click += BXOA_Click;
            // 
            // BTHEM
            // 
            BTHEM.Location = new Point(47, 42);
            BTHEM.Margin = new Padding(5);
            BTHEM.Name = "BTHEM";
            BTHEM.Size = new Size(130, 48);
            BTHEM.TabIndex = 0;
            BTHEM.Text = "Thêm";
            BTHEM.UseVisualStyleBackColor = true;
            BTHEM.Click += BTHEM_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(groupBox1);
            tabPage2.Controls.Add(grp4);
            tabPage2.Location = new Point(8, 46);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1404, 818);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Mượn sách";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(grd2);
            groupBox1.Location = new Point(236, 377);
            groupBox1.Margin = new Padding(5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(5);
            groupBox1.Size = new Size(958, 434);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin mượn sách";
            // 
            // grd2
            // 
            grd2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grd2.Location = new Point(21, 42);
            grd2.Margin = new Padding(5);
            grd2.Name = "grd2";
            grd2.RowHeadersWidth = 51;
            grd2.RowTemplate.Height = 29;
            grd2.Size = new Size(910, 382);
            grd2.TabIndex = 0;
            // 
            // grp4
            // 
            grp4.Controls.Add(CHITIET);
            grp4.Controls.Add(SHOW);
            grp4.Controls.Add(ngayTRA);
            grp4.Controls.Add(label7);
            grp4.Controls.Add(BMUON);
            grp4.Controls.Add(ngayMuon);
            grp4.Controls.Add(maSachMuon);
            grp4.Controls.Add(maDGMuon);
            grp4.Controls.Add(label6);
            grp4.Controls.Add(label5);
            grp4.Controls.Add(label4);
            grp4.Location = new Point(274, 8);
            grp4.Margin = new Padding(5);
            grp4.Name = "grp4";
            grp4.Padding = new Padding(5);
            grp4.Size = new Size(887, 360);
            grp4.TabIndex = 12;
            grp4.TabStop = false;
            grp4.Text = "Mượn sách";
            // 
            // CHITIET
            // 
            CHITIET.Location = new Point(610, 242);
            CHITIET.Margin = new Padding(5);
            CHITIET.Name = "CHITIET";
            CHITIET.Size = new Size(169, 62);
            CHITIET.TabIndex = 10;
            CHITIET.Text = "CTPM";
            CHITIET.UseVisualStyleBackColor = true;
            CHITIET.Click += CHITIET_Click;
            // 
            // SHOW
            // 
            SHOW.Location = new Point(335, 245);
            SHOW.Margin = new Padding(5);
            SHOW.Name = "SHOW";
            SHOW.Size = new Size(169, 62);
            SHOW.TabIndex = 9;
            SHOW.Text = "DS Mượn";
            SHOW.UseVisualStyleBackColor = true;
            SHOW.Click += SHOW_Click;
            // 
            // ngayTRA
            // 
            ngayTRA.Location = new Point(198, 166);
            ngayTRA.Margin = new Padding(5);
            ngayTRA.Name = "ngayTRA";
            ngayTRA.Size = new Size(391, 39);
            ngayTRA.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(25, 180);
            label7.Margin = new Padding(5, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new Size(105, 32);
            label7.TabIndex = 7;
            label7.Text = "Ngày trả";
            // 
            // BMUON
            // 
            BMUON.Location = new Point(52, 248);
            BMUON.Margin = new Padding(5);
            BMUON.Name = "BMUON";
            BMUON.Size = new Size(169, 56);
            BMUON.TabIndex = 6;
            BMUON.Text = "Mượn";
            BMUON.UseVisualStyleBackColor = true;
            BMUON.Click += BMUON_Click;
            // 
            // ngayMuon
            // 
            ngayMuon.Location = new Point(198, 99);
            ngayMuon.Margin = new Padding(5);
            ngayMuon.Name = "ngayMuon";
            ngayMuon.Size = new Size(391, 39);
            ngayMuon.TabIndex = 5;
            // 
            // maSachMuon
            // 
            maSachMuon.Location = new Point(500, 35);
            maSachMuon.Margin = new Padding(5);
            maSachMuon.Name = "maSachMuon";
            maSachMuon.Size = new Size(178, 39);
            maSachMuon.TabIndex = 4;
            // 
            // maDGMuon
            // 
            maDGMuon.Location = new Point(169, 35);
            maDGMuon.Margin = new Padding(5);
            maDGMuon.Name = "maDGMuon";
            maDGMuon.Size = new Size(178, 39);
            maDGMuon.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(25, 112);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(140, 32);
            label6.TabIndex = 2;
            label6.Text = "Ngày mượn";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(390, 42);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(102, 32);
            label5.TabIndex = 1;
            label5.Text = "Mã sách";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 42);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(133, 32);
            label4.TabIndex = 0;
            label4.Text = "Mã độc giả";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1446, 886);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            grp3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grd1).EndInit();
            grp1.ResumeLayout(false);
            grp1.PerformLayout();
            grp2.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grd2).EndInit();
            grp4.ResumeLayout(false);
            grp4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private GroupBox groupBox2;
        private TextBox txtTIM;
        private Label textBox;
        private Button BTIM;
        private GroupBox grp3;
        private DataGridView grd1;
        private GroupBox grp1;
        private TextBox txtSoLuong;
        private TextBox txtTacGia;
        private Label label8;
        private Label label3;
        private TextBox txtTenSach;
        private Label label2;
        private TextBox txtMaSach;
        private Label label1;
        private GroupBox grp2;
        private Button BIN;
        private Button BLUU;
        private Button BSUA;
        private Button BXOA;
        private Button BTHEM;
        private GroupBox groupBox1;
        private DataGridView grd2;
        private GroupBox grp4;
        private Button CHITIET;
        private Button SHOW;
        private DateTimePicker ngayTRA;
        private Label label7;
        private Button BMUON;
        private DateTimePicker ngayMuon;
        private TextBox maSachMuon;
        private TextBox maDGMuon;
        private Label label6;
        private Label label5;
        private Label label4;
    }
}
