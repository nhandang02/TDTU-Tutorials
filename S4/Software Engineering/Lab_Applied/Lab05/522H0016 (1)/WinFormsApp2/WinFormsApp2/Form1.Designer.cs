﻿namespace WinFormsApp2
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
            grp2.SuspendLayout();
            grp3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grd).BeginInit();
            grp1.SuspendLayout();
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
            grp3.Size = new Size(1482, 528);
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1516, 1178);
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
    }
}
