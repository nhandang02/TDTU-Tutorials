﻿namespace Lab2_522H0006
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
            grp1 = new GroupBox();
            dpDOB = new DateTimePicker();
            cbHT = new ComboBox();
            txtFN = new TextBox();
            txtGPA = new TextBox();
            txtSID = new TextBox();
            label2 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            bCANCEL = new Button();
            grp2 = new GroupBox();
            bPRINT = new Button();
            bSAVE = new Button();
            bEDIT = new Button();
            bDEL = new Button();
            bADD = new Button();
            grp3 = new GroupBox();
            grd = new DataGridView();
            grp1.SuspendLayout();
            grp2.SuspendLayout();
            grp3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grd).BeginInit();
            SuspendLayout();
            // 
            // grp1
            // 
            grp1.Controls.Add(dpDOB);
            grp1.Controls.Add(cbHT);
            grp1.Controls.Add(txtFN);
            grp1.Controls.Add(txtGPA);
            grp1.Controls.Add(txtSID);
            grp1.Controls.Add(label2);
            grp1.Controls.Add(label5);
            grp1.Controls.Add(label4);
            grp1.Controls.Add(label3);
            grp1.Controls.Add(label1);
            grp1.Location = new Point(248, -7);
            grp1.Margin = new Padding(5, 6, 5, 6);
            grp1.Name = "grp1";
            grp1.Padding = new Padding(5, 6, 5, 6);
            grp1.Size = new Size(979, 230);
            grp1.TabIndex = 6;
            grp1.TabStop = false;
            grp1.Text = "Student information";
            // 
            // dpDOB
            // 
            dpDOB.Location = new Point(584, 90);
            dpDOB.Margin = new Padding(5, 6, 5, 6);
            dpDOB.Name = "dpDOB";
            dpDOB.Size = new Size(376, 39);
            dpDOB.TabIndex = 3;
            // 
            // cbHT
            // 
            cbHT.FormattingEnabled = true;
            cbHT.Items.AddRange(new object[] { "Hà Nội", "Sài Gòn" });
            cbHT.Location = new Point(165, 96);
            cbHT.Margin = new Padding(5, 6, 5, 6);
            cbHT.Name = "cbHT";
            cbHT.Size = new Size(286, 40);
            cbHT.TabIndex = 2;
            // 
            // txtFN
            // 
            txtFN.Location = new Point(668, 35);
            txtFN.Margin = new Padding(5, 6, 5, 6);
            txtFN.Name = "txtFN";
            txtFN.Size = new Size(286, 39);
            txtFN.TabIndex = 1;
            // 
            // txtGPA
            // 
            txtGPA.Location = new Point(165, 157);
            txtGPA.Margin = new Padding(5, 6, 5, 6);
            txtGPA.Name = "txtGPA";
            txtGPA.Size = new Size(286, 39);
            txtGPA.TabIndex = 4;
            // 
            // txtSID
            // 
            txtSID.AcceptsReturn = true;
            txtSID.Location = new Point(165, 35);
            txtSID.Margin = new Padding(5, 6, 5, 6);
            txtSID.Name = "txtSID";
            txtSID.Size = new Size(286, 39);
            txtSID.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(518, 47);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(112, 32);
            label2.TabIndex = 0;
            label2.Text = "Fullname";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 169);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(56, 32);
            label5.TabIndex = 0;
            label5.Text = "GPA";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(518, 108);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(63, 32);
            label4.TabIndex = 0;
            label4.Text = "DOB";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 108);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(132, 32);
            label3.TabIndex = 0;
            label3.Text = "Hometown";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 47);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(127, 32);
            label1.TabIndex = 0;
            label1.Text = "Student ID";
            // 
            // bCANCEL
            // 
            bCANCEL.Location = new Point(636, 35);
            bCANCEL.Margin = new Padding(5, 6, 5, 6);
            bCANCEL.Name = "bCANCEL";
            bCANCEL.Size = new Size(126, 64);
            bCANCEL.TabIndex = 4;
            bCANCEL.Text = "Cancel";
            bCANCEL.UseVisualStyleBackColor = true;
            // 
            // grp2
            // 
            grp2.Controls.Add(bPRINT);
            grp2.Controls.Add(bCANCEL);
            grp2.Controls.Add(bSAVE);
            grp2.Controls.Add(bEDIT);
            grp2.Controls.Add(bDEL);
            grp2.Controls.Add(bADD);
            grp2.Location = new Point(248, 231);
            grp2.Margin = new Padding(5, 6, 5, 6);
            grp2.Name = "grp2";
            grp2.Padding = new Padding(5, 6, 5, 6);
            grp2.Size = new Size(983, 122);
            grp2.TabIndex = 7;
            grp2.TabStop = false;
            grp2.Text = "Functions";
            // 
            // bPRINT
            // 
            bPRINT.Location = new Point(772, 35);
            bPRINT.Margin = new Padding(5, 6, 5, 6);
            bPRINT.Name = "bPRINT";
            bPRINT.Size = new Size(126, 64);
            bPRINT.TabIndex = 5;
            bPRINT.Text = "Print";
            bPRINT.UseVisualStyleBackColor = true;
            // 
            // bSAVE
            // 
            bSAVE.Location = new Point(498, 35);
            bSAVE.Margin = new Padding(5, 6, 5, 6);
            bSAVE.Name = "bSAVE";
            bSAVE.Size = new Size(126, 64);
            bSAVE.TabIndex = 1;
            bSAVE.Text = "Save";
            bSAVE.UseVisualStyleBackColor = true;
            // 
            // bEDIT
            // 
            bEDIT.Location = new Point(360, 35);
            bEDIT.Margin = new Padding(5, 6, 5, 6);
            bEDIT.Name = "bEDIT";
            bEDIT.Size = new Size(126, 64);
            bEDIT.TabIndex = 3;
            bEDIT.Text = "Edit";
            bEDIT.UseVisualStyleBackColor = true;
            // 
            // bDEL
            // 
            bDEL.Location = new Point(222, 35);
            bDEL.Margin = new Padding(5, 6, 5, 6);
            bDEL.Name = "bDEL";
            bDEL.Size = new Size(126, 64);
            bDEL.TabIndex = 2;
            bDEL.Text = "Delete";
            bDEL.UseVisualStyleBackColor = true;
            // 
            // bADD
            // 
            bADD.Location = new Point(86, 35);
            bADD.Margin = new Padding(5, 6, 5, 6);
            bADD.Name = "bADD";
            bADD.Size = new Size(126, 64);
            bADD.TabIndex = 0;
            bADD.Text = "Add";
            bADD.UseVisualStyleBackColor = true;
            // 
            // grp3
            // 
            grp3.Controls.Add(grd);
            grp3.Location = new Point(243, 371);
            grp3.Margin = new Padding(5, 6, 5, 6);
            grp3.Name = "grp3";
            grp3.Padding = new Padding(5, 6, 5, 6);
            grp3.Size = new Size(987, 527);
            grp3.TabIndex = 8;
            grp3.TabStop = false;
            grp3.Text = "Student's list";
            // 
            // grd
            // 
            grd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grd.Location = new Point(14, 42);
            grd.Margin = new Padding(5, 6, 5, 6);
            grd.Name = "grd";
            grd.RowHeadersWidth = 62;
            grd.RowTemplate.Height = 25;
            grd.Size = new Size(954, 465);
            grd.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1379, 918);
            Controls.Add(grp1);
            Controls.Add(grp2);
            Controls.Add(grp3);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            grp1.ResumeLayout(false);
            grp1.PerformLayout();
            grp2.ResumeLayout(false);
            grp3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grd).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grp1;
        private DateTimePicker dpDOB;
        private ComboBox cbHT;
        private TextBox txtFN;
        private TextBox txtGPA;
        private TextBox txtSID;
        private Label label2;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private Button bCANCEL;
        private GroupBox grp2;
        private Button bPRINT;
        private Button bSAVE;
        private Button bEDIT;
        private Button bDEL;
        private Button bADD;
        private GroupBox grp3;
        private DataGridView grd;
    }
}
