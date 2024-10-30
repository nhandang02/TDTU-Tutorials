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
            bFind = new Button();
            label4 = new Label();
            grp3 = new GroupBox();
            grd = new DataGridView();
            txtFind = new TextBox();
            grp1 = new GroupBox();
            txtAu = new TextBox();
            txtBN = new TextBox();
            txtQuan = new TextBox();
            txtBID = new TextBox();
            label2 = new Label();
            label5 = new Label();
            label3 = new Label();
            label1 = new Label();
            bADD = new Button();
            bPDF = new Button();
            bCANCEL = new Button();
            bSAVE = new Button();
            bEDIT = new Button();
            grp2 = new GroupBox();
            bDEL = new Button();
            grp3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grd).BeginInit();
            grp1.SuspendLayout();
            grp2.SuspendLayout();
            SuspendLayout();
            // 
            // bFind
            // 
            bFind.Location = new Point(469, 28);
            bFind.Margin = new Padding(5);
            bFind.Name = "bFind";
            bFind.Size = new Size(135, 64);
            bFind.TabIndex = 19;
            bFind.Text = "Find";
            bFind.UseVisualStyleBackColor = true;
            bFind.Click += bFind_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 44);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(60, 32);
            label4.TabIndex = 15;
            label4.Text = "Find";
            // 
            // grp3
            // 
            grp3.Controls.Add(grd);
            grp3.Location = new Point(40, 429);
            grp3.Margin = new Padding(5, 6, 5, 6);
            grp3.Name = "grp3";
            grp3.Padding = new Padding(5, 6, 5, 6);
            grp3.Size = new Size(1482, 477);
            grp3.TabIndex = 18;
            grp3.TabStop = false;
            grp3.Text = "Book's list";
            grp3.Enter += grp3_Enter;
            // 
            // grd
            // 
            grd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grd.Location = new Point(28, 44);
            grd.Margin = new Padding(5, 6, 5, 6);
            grd.Name = "grd";
            grd.RowHeadersWidth = 62;
            grd.RowTemplate.Height = 25;
            grd.Size = new Size(1432, 409);
            grd.TabIndex = 0;
            // 
            // txtFind
            // 
            txtFind.Location = new Point(162, 41);
            txtFind.Margin = new Padding(5, 6, 5, 6);
            txtFind.Name = "txtFind";
            txtFind.Size = new Size(287, 39);
            txtFind.TabIndex = 14;
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
            grp1.Location = new Point(40, 238);
            grp1.Margin = new Padding(5, 6, 5, 6);
            grp1.Name = "grp1";
            grp1.Padding = new Padding(5, 6, 5, 6);
            grp1.Size = new Size(1477, 164);
            grp1.TabIndex = 16;
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
            label2.Location = new Point(499, 43);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(135, 32);
            label2.TabIndex = 0;
            label2.Text = "Book name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(545, 112);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(106, 32);
            label5.TabIndex = 0;
            label5.Text = "Quantity";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 118);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(87, 32);
            label3.TabIndex = 0;
            label3.Text = "Author";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 49);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(98, 32);
            label1.TabIndex = 0;
            label1.Text = "Book ID";
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
            // bPDF
            // 
            bPDF.Location = new Point(772, 35);
            bPDF.Margin = new Padding(5);
            bPDF.Name = "bPDF";
            bPDF.Size = new Size(135, 64);
            bPDF.TabIndex = 12;
            bPDF.Text = "to PDF";
            bPDF.UseVisualStyleBackColor = true;
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
            bEDIT.Location = new Point(361, 35);
            bEDIT.Margin = new Padding(5, 6, 5, 6);
            bEDIT.Name = "bEDIT";
            bEDIT.Size = new Size(127, 64);
            bEDIT.TabIndex = 3;
            bEDIT.Text = "Edit";
            bEDIT.UseVisualStyleBackColor = true;
            bEDIT.Click += bEDIT_Click;
            // 
            // grp2
            // 
            grp2.Controls.Add(bPDF);
            grp2.Controls.Add(bCANCEL);
            grp2.Controls.Add(bSAVE);
            grp2.Controls.Add(bEDIT);
            grp2.Controls.Add(bDEL);
            grp2.Controls.Add(bADD);
            grp2.Location = new Point(40, 103);
            grp2.Margin = new Padding(5, 6, 5, 6);
            grp2.Name = "grp2";
            grp2.Padding = new Padding(5, 6, 5, 6);
            grp2.Size = new Size(1477, 136);
            grp2.TabIndex = 17;
            grp2.TabStop = false;
            grp2.Text = "Functions";
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
            bDEL.Click += bDEL_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1563, 897);
            Controls.Add(bFind);
            Controls.Add(label4);
            Controls.Add(grp3);
            Controls.Add(grp1);
            Controls.Add(grp2);
            Controls.Add(txtFind);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            grp3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grd).EndInit();
            grp1.ResumeLayout(false);
            grp1.PerformLayout();
            grp2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bFind;
        private Label label4;
        private GroupBox grp3;
        private DataGridView grd;
        private TextBox txtFind;
        private GroupBox grp1;
        private TextBox txtAu;
        private TextBox txtBN;
        private TextBox txtQuan;
        private TextBox txtBID;
        private Label label2;
        private Label label5;
        private Label label3;
        private Label label1;
        private Button bADD;
        private Button bPDF;
        private Button bCANCEL;
        private Button bSAVE;
        private Button bEDIT;
        private GroupBox grp2;
        private Button bDEL;
    }
}
