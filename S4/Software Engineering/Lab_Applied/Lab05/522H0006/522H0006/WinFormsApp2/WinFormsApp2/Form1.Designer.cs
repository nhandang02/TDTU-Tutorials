namespace WinFormsApp2
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
            grp2 = new GroupBox();
            bPDF = new Button();
            bCANCEL = new Button();
            bSAVE = new Button();
            bEDIT = new Button();
            bDEL = new Button();
            bADD = new Button();
            grp3 = new GroupBox();
            grd = new DataGridView();
            grp1 = new GroupBox();
            txtAu = new TextBox();
            txtBN = new TextBox();
            txtQuan = new TextBox();
            txtBID = new TextBox();
            label2 = new Label();
            label5 = new Label();
            label3 = new Label();
            label1 = new Label();
            bFind = new Button();
            label4 = new Label();
            txtFind = new TextBox();
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
            label8 = new Label();
            label9 = new Label();
            grp2.SuspendLayout();
            grp3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grd).BeginInit();
            grp1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grd2).BeginInit();
            grp4.SuspendLayout();
            SuspendLayout();
            // 
            // grp2
            // 
            grp2.Controls.Add(bPDF);
            grp2.Controls.Add(bCANCEL);
            grp2.Controls.Add(bSAVE);
            grp2.Controls.Add(bEDIT);
            grp2.Controls.Add(bDEL);
            grp2.Controls.Add(bADD);
            grp2.Location = new Point(20, 70);
            grp2.Margin = new Padding(5, 6, 5, 6);
            grp2.Name = "grp2";
            grp2.Padding = new Padding(5, 6, 5, 6);
            grp2.Size = new Size(977, 119);
            grp2.TabIndex = 10;
            grp2.TabStop = false;
            grp2.Text = "Functions";
            // 
            // bPDF
            // 
            bPDF.Location = new Point(801, 35);
            bPDF.Margin = new Padding(5);
            bPDF.Name = "bPDF";
            bPDF.Size = new Size(135, 64);
            bPDF.TabIndex = 12;
            bPDF.Text = "to PDF";
            bPDF.UseVisualStyleBackColor = true;
            bPDF.Click += bPDF_Click;
            // 
            // bCANCEL
            // 
            bCANCEL.Location = new Point(648, 35);
            bCANCEL.Margin = new Padding(5, 6, 5, 6);
            bCANCEL.Name = "bCANCEL";
            bCANCEL.Size = new Size(127, 64);
            bCANCEL.TabIndex = 4;
            bCANCEL.Text = "Cancel";
            bCANCEL.UseVisualStyleBackColor = true;
            bCANCEL.Click += bCANCEL_Click;
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
            bSAVE.Click += bSAVE_Click;
            // 
            // bEDIT
            // 
            bEDIT.Location = new Point(349, 35);
            bEDIT.Margin = new Padding(5, 6, 5, 6);
            bEDIT.Name = "bEDIT";
            bEDIT.Size = new Size(127, 64);
            bEDIT.TabIndex = 3;
            bEDIT.Text = "Edit";
            bEDIT.UseVisualStyleBackColor = true;
            bEDIT.Click += bEDIT_Click;
            // 
            // bDEL
            // 
            bDEL.Location = new Point(195, 35);
            bDEL.Margin = new Padding(5, 6, 5, 6);
            bDEL.Name = "bDEL";
            bDEL.Size = new Size(127, 64);
            bDEL.TabIndex = 2;
            bDEL.Text = "Delete";
            bDEL.UseVisualStyleBackColor = true;
            bDEL.Click += bDEL_Click;
            // 
            // bADD
            // 
            bADD.Location = new Point(39, 35);
            bADD.Margin = new Padding(5, 6, 5, 6);
            bADD.Name = "bADD";
            bADD.Size = new Size(127, 64);
            bADD.TabIndex = 0;
            bADD.Text = "Add";
            bADD.UseVisualStyleBackColor = true;
            bADD.Click += bADD_Click;
            // 
            // grp3
            // 
            grp3.Controls.Add(grd);
            grp3.Location = new Point(20, 394);
            grp3.Margin = new Padding(5, 6, 5, 6);
            grp3.Name = "grp3";
            grp3.Padding = new Padding(5, 6, 5, 6);
            grp3.Size = new Size(977, 528);
            grp3.TabIndex = 11;
            grp3.TabStop = false;
            grp3.Text = "Book's list";
            // 
            // grd
            // 
            grd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grd.Location = new Point(18, 45);
            grd.Margin = new Padding(5, 6, 5, 6);
            grd.Name = "grd";
            grd.RowHeadersWidth = 62;
            grd.RowTemplate.Height = 25;
            grd.Size = new Size(1432, 464);
            grd.TabIndex = 0;
            grd.Click += grd_Click;
            // 
            // grp1
            // 
            grp1.Controls.Add(txtAu);
            grp1.Controls.Add(txtBN);
            grp1.Controls.Add(txtQuan);
            grp1.Controls.Add(txtBID);
            grp1.Controls.Add(label2);
            grp1.Controls.Add(label5);
            grp1.Controls.Add(label3);
            grp1.Controls.Add(label1);
            grp1.Location = new Point(20, 201);
            grp1.Margin = new Padding(5, 6, 5, 6);
            grp1.Name = "grp1";
            grp1.Padding = new Padding(5, 6, 5, 6);
            grp1.Size = new Size(977, 181);
            grp1.TabIndex = 9;
            grp1.TabStop = false;
            grp1.Text = "Book information";
            // 
            // txtAu
            // 
            txtAu.Location = new Point(166, 109);
            txtAu.Margin = new Padding(5, 6, 5, 6);
            txtAu.Name = "txtAu";
            txtAu.Size = new Size(287, 39);
            txtAu.TabIndex = 5;
            // 
            // txtBN
            // 
            txtBN.Location = new Point(668, 35);
            txtBN.Margin = new Padding(5, 6, 5, 6);
            txtBN.Name = "txtBN";
            txtBN.Size = new Size(287, 39);
            txtBN.TabIndex = 1;
            // 
            // txtQuan
            // 
            txtQuan.Location = new Point(668, 104);
            txtQuan.Margin = new Padding(5, 6, 5, 6);
            txtQuan.Name = "txtQuan";
            txtQuan.Size = new Size(287, 39);
            txtQuan.TabIndex = 4;
            // 
            // txtBID
            // 
            txtBID.AcceptsReturn = true;
            txtBID.Location = new Point(166, 35);
            txtBID.Margin = new Padding(5, 6, 5, 6);
            txtBID.Name = "txtBID";
            txtBID.Size = new Size(287, 39);
            txtBID.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(497, 40);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(135, 32);
            label2.TabIndex = 0;
            label2.Text = "Book name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(543, 109);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(106, 32);
            label5.TabIndex = 0;
            label5.Text = "Quantity";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 115);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(87, 32);
            label3.TabIndex = 0;
            label3.Text = "Author";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 46);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(98, 32);
            label1.TabIndex = 0;
            label1.Text = "Book ID";
            // 
            // bFind
            // 
            bFind.Location = new Point(393, 6);
            bFind.Margin = new Padding(5);
            bFind.Name = "bFind";
            bFind.Size = new Size(135, 64);
            bFind.TabIndex = 13;
            bFind.Text = "Find";
            bFind.UseVisualStyleBackColor = true;
            bFind.Click += bFind_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 22);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(60, 32);
            label4.TabIndex = 7;
            label4.Text = "Find";
            // 
            // txtFind
            // 
            txtFind.Location = new Point(96, 19);
            txtFind.Margin = new Padding(5, 6, 5, 6);
            txtFind.Name = "txtFind";
            txtFind.Size = new Size(287, 39);
            txtFind.TabIndex = 6;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(grd2);
            groupBox1.Location = new Point(1007, 394);
            groupBox1.Margin = new Padding(5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(5);
            groupBox1.Size = new Size(727, 528);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "Borrow Book Information";
            // 
            // grd2
            // 
            grd2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grd2.Location = new Point(21, 42);
            grd2.Margin = new Padding(5);
            grd2.Name = "grd2";
            grd2.RowHeadersWidth = 51;
            grd2.RowTemplate.Height = 29;
            grd2.Size = new Size(809, 467);
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
            grp4.Controls.Add(label8);
            grp4.Controls.Add(label9);
            grp4.Location = new Point(1007, 22);
            grp4.Margin = new Padding(5);
            grp4.Name = "grp4";
            grp4.Padding = new Padding(5);
            grp4.Size = new Size(727, 327);
            grp4.TabIndex = 14;
            grp4.TabStop = false;
            grp4.Text = "Borrow Ticket";
            // 
            // CHITIET
            // 
            CHITIET.Location = new Point(500, 242);
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
            SHOW.Location = new Point(280, 242);
            SHOW.Margin = new Padding(5);
            SHOW.Name = "SHOW";
            SHOW.Size = new Size(169, 62);
            SHOW.TabIndex = 9;
            SHOW.Text = "List of Borrow";
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
            label7.Location = new Point(50, 173);
            label7.Margin = new Padding(5, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new Size(129, 32);
            label7.TabIndex = 7;
            label7.Text = "Return day";
            label7.Click += label7_Click;
            // 
            // BMUON
            // 
            BMUON.Location = new Point(50, 242);
            BMUON.Margin = new Padding(5);
            BMUON.Name = "BMUON";
            BMUON.Size = new Size(169, 56);
            BMUON.TabIndex = 6;
            BMUON.Text = "Borrow";
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
            label6.Size = new Size(161, 32);
            label6.TabIndex = 2;
            label6.Text = "Borrowed day";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(390, 42);
            label8.Margin = new Padding(5, 0, 5, 0);
            label8.Name = "label8";
            label8.Size = new Size(95, 32);
            label8.TabIndex = 1;
            label8.Text = "Book Id";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(25, 42);
            label9.Margin = new Padding(5, 0, 5, 0);
            label9.Name = "label9";
            label9.Size = new Size(114, 32);
            label9.TabIndex = 0;
            label9.Text = "Reader Id";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1756, 1178);
            Controls.Add(groupBox1);
            Controls.Add(grp4);
            Controls.Add(label4);
            Controls.Add(bFind);
            Controls.Add(grp2);
            Controls.Add(grp3);
            Controls.Add(txtFind);
            Controls.Add(grp1);
            Margin = new Padding(5);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            grp2.ResumeLayout(false);
            grp3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grd).EndInit();
            grp1.ResumeLayout(false);
            grp1.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grd2).EndInit();
            grp4.ResumeLayout(false);
            grp4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grp2;
        private Button bCANCEL;
        private Button bSAVE;
        private Button bEDIT;
        private Button bDEL;
        private Button bADD;
        private GroupBox grp3;
        private DataGridView grd;
        private GroupBox grp1;
        private ComboBox cbHT;
        private TextBox txtBN;
        private TextBox txtQuan;
        private TextBox txtBID;
        private Label label2;
        private Label label5;
        private Label label3;
        private Label label1;
        private TextBox txtAu;
        private Button bPDF;
        private Button bFind;
        private Label label4;
        private TextBox txtFind;
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
        private Label label8;
        private Label label9;
    }
}
